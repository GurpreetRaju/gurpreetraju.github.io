using GurpreetRaju.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.ComponentModel.DataAnnotations;

namespace GurpreetRaju.Pages
{
    /// <summary>
    /// Code behind file.
    /// </summary>
    public partial class Contact
    {
        private ContactFormModel _formModel = new();
        private bool _success = false;
        private string _errorMessage = string.Empty;

        /// <summary>
        /// Captha Service.
        /// </summary>
        [Inject]
        private CaptchaService CaptchaService { get; set; }

        /// <summary>
        /// Captcha Site Key.
        /// </summary>
        private string SiteKey => Environment.GetEnvironmentVariable("CAPTCHA_KEY") ?? "";

        /// <summary>
        /// Form ID for the contact form submission endpoint.
        /// </summary>
        private string FormId => Environment.GetEnvironmentVariable("CONTACT_FORM_ID") ?? "";

        /// <summary>
        /// Handles the form submission when it is valid.
        /// </summary>
        /// <returns></returns>
        private async Task HandleValidSubmit()
        {
            try
            {
                var token = await JS.InvokeAsync<string>("grecaptcha.getResponse");
                if (string.IsNullOrWhiteSpace(token) || !await CaptchaService.VerifyRecaptchaAsync(token))
                {
                    _errorMessage = "CAPTCHA validation failed. Please try again.";
                    return;
                }

                var httpClient = new HttpClient();
                var content = new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "name", _formModel.Name },
                    { "email", _formModel.Email },
                    { "phone", _formModel.Phone },
                    { "message", _formModel.Message }
                });

                var response = await httpClient.PostAsync(FormId, content);
                if (response.IsSuccessStatusCode)
                {
                    _success = true;
                    _errorMessage = string.Empty;
                    _formModel = new();
                    await JS.InvokeVoidAsync("grecaptcha.reset");
                }
                else
                {
                    _errorMessage = "Failed to send message. Please try again later.";
                }
            }
            catch (Exception ex)
            {
                _errorMessage = $"Error: {ex.Message}";
            }
        }
    }

    /// <summary>
    /// Model for the contact form.
    /// </summary>
    public class ContactFormModel
    {
        /// <summary>
        /// Name of the person submitting the form.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Email address of the person submitting the form.
        /// </summary>
        [Required, EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Phone number of the person submitting the form.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Message content of the form submission.
        /// </summary>
        [Required]
        public string Message { get; set; }
    }
}
