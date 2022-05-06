using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DaxAmmonsFinalProject.Models

{
 public class Stats

 {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int StatsId{get;set;}
     
     [Display (Name ="Enter Strength Value")]
     [Required(ErrorMessage ="Strength value is required!!")]
     public int Strength {get;set;}

     [Display (Name ="Enter Speed Value")]
     [Required(ErrorMessage ="Speed value is required!!")]
     public int Speed {get;set;}
     
    [Display (Name ="Enter Intelligence Value")]
     [Required(ErrorMessage ="Intelligence value is required!!")]
     public int Intelligence {get;set;}
     
     [Display (Name ="Enter Charisma Value")]
     [Required(ErrorMessage ="Charisma value is required!!")]
     public int Charisma {get;set;}
     
     [Display (Name ="Enter Armor Value")]
     [Required(ErrorMessage ="Speed Armor is required!!")]
     public int Armor {get;set;}
 }
}
     