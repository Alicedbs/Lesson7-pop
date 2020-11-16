using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson7_pop.Enums;


namespace Lesson7_pop
{
    class Catalogue<T>
    {

        private List<T> Items;
        private Dictionary<Make, List<Model>> MakeModels = new Dictionary<Make, List<Model>>();

        public Catalogue()
        {
            Items = new List<T>();

            MakeModels.Add(Make.Ford, new List<Model> { Model.Focus, Model.Escape });
            MakeModels.Add(Make.Toyota, new List<Model> { Model.Camry, Model.Corolla });
            MakeModels.Add(Make.Peugeot, new List<Model> { Model._306, Model._406 });
            MakeModels.Add(Make.Renault, new List<Model> { Model.Megane });
        }

        public void Add(T item)
        {
            Items.Add(item);
        }

        public bool Remove(int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < Items.Count)
            {
                Items.RemoveAt(itemIndex);
                return true;
            }
            return false;
        }

        public void List()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
