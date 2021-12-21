using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoLearner.API.Model
{
    [Table("tblTechnology")]
    public class TechFramework
    {
        public int Id { get; set; }     
        public string TechName { get; set; } 
        public string NavigationPath { get; set; }
    }
}