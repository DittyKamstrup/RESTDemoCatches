using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CatchLibrary;

namespace RESTDemoCatches
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private static List<Catch> catches = new List<Catch>
        {
            new Catch(1, "Peter", "Torsk", 3.4, "Øresund", 22),
            new Catch(2, "Martin", "Skalle", 1.2, "Furesø", 23),
            new Catch {ID=3, Navn = "Vibeke", Art = "Ørred", Sted = "Øresund", Vaegt = 2.2, Uge = 24}
        };

        public void AddCatch(Catch newCatch)
        {
            catches.Add(newCatch);
        }

        public Catch DeleteCatch(int id)
        {
            var deleteCatch = GetOneCatch(id.ToString());
            if (deleteCatch != null)
            {
                catches.Remove(deleteCatch);
                return deleteCatch;
            }

            return null;
        }

        public IList<Catch> GetCatches()
        {
            return catches;
        }

        public Catch GetOneCatch(string id)
        {
            int idint = Int32.Parse(id);
            return catches.Find(c => c.ID == idint);
        }

        public Catch UpdateCatch(Catch myCatch)
        {
            var updateCatch = GetOneCatch(myCatch.ID.ToString());
            if (updateCatch != null)
            {
                //updateCatch.ID = myCatch.ID;
                updateCatch.Navn = myCatch.Navn;
                updateCatch.Art = myCatch.Art;
                updateCatch.Vaegt = myCatch.Vaegt;
                updateCatch.Sted = myCatch.Sted;
                updateCatch.Uge = myCatch.Uge;
            }
            return null;
        }
    }
}
