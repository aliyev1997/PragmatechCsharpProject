﻿using System;

namespace ConsoleApp4
{

    class Rect
    {
        public int width;
        public int length;
       

        public void Square(int _width, int _length)
        {
            width = _width;
            length = _length;
            Console.WriteLine(width * length);
        }


    

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rect pelkas = new Rect();
            int _width = int.Parse(Console.ReadLine());
            int _length = int.Parse(Console.ReadLine());
            pelkas.Square(_width, _length);



        }
    }
}
