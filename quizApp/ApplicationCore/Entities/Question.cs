using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Question
    {
        public int Id { get; set; }

        public string Type { get; set; }  

        public string specificQuestion { get; set; }  // dot net convention, capitalize

        public string specificAnswer { get; set; }

    }
}
