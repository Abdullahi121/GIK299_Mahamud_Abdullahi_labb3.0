namespace GIK299_Mahamud_Abdullahi_labb3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hair hair = new Hair { hairlength = "10cm", haircolor = "Dark" };
            Gender gender = Gender.Male;
            string eyecolor = new string("Brown");
            DateTime Birthday = new DateTime(1999, 12, 31);
            Person person = new Person(Birthday, eyecolor, gender, hair);
            Console.WriteLine(person.ToString());
        }
    }
}