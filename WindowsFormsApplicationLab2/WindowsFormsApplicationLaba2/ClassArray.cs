﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationLaba2
{
    class ClassArray<T> where T : Stone
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }

        public static int operator +(ClassArray<T> p, T stone)
        {
            if (p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, stone);
                    return i;
                }
            }
            p.places.Add(p.places.Count, stone);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T stone = p.places[index];
                p.places.Remove(index);
                return stone;
            }
            throw new ParkingIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }
    }
}
