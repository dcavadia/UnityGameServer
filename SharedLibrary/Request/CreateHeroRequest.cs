using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Requests
{
    public class CreateHeroRequest
    {
        public int Id { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }

        public User User { get; set; }
    }
}
