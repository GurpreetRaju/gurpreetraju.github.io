using System.Text.Json;
using System.Text.Json.Serialization;

namespace GurpreetRaju.Service
{
    /// <summary>
    /// The captcha service.
    /// </summary>
    public class CaptchaService
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// The secret key for reCAPTCHA verification, retrieved from environment variables.
        /// </summary>
        private string SecretKey => Environment.GetEnvironmentVariable("CAPTCHA_SECRET_KEY") ?? "";

        /// <summary>
        /// Initializes a new instance of the <see cref="CaptchaService"/> class.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="httpClient"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public CaptchaService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// Verifies the reCAPTCHA token asynchronously.
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<bool> VerifyRecaptchaAsync(string token)
        {
            var response = await _httpClient.PostAsync(
                "https://www.google.com/recaptcha/api/siteverify",
                new FormUrlEncodedContent(new Dictionary<string, string>
                {
                    { "secret", SecretKey },
                    { "response", token }
                }));

            var json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<RecaptchaResponse>(json);
            return result?.Success == true;
        }

        /// <summary>
        /// Response model for reCAPTCHA verification.
        /// </summary>
        public class RecaptchaResponse
        {
            /// <summary>
            /// Indicates whether the reCAPTCHA verification was successful.
            /// </summary>
            [JsonPropertyName("success")]
            public bool Success { get; set; }

            /// <summary>
            /// Timestamp of the challenge.
            /// </summary>
            [JsonPropertyName("challenge_ts")]
            public string ChallengeTs { get; set; }

            /// <summary>
            /// The hostname of the site where the reCAPTCHA was solved.
            /// </summary>
            [JsonPropertyName("hostname")]
            public string Hostname { get; set; }

            /// <summary>
            /// List of error codes if the verification failed.
            /// </summary>
            [JsonPropertyName("error-codes")]
            public List<string> ErrorCodes { get; set; }

            /// <summary>
            /// Score of the reCAPTCHA verification, if applicable (v3).
            /// </summary>
            [JsonPropertyName("score")]
            public float Score { get; set; }

            /// <summary>
            /// Action name for reCAPTCHA v3, if applicable.
            /// </summary>
            [JsonPropertyName("action")]
            public string Action { get; set; }
        }
    }
}
