using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CoLearner.API.Model
{
    [Table("tblMstMenu")]
    public class Menu
    {
        public int SeqNbr { get; set; }   
        [Key] 
        public int MenuId { get; set; } 
        [StringLength(500)]
        public string MenuDesc { get; set; }
        public string CurrStatus { get; set; }
        public string  UrlPath { get; set; }
    }
}