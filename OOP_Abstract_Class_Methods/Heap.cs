namespace OOP_Abstract_Class_Methods
{
    public abstract class Heap
    {
        // field
        protected SortedSet<int> _list;

        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            _list.Add(item);
        }

        // abstract method
        public abstract int Extract();

    }

}

