using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CoreCrud.Models

{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [RegularExpression(@"[a-zA-Z\s]+",ErrorMessage="Only alphabets and spaces are allowed")]
        [Display(Name="Country")]
        [CustomValidation(typeof(Country),"CountryNameUnique")]
        public string Name{get; set;}

        public ICollection<Team> Teams{get; set;}

        public static ValidationResult CountryNameUnique(string name , ValidationContext context) {
            var instance  = context.ObjectInstance as Country;
            var databaseContext = context.GetService(typeof(AppDbContext)) as AppDbContext;
            
            int countryCount = databaseContext.Country
                                    .Count(x=>x.Name==name);
            
            if(countryCount >0 ) {
                return new ValidationResult("Country Name should be unique");
            }
            return ValidationResult.Success;
        }
        // ADD PROPERTIES HERE
    }
}
            