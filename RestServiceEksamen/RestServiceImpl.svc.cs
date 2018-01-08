using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestServiceEksamen
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RestServiceImpl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RestServiceImpl.svc or RestServiceImpl.svc.cs at the Solution Explorer and start debugging.
    public class RestServiceImpl : IRestServiceImpl
    {
        private static readonly IList<Catch> Catches = new List<Catch>();
        private static int _nextId = 4;

        static RestServiceImpl()
        {
            Catch firstCatch = new Catch
            {
                id = 1,
                art = "abe",
                navn = "kommi",
                uge = 3
            };

            Catches.Add(firstCatch);
        }
        public Catch AddCatch(Catch catchs)
        {
            catchs.id = _nextId++;
            Catches.Add(catchs);
            return catchs;
        }

        public Catch DeleteCatch(string id)
        {
            foreach (var i in Catches)
            {
                if(i.id == int.Parse(id))
                {
                    Catches.Remove(i);
                }
            }
            return null;
        }

        public void DoWork()
        {
        }

        public Catch GetCatch(string id)
        {
            return Catches.FirstOrDefault(x => x.id == int.Parse(id));
        }

        public IList<Catch> GetCatches()
        {
            return Catches;
        }

        public Catch UpdateCatch(string id, Catch catchs)
        {
            int idNumber = int.Parse(id);
            Catch existingCatch = Catches.FirstOrDefault(b => b.id == idNumber);
            if (existingCatch == null) return null;
            existingCatch.navn = catchs.navn;
            existingCatch.art = catchs.art;
            existingCatch.uge = catchs.uge;
            return existingCatch;
        }
    }
}
