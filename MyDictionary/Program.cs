using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
            Ogrenci.Add(1,"sefa");
            Ogrenci.Add(2, "ali");
            int ogrenci_sayisi = Ogrenci.Count;
            Console.WriteLine(Ogrenci[1]);
            Console.WriteLine(ogrenci_sayisi);

            MyDic <int,String> Teacher = new MyDic<int, string>();
            
            Teacher.Add(5,"ali");

            Teacher.Add(5, "ali");
            int deneme = Teacher.Count;
            Console.WriteLine(deneme);
        }

        class MyDic<K, V>
        {
            K[] _key;
            K[] _tempKey;
            V[] _values;
            V[] _tempValues;
            public MyDic()
            {
                _key = new K[0];
                _values = new V[0];
                            
            }
            public void Add(K keyItem , V valueItem)
            {
                _key = new K[_key.Length + 1];
                _values = new V[_values.Length + 1];

                _tempKey = _key;
                for (int i = 0; i < _tempKey.Length; i++)
                {
                    _key[i] = _tempKey[i];

                }

                _key[_key.Length - 1] = keyItem;

                _tempValues = _values;
                for (int i = 0; i < _tempValues.Length; i++)
                {
                    _values[i] = _tempValues[i];

                }

                _values[_values.Length - 1] = valueItem;

            }

            

            public int Count
            {
                get { return _key.Length; }
                 
            }

        }
    }
}
