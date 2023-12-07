using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_pictures_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesCount = 52;
            int rowLenght = 3;
            int rowsCount;
            int freePictures;

            rowsCount = picturesCount / rowLenght;
            freePictures = picturesCount % rowLenght;

            Console.WriteLine("Количество заполненных рядов: " + rowsCount + "\nКоличество оставшихся картинок: " + freePictures);
            Console.ReadKey();
        }
    }
}
