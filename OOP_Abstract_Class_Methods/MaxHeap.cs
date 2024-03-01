﻿namespace OOP_Abstract_Class_Methods
{
    public class MaxHeap : Heap
    {
        public override int Extract()
        {
            var item = _list.Max;
            _list.Remove(item);
            return item;
        }
    }

}

