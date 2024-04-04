using System;

namespace task_3_4
{
    public sealed class Odnomerniy<T> 
    {
        private T[] mass;
        private int _capacity;
        private int _size;
        private Random rand = new Random();

        public int Capacity { get => _capacity ;}
        public int Size { get => _size; }

        public Odnomerniy(int capacity =7)
        {
            mass = new T[capacity];
            _capacity = capacity;
            _size = 0;
        }


        public void AddEl(T el)
        {
            if (_capacity <= _size)
            {
                _capacity = _capacity*2 + 1;
                var buff = new T[_capacity];
                Array.Copy(mass, buff, _size);
                mass = buff; 
            }
            mass[_size] = el;
            _size ++;
        }

        
        public void PrintMass()
        {
            Console.WriteLine(" ");
            for (int i = 0; i < _size; i++)
            {
                Console.Write(mass[i] + " ");
            }
        }

        public void DelEl(int i)
        {
            var buff =  new T[_capacity];
            for (int j = 0; j < _size; j ++)
            {
                if (j != i)
                {
                    buff[j] = mass[j];
                }
                _size--;
                mass = buff;
            }
        }

        public void Sort()
        {
            Array.Sort(mass, 0, _size);
        }

        public bool IsElInMass(T el)
        {
            if(mass.Contains(el))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int CountIf(Func<T,bool> act)
        {
            int counter = 0;
            for(int i = 0; i<_size; i++)
            {
                if(act(mass[i]))
                {
                    counter                                                                                                                                                              ++;
                }
            }
            return counter;
        }

        public bool IfOne(Func<T, bool> act)
        {
            for (int i = 0; i < _size; i++)
            {
                if (act(mass[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IfAll(Func<T, bool> act)
        {
            for (int i = 0; i < _size; i++)
            {
                if (!act(mass[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public void ApplyToAll(Func<T, T> act)
        {
            for(int i =0; i<_size; i++)
            {
                mass[i] = act(mass[i]);
            }
        }

        public void Invert()
        {
            var buff = new T[_size];
            int counter = 0;
            for (int i =0; i<_size; i++)
            {
                buff[counter] = mass[i];
                counter++;
            }
            mass = buff;
        }

        public T Min()
        {
            T[] values = new T[_size];
            for (int i = 0; i < _size; i++)
            {
                values[i] = mass[i];
            }
            Array.Sort(values);
            return values[0];
        }

        public T Max()
        {
            T[] values = new T[_size];
            for (int i = 0; i < _size; i++)
            {
                values[i] = mass[i];
            }
            Array.Sort(values);
            return values[_size-1];
        }   

    }
}

