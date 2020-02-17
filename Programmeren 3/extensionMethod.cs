//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Programmeren_3
//{
//    class Segment
//    {
//        public List<Point> points = new List<Point>();

//        public Segment(List<int> xl, List<int> yl)
//        {
//            for(int i = 0; i < xl.Count; i++)
//            {
//                points.Add(new Point(xl[i], yl[i]));
//            }
//        }

//        public int GetN()
//        {
//            return points.Count;
//        }

//        public double length(this Segment s)
//        {
//            double lengte = 0;
//            for (int i=0; i< GetN(); i++)
//            {
//                lengte = Math.Sqrt(Math.Pow(s.points[i+1]-xl[i]) )
//            }
//        }

//    }
//    public class Point
//    {
//        private int x;
//        private int y;

//        public Point(int xcoord, int ycoord)
//        {
//            x = xcoord;
//            y = ycoord;
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> xc = new List<int> { 0, 5, 10 };
//            List<int> yc = new List<int> { 0, 5, 10 };
//            Segment s = new Segment(xc, yc);

//            Console.WriteLine($"segment lengte: {s.Length()}");
//        }
//    }

//}

//zelf afwerken!! 
