using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BookStore.Data.Models;

/// <summary>
        /// ApplicationUser class will inherit the class IdentityUser so that we can add a field Name to User's Identity table in database
/// </summary>
public class ApplicationUser : IdentityUser
{
    
/// <summary>
        /// Gets or sets the name of the user. Maximum length is 30 characters.
/// </summary>
 [MaxLength(30)] 
   public string? Name { get; set; }
}