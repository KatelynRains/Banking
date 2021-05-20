using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTutorial
{
    class Major
    {

        private static int NextId { get; set; } = 1;
        public int Id { get; private set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public Major(string description)
        {
            this.Id = NextId;
            NextId++;
            this.Description = description; 


        }

    }
}
