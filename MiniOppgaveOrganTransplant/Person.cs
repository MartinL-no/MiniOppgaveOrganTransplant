using System;
namespace MiniOppgaveOrganTransplant
{
    public class Person
    {
        public string name { get; private set; }
        public int kidneys { get; private set; }

        public Person(string name, int kidneys)
        {
            this.name = name;
            this.kidneys = kidneys;
        }
        public bool GiveKidney(Person person)
        {
            if (kidneys == 2 && person.kidneys < 2)
            {
                person.TransplantKidney();
                this.kidneys--;
                Console.WriteLine($"{this.name} has donated a kidney, they now have {this.kidneys} kidney");
                return true;
            }
            else
            {
                Console.WriteLine($"{this.name} cannot donate a kidney, he does not have two kidneys");
                return false;
            }
        }
        public void TransplantKidney()
        {
            this.kidneys++;
            Console.WriteLine($"Kidney transplanted, {this.name} now has {this.kidneys} kidneys");
        }
    }
}

