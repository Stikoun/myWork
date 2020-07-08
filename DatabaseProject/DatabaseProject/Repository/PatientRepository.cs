using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class PatientRepository
    {
        private TestContext _context = new TestContext();

        public List<Patient> FindAll()
        {
            return this._context.Patients.ToList<Patient>();
        }

        public Patient FindById(int id)
        {
            return this._context.Patients.Find(id);
        }

        public void Create(Patient p)
        {
            this._context.Patients.Add(p);
            this._context.SaveChanges();
        }

        public void Update(Patient p)
        {
            //SPRAVNY ZPUSOB
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Patient p)
        {
            this._context.Patients.Remove(p);
            this._context.SaveChanges();
        }
    }
}
