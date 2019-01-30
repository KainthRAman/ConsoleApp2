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
            //node
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
        Village first;
        Village last;
        public void Launch()
        {
            Maple.Villagename = "Maple";
            Maple.nextVillage = Toronto;
            Maple.previousVillage = null;
            Toronto.Villagename = "Toronto";
            Toronto.previousVillage = Maple;
            Toronto.nextVillage = Ajax;
            Ajax.Villagename = "Ajax";
            Ajax.nextVillage = null;
            Ajax.nextVillage = Toronto;
        }
    }
}
