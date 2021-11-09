﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public  class MyMapNode<K,V>
    {
        internal readonly int size;
        public readonly LinkedList<KeyValue<K, V>>[] items;
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];

        }
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach( KeyValue<K,V> item in linkedList)
            {
                if(item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        public void Add(K key,V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { key= key,value=value};
            linkedList.AddLast(item);

        }

        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K,V> foundItem = default(KeyValue<K, V>);
            foreach(KeyValue<K,V> item in linkedList)
            {
                if(item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;

                }
            }
            if(itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;

            }
            return linkedList;
        }
        public struct KeyValue<K, V>
        {
            public K key { get; set; }
            public V value { get; set; }
        }
       

      

      

    }
}
