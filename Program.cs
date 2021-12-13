using System;

namespace Snake2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание точек
            Point p1 = new Point(3, 2, '*');
            p1.Draw();

            Point p2 = new Point(3, 3, '#');
            p2.Draw();

            Point p3 = new Point(3, 4, '%');
            p3.Draw();

            Point p4 = new Point(4, 4, '&');
            p4.Draw();

            //Список статичный урок
            System.Collections.Generic.List<int> numList = new System.Collections.Generic.List<int>();
            numList.Add(11);
            numList.Add(22);
            numList.Add(33);

            int x = numList [ 0 ];
            int y = numList [ 1 ];
            int z = numList [ 2 ];

            foreach (int i in numList)
            { 
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);   
            
            //Список точек - урок
            System.Collections.Generic.List<Point> pList = new System.Collections.Generic.List<Point>();  
            pList.Add(p1);
            pList.Add(p2);

            //Список точек - ДЗ
            System.Collections.Generic.List<Point> lList = new System.Collections.Generic.List<Point> ();
            lList.Add(p1);
            lList.Add(p2);                
            lList.Add(p3);
            lList.Add(p4);


            Console.ReadLine ();


        }

    }
}
