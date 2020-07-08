using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class CaseRepository
    {
        private TestContext _context = new TestContext();

        public List<Case> FindAll()
        {
            return this._context.Cases.ToList<Case>();
        }

        public Case FindById(int id)
        {
            return this._context.Cases.Find(id);
        }

        public Case FindByName(string name)
        {
            return this._context.Cases.Where(x => x.Name == name).FirstOrDefault();
        }

        public Case FindByPatientId(int id)
        {
            return this._context.Cases.Where(x => x.idPatient == id).FirstOrDefault();
        }

        public List<Case> FindByPatientId_List(int id)
        {
            return this._context.Cases.Where(x => x.idPatient == id).ToList();
        }

        public void Create(Case p)
        {
            this._context.Cases.Add(p);
            this._context.SaveChanges();
        }

        public void Update(Case p)
        {
            //SPRAVNY ZPUSOB
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Case p)
        {
            this._context.Cases.Remove(p);
            this._context.SaveChanges();
        }
    }
}
