using System.Data;
using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Photographer
    {

        public int PhotographerId { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
        public String Gender { get; set; }

        public String Email { get; set; }
        public String WorkTitle { get; set; }
        public String Country { get; set; }
        public String City { get; set; }
        public String Password { get; set; }
        public String ProfilePictureName { get; set; }


    }
}