using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tanımlama

            //hashtable koleksiyonunun Generic versiyonudur.


            #endregion

            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(123, "Ahmet Doğan");
            ogrenciler.Add(124, "Ayşe Yılmaz");
            ogrenciler.Add(125, "Deniz Koşar");
            ogrenciler.Add(126, "Alper Türkoğlu");

            #region Dictionary

            //Console.WriteLine(ogrenciler[126]);

            //try
            //{
            //    Console.WriteLine(ogrenciler[127]);
            //}
            //catch
            //{
            //    Console.WriteLine("bulunamadı");
            //}

            //Console.WriteLine(ogrenciler.Count);

            //ogrenciler.Remove(126);

            #endregion

            #region DictionaryListeleme

            Dictionary<int, string>.KeyCollection anahtarlistesi = ogrenciler.Keys;

            foreach (int item in anahtarlistesi)
            {
                Console.WriteLine(item);
            }

            ogrenciler.Keys.ToList().ForEach(s => Console.WriteLine(s));
            Console.WriteLine("-------------------");
            ogrenciler.Keys.ToList().Where(s => s > 125).ToList().ForEach(s => Console.WriteLine(s));

            #endregion
        }
    }
}
