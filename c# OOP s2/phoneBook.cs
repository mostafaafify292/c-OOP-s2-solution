using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c__OOP_s2
{
    internal struct phoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        { get { return size; } }


        public phoneBook(int _Size)
        {
            size = _Size;
            names = new string[size];
            numbers = new long[size];
        }
        public void AddPerson(int position, string name, long number)
        {
            if (names is not null && numbers is not null)
            {
                if (position >= 0 && position < size)
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }
        public long GetNumber(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (name == names[i])
                {
                    return numbers[i];

                }

            }
            return -1;
        }
        public void SetNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (name == names[i])
                {
                    numbers[i] = newNumber;

                }

            }

        }
        //indexer
        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];

                    }
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = value;
                        return;

                    }

                }

            }

        }
        public string this [int position]
        {
            get
            {
                return $"position : {position} \n Name : {names[position]}\n Numbers : {numbers[position]}";

            
            }
        }
    }
}
