using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisniProtokol
{
    public class MeasurementsDataModel : IListSource
    {
        BindingList<Measurement> collection = new BindingList<Measurement>();

        public bool ContainsListCollection
        {
            get
            {
                return true;
            }
        }

        public IList GetList()
        {
            return collection;
        }

        public void LoadData(List<Measurement> measurements)
        {
            collection.Clear();
            measurements.ForEach(x => collection.Add(x));
        }

        public void AddMeasurement(Measurement measurement)
        {
            collection.Add(measurement);
        }

        public Measurement GetByIndex(int index)
        {
            return collection[index];
        }

        public void RemoveOnIndex(int index)
        {
            collection.RemoveAt(index);
        }

        public void EditOnIndex(int index, Measurement measurement)
        {
            collection[index] = measurement;
        }
    }
}
