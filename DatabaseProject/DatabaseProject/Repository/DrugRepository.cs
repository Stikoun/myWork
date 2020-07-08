using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class DrugRepository
    {
        private TestContext _context = new TestContext();

        public List<Drug> FindAll()
        {
            return this._context.Drugs.ToList<Drug>();
        }

        public Drug FindById(int id)
        {
            return this._context.Drugs.Find(id);
        }

        public List<Drug> FindByCategory(string category)
        {
            return this._context.Drugs.Where(x => x.Category == category).ToList<Drug>();
        }

        public Drug FindByName(string name)
        {
            return this._context.Drugs.Where(x => x.Name == name).FirstOrDefault();
        }

        public void Create(Drug p)
        {
            this._context.Drugs.Add(p);
            this._context.SaveChanges();
        }

        public void Update(Drug p)
        {
            //SPRAVNY ZPUSOB
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(Drug p)
        {
            this._context.Drugs.Remove(p);
            this._context.SaveChanges();
        }
    }
}
