﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace MVC_EryazSoftwareTask.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.    

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("EryazTaskCon", throwIfV1Schema: false)
        {
        }

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}