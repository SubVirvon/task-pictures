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
            int picturesCount = 52, rowLenght = 3, rowCount, freePictures;

            rowCount = picturesCount / rowLenght;
            freePictures = Convert.ToInt32(Convert.ToSingle(picturesCount) % rowLenght);
            Console.WriteLine("Количество заполненных рядов: " + rowCount + "\nКоличество оставшихся картинок: " + freePictures);
            Console.ReadKey();
        }
    }
}
