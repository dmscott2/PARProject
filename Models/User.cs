using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PARProject.Models
{
    public class User{
        public int UserID{get; set;}
        public int Password{get; set;}
        public Profile Profile { get; set; }

    }
}