using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchLibrary
{
    public class Catch
    {
        public int ID { get; set; }
        public string Navn { get; set; }
        public string Art { get; set; }
        public double Vaegt { get; set; }
        public string Sted { get; set; }
        public int Uge { get; set; }

        public Catch()
        {

        }

        public Catch(int id, string navn, string art, double vaegt, string sted, int uge)
        {
            ID = id;
            Navn = navn;
            Art = art;
            Vaegt = vaegt;
            Sted = sted;
            Uge = uge;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Navn: {Navn}, Art: {Art}, Vaegt: {Vaegt}, Sted: {Sted}, Uge: {Uge}";
        }


    }
}
