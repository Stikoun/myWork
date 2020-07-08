using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Repository
{
    public class DiagnosisDrugRepository
    {
        private TestContext _context = new TestContext();

        public List<DiagnosisDrugs> FindAll()
        {
            return this._context.DiagnosisDrugs.ToList<DiagnosisDrugs>();
        }

        public List<DiagnosisDrugs> FindByidDrug(int id)
        {
            return this._context.DiagnosisDrugs.Where(x => x.idDrug == id).ToList<DiagnosisDrugs>();
        }

        public List<DiagnosisDrugs> FindByidDiagnosis(int id)
        {
            return this._context.DiagnosisDrugs.Where(x => x.idDiagnosis == id).ToList<DiagnosisDrugs>();
        }

        public void Create(DiagnosisDrugs p)
        {
            this._context.DiagnosisDrugs.Add(p);
            this._context.SaveChanges();
        }

        public void Update(DiagnosisDrugs p)
        {
            //SPRAVNY ZPUSOB
            this._context.Entry(p).State = System.Data.Entity.EntityState.Modified;

            this._context.SaveChanges();
        }

        public void Delete(DiagnosisDrugs p)
        {
            this._context.DiagnosisDrugs.Remove(p);
            this._context.SaveChanges();
        }
    }
}
