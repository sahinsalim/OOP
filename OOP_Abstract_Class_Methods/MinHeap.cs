﻿namespace OOP_Abstract_Class_Methods
{
    public class MinHeap : Heap
    {
        public override int Extract()
        {
            var item = _list.Min;
            _list.Remove(item);
            return item;
        }
    }

}

