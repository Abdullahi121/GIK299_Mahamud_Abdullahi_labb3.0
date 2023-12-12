using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Mahamud_Abdullahi_labb3._0
{
    public class Person
    {
        public object birthday;

        public DateTime Birthday { get; set; }

        public Hair hair { get; set; }

        public Gender gender { get; set; }

        public string eyecolor { get; set; }
        public Person(DateTime birthday, string Eyecolor, Gender GENDER, Hair haiR)
        {
            gender = GENDER;
            eyecolor = Eyecolor;
            hair = haiR;
            Birthday = birthday;


        }

        public override string ToString()
        {
            return $"Kön: {gender} \n" +
                   $"Hårfärg: {eyecolor} \n" +
                   $"Ögonfärg: {hair.haircolor} \n" +
                   $"Födelsedatum: {Birthday:yyyy/M/d}";
        }
    }
}
