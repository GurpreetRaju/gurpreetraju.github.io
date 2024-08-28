using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GurpreetRaju.Pages
{
    public partial class Education
    {
        private bool _showAlternateTimelime = true;

        private EducationEntry[] _entries =
            [
                new EducationEntry {
                StartYear = "2016",
                EndYear = "2017",
                Name = "Master of Engineering (Software Engineering)",
                Image="images/concordia_logo.png",
                Institute="Concordia University",
                Location = "Montreal, QC, Canada"
            },
            new EducationEntry {
                StartYear="2010",
                EndYear = "2014",
                Name="Bachelor of Technology, Computer Science",
                Image="images/gndec_logo.png",
                Institute="Guru Nanak Dev Engineering College",
                Location="Ludhiana, India"
            },
            new EducationEntry {
                EndYear = "2010",
                Name="Higher secondary education, (Non Medical)",
                Image="images/gnm_logo.jpg",
                Institute="Guru Nanak Mission Public Sen. Sec. School",
                Location="Dhahan Kaleran, Punjab, India"
            }
        ];


        [CascadingParameter]
        public Breakpoint Breakpoint { get; set; }

        [Inject]
        private IBrowserViewportService BrowserViewportService { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            _showAlternateTimelime = await IsApplicable(Breakpoint.SmAndUp);
        }

        /// <summary>
        /// Check if break point is applicable.
        /// </summary>
        /// <param name="breakpoint"></param>
        /// <returns></returns>
        private Task<bool> IsApplicable(Breakpoint breakpoint)
        {
            return BrowserViewportService.IsBreakpointWithinReferenceSizeAsync(breakpoint, Breakpoint);
        }

        private string GetDuration(EducationEntry education)
        {
            string timeDuration = string.Empty;
            if (education?.StartYear != null)
            {
                timeDuration = education.StartYear + " - ";
            }
            if (education?.EndYear != null)
            {
                timeDuration += education.EndYear;
            }

            return timeDuration;
        }

        private class EducationEntry
        {

            public string StartYear { get; set; }

            public string EndYear { get; set; }

            public string Name { get; set; }

            public string Institute { get; set; }

            public string Image { get; set; }

            public string Location { get; set; }
        }
    }
}
