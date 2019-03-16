
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreCrud.Models
{
    public class Team
    {
        [Key]
        
        public int Id { get; set; }
        

        [Required]
        [StringLength(20 , MinimumLength=3,ErrorMessage="Team Name should be between 3 to 20 characters")]
        public string Name{get; set;}

        
        [Range(100,1000,ErrorMessage="Revenue should be between 100 and 1000")]
        [Display(Name="Team Revenue")]
        public decimal TeamRevenue{get; set;}

        [Display(Name="Team Formed Date")]
        [CustomValidation(typeof(Team),"DateFormedToBePast")]
        [DataType(DataType.Date)]
        public DateTime? DateFound{get; set;}

       
        public Boolean? IsAmerican{get; set;}

        public int CountryId{get; set;}

        public Country Country {get; set;}

        public static ValidationResult DateFormedToBePast(DateTime? formedDate , ValidationContext context) {

           if(formedDate==null) {
               return ValidationResult.Success;
            }
            if(formedDate < DateTime.Today) {
                return  ValidationResult.Success;
            }
            return new ValidationResult("The formed date of the team should be a past date");
        }




        [NotMapped]
        public  String JuniorOrSenior{
            get {
                if(DateFound >= DateTime.Parse("01/01/2017").Date) {
                    return "Junior";
                }

                return "Senior";
            }
        }

        
        // ADD PROPERTIES HERE
    }
}
            