﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SoccerJerseyPass.Models
{
    public class Player
    {
        [Key]

        public int Id { get; set; }

        [Display (Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]

        public string FullName { get; set; }

        [Display (Name= "Biography")]

        public string Bio { get; set; }

        // Relationships 

        public List <Player_Jersey > player_Jersey { get; set; }
    }
}
