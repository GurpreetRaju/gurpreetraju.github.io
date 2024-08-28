using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace GurpreetRaju.Pages
{
    public partial class Experience
    {
        private bool _showAlternateTimelime;

        private ExperienceEntry[] _experiences = [
            new ExperienceEntry {
                Role = "Senior Software Developer",
                Company = "The PEER Group Inc.",
                Location = "Kitchener, ON",
                StartDate = DateTime.Parse("08-01-2024"),
                LogoImage = "images/peergroup_logo.png",
                Responsibilities =
                [
                    "Worked on ASP.Net Blazor server application that runs in containers on Azure Cloud. Integrated Entra ID, added docker support and implemented services that interact with a data broker using gRPC. Involved in requirement gathering, design, development and testing phases.",
                    "Worked on timekeeping project written in Angular, ASP.NET and SQL.",
                    "Gathered customer requirements and transformed into functional specification.",
                    "Provided support to customer for triaging issues.",
                    "Mentored new team members and performed code reviews for peers.",
                ]
            },
            new ExperienceEntry {    
                Role = "Intermediate Software Developer",
                Company = "The PEER Group Inc.",
                Location = "Kitchener, ON",
                StartDate = DateTime.Parse("10-01-2020"),
                EndDate = DateTime.Parse("08-01-2024"),
                LogoImage = "images/peergroup_logo.png",
                Responsibilities = 
                [   
                    "Worked on ASP.Net Blazor server application that runs in containers on Azure Cloud. Integrated Entra ID, added docker support and implemented services that interact with a data broker using gRPC. Involved in requirement gathering, design, development and testing phases.",
                    "Worked on a MES system written in ASP.NET, Blazor UI, gRPC and SQL for tracking substrates and schedule analysis etc.",
                    "Worked on SEMI tool automation software (PTO/EIB) written in .NET Framwework, WPF and WCF, Blazor, gRPC. Implemented new WPF UIs and WCF services to interact with the back end server. Supported complex process flow scheduling in the tool.",
                    "Travelled to customer sites for software integration.",
                    "Worked on timekeeping project written in Angular, ASP.NET and SQL.",
                    "Gathered customer requirements and transformed into functional specification.",
                    "Provided support to customer for triaging issues.",
                    "Mentored new team members and performed code reviews for peers.",
                ]
            },
            new ExperienceEntry {    
                Role = "Junior Software Developer",
                Company = "The PEER Group Inc.",
                Location = "Kitchener, ON",
                StartDate = DateTime.Parse("01/10/2019"),
                EndDate = DateTime.Parse("09-30-2020"),
                LogoImage = "images/peergroup_logo.png",
                Responsibilities = 
                [   
                    "Worked on SEMI tool automation software (PTO/EIB) written in .NET Framwework, WPF and WCF, Blazor, gRPC. Implemented new WPF UIs and WCF services to interact with the back end server. Supported complex process flow scheduling in the tool.",
                    "Travelled to customer sites for software integration.",
                    "Gathered customer requirements and transformed into functional specification.",
                    "Provided support to customer for triaging issues.",
                ]
            }, 
            new ExperienceEntry {    
                Role = "Quality Assurance Analyst",
                Company = "NCR Corporation",
                Location = "Waterloo, ON",
                StartDate = DateTime.Parse("03/01/2018"),
                EndDate = DateTime.Parse("12/31/2018"),
                LogoImage = "images/ncr_logo.png",
                Responsibilities = 
                [
                    "Develop and maintain web interface for database using Java and Angular JS.",
                    "Maintain MariaDB database and write SQL procedures.",
                    "Maintain Testing application.",
                    "Execute test plans for routine and non-routine analyses of ATM",
                    "Modify and extract data by running SQL queries and procedures using MySQL workbench for daily updates",
                    "Compile test results, compare them to established specifications and control limits and make recommendations on appropriate test procedures for further testing",
                    "Collect documentation needed to support testing procedures including data capture forms, equipment logbooks and inventory forms as per the company standards",
                    "Calibrate and record complex components for reliability, engineering and stress tests"
                ]
            }, 
            new ExperienceEntry {    
                Role = "Customer Service Representative",
                Company = "Tim Hortons STL",
                Location = "Montreal, QC",
                StartDate = DateTime.Parse("05/01/2017"),
                EndDate = DateTime.Parse("02/28/2018"),
                LogoImage = "images/tim_logo.png"
            },            
            new ExperienceEntry {    
                Role = "Freelance Developer",
                Location="Nawanshahr, Punjab, India",
                StartDate = DateTime.Parse("06/01/2014"),
                EndDate = DateTime.Parse("11/30/2015"),
                LogoImage = "images/freel_logo.png",
                Responsibilities = [
                    "Developing custom web and desktop applications using PHP, Java, HTML/CSS.",
                    "Perform unit testing(JUnit), cross platform testing.",
                    "Designing Google Banner Ads with Photoshop CS5.",
                    "Maintain and build clean and reusable Java code.",
                    "Enhance UI with HTML/CSS, Jquery and javascript."
                ]
            },         
            new ExperienceEntry {    
                Role = "Web Developer InternshipWeb Developer Internship",
                Company = "Meshcron Technologies P. Ltd",
                Location = "Chandigarh Area, India",
                StartDate = DateTime.Parse("06/01/2014"),
                EndDate = DateTime.Parse("11/30/2015"),
                LogoImage = "images/mesh_logo.png",
                Responsibilities = [
                    "Designing front ends with HTML/CSS, JQuery, JavaScript",
                    "Front end to Back end development (Wordpress, PHP, JSP, Java Servlets)",
                    "Customizing existing websites.",
                    "Managing MySQL Databases.",
                    "Designing Google Ads"
                ]
            },            
        ];




        [CascadingParameter]
        public Breakpoint Breakpoint { get; set; }

        [Inject]
        private IBrowserViewportService BrowserViewportService { get; set; }

        /// <inheritdoc/>
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();

            _showAlternateTimelime = await BrowserViewportService.IsBreakpointWithinReferenceSizeAsync(Breakpoint.SmAndUp, Breakpoint);
        }

        private string GetDuration(ExperienceEntry experience)
        {
            string timeDuration = string.Empty;
            if (experience?.StartDate != null)
            {
                timeDuration = experience.StartDate.Value.ToString("MMM yyyy");
            }
            if (experience?.EndDate != null)
            {
                timeDuration = string.Join(" - ", timeDuration, experience.EndDate.Value.ToString("MMM yyyy"));
            }
            
            return timeDuration;
        }
    }

    public class ExperienceEntry
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Role { get; set; }

        public string Company { get; set; }

        public string Location { get; set; }

        public string LogoImage { get; set; }

        public string[] Responsibilities { get; set; }
    }
}
