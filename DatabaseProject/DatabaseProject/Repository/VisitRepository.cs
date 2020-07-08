using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Repository
{
    public class VisitRepository
    {
        private TestContext _context = new TestContext();

        public List<Visit> FindAll()
        {
            return this._context.Visit.ToList<Visit>();
        }

        public Visit FindById(int id)
        {
            return this._context.Visit.Find(id);
        }

        public List<Visit> FindByCaseID(int id)
        {
            return this._context.Visit.Where(x => x.idCase == id).ToList();
        }

        public void Create(Visit p)
        {
            this._context.Visit.Add(p);
            this._context.SaveChanges();
        }

        public void Update(Visit p)
        {
            //SPRAVNY ZPUSOB
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Visit p)
        {
            this._context.Visit.Remove(p);
            this._context.SaveChanges();
        }
    }
}
