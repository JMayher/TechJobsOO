using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobs.Data;
using TechJobs.Models;
using System.Linq;

namespace TechJobs.ViewModels
{
    public class NewJobViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Employer")]
        public int EmployerID { get; set; }
        

        // TODO #3 - Included other fields needed to create a job,
        // with correct validation attributes and display names.
        [Required]
        [Display(Name = "Location")]
        public int LocationID { get; set; }
       

        [Required]
        [Display(Name = "Skill")]
        public int CoreCompetencyID { get; set; }
        

        [Required]
        [Display(Name = "Position Type")]
        public int PositionTypeID { get; set; }
       

        public List<SelectListItem> Employers { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> Locations { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> CoreCompetencies { get; set; } = new List<SelectListItem>();
        public List<SelectListItem> PositionTypes { get; set; } = new List<SelectListItem>();

        public NewJobViewModel()
        {

            JobData jobData = JobData.GetInstance();

            foreach (Employer field in jobData.Employers.ToList())
            {
                Employers.Add(new SelectListItem
                {
                    Value = field.ID.ToString(),
                    Text = field.Value
                });
            }
            foreach (Location field1 in jobData.Locations.ToList())
            {
                Locations.Add(new SelectListItem
                {
                    Value = field1.ID.ToString(),
                    Text = field1.Value
                });
            }
        
                foreach (CoreCompetency field2 in jobData.CoreCompetencies.ToList())
                {
                    CoreCompetencies.Add(new SelectListItem
                    {
                        Value = field2.ID.ToString(),
                        Text = field2.Value
                    });
                }
                foreach (PositionType field3 in jobData.PositionTypes.ToList())
                {
                    PositionTypes.Add(new SelectListItem
                    {
                        Value = field3.ID.ToString(),
                        Text = field3.Value
                    });
                }

                // TODO #4 - populate the other List<SelectListItem> 
                // collections needed in the view
            
        }
    }
}
