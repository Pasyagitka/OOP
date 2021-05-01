using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Shop.Product;

namespace Shop.UndoRedo
{  
    public class Memento
    {
        public ObservableCollection<Sweetness> sweetnessState;
        public Memento(ObservableCollection<Sweetness> sweetness)
        {
            sweetnessState = new ObservableCollection<Sweetness>(sweetness);
        }
    }

   public class AppHistory
   {
        ObservableCollection<Memento> states;
        int currentstateID;
        public AppHistory(ObservableCollection<Sweetness> sweetness)
        {
            states = new ObservableCollection<Memento>();
            AddState(sweetness);
            currentstateID = 0;
        }

        public void AddState(ObservableCollection<Sweetness> sweetnesses)
        {
            states.Add(new Memento(sweetnesses));
            currentstateID++;
        }

        public Memento Undo()
        {
            if (currentstateID > 0)
            {
                currentstateID--;
                return states[currentstateID];
            }
            return null;
        }

        public Memento Redo()
        {
            if (currentstateID < states.Count - 1)
            {
                currentstateID++;
                return states[currentstateID];
            }
            return null;
        }
    }
}