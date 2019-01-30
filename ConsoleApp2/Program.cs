using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class program
    {
        static void Main(string[]args)
        {
            countryside blue = new countryside();
            blue.Launch();

        }
    }
    class Village
    {
           
        public Village nextVillage;
        public Village previousVillage;
        public string Villagename;
        public bool isAstrildeHere = false;
        
    }
    class countryside
    {
        Village Maple = new Village();
        Village Toronto = new Village();
        Village Ajax = new Village();
        Village First;
        Village Last;
        Village temp;

        public void Launch()
        {
           
            Village First = Maple;
            Village Last = Ajax;
            Maple.Villagename = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.Villagename = "Toronto";
            Toronto.previousVillage = Maple;
            Toronto.nextVillage = Ajax;
            Ajax.Villagename = "Ajax";
            Ajax.nextVillage = null;
            Ajax.nextVillage = Toronto;
            Console.WriteLine(this.displayMap());
        }
        public string displayMap()
        {
            string listOfCities = "";
            while (true)
            {
                listOfCities = listOfCities + First.Villagename + "_______";
                temp = First.nextVillage;
                listOfCities = listOfCities + temp.Villagename + "________";

            }
            return ""; 
               
        }
    }
}
