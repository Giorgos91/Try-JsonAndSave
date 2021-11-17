using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    class people
    {
        [JsonProperty ("name")]
        public string name { get; set; }

        [JsonProperty("surname")]
        public string surname { get; set; }

        [JsonProperty("age")]
        public int  age { get; set; }

        public people() { }

        public people(string name,string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

    }
}
