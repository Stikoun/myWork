using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DoctorRepository
    {
        private TestContext _context = new TestContext();

        public List<Doctor> FindAll()
        {
            return this._context.Doctors.ToList<Doctor>();
        }

        public Doctor FindById(int id)
        {
            return this._context.Doctors.Find(id);
        }

        public Doctor FindByName(string name, string surname)
        {
            return this._context.Doctors.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
        }

        public void Create(Doctor p)
        {
            this._context.Doctors.Add(p);
            this._context.SaveChanges();              
        }

        public void Update(Doctor p)
        {
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Doctor p)
        {
            this._context.Doctors.Remove(p);
            this._context.SaveChanges();
        }
    }
}
