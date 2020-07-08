using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DiagnosisRepository
    {
        private TestContext _context = new TestContext();

        public List<Diagnosis> FindAll()
        {
            return this._context.Diagnosis.ToList<Diagnosis>();
        }

        public Diagnosis FindById(int id)
        {
            return this._context.Diagnosis.Find(id);
        }

        public List<Diagnosis> FindByCategory(string category)
        {
            return this._context.Diagnosis.Where(x => x.Category == category).ToList<Diagnosis>();
        }

        public void Create(Diagnosis p)
        {
            this._context.Diagnosis.Add(p);
            this._context.SaveChanges();
        }

        public void Update(Diagnosis p)
        {
            //SPRAVNY ZPUSOB
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Diagnosis p)
        {
            this._context.Diagnosis.Remove(p);
            this._context.SaveChanges();
        }
    }
}
