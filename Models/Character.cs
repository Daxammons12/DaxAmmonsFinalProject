using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace DaxAmmonsFinalProject.Models

{
 public class Characters
 {
     [Key]
     [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     public int CharacterId{get;set;}
     [Display (Name ="Enter First Name")]
     [Required(ErrorMessage ="First Name is Required!!")]
     public string FirstName{get;set;}
     
     [Display (Name ="Enter Last Name")]
     [Required(ErrorMessage ="Last Name is Required!!")]
     public string LastName{get;set;}

     

    
     
 }
}