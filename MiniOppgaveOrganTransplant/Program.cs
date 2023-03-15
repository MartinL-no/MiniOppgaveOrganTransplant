using System;

namespace MiniOppgaveOrganTransplant
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Martin = new Person("Martin", 2);
            Person Terje = new Person("Terje", 0);

            Martin.GiveKidney(Terje);
        }
    }
}

