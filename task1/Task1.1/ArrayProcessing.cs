using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public class ArrayProcessing
    {
        public int[] mas { get; private set; }
        public bool IsSorted { get; private set; }
        public ArrayProcessing(int n)
        {
            mas = new int[n];
            GenerateMassive();
            IsSorted = false;
        }
        public void QuickSort(int leftIndex,int rightIndex)
        {
            var oldLeft = leftIndex;
            var oldRight = rightIndex;
            var piv = (mas[leftIndex] + mas[rightIndex]) / 2;
            while (leftIndex <= rightIndex)
            {
                while (mas[leftIndex] < piv && leftIndex<=oldRight)
                    ++leftIndex;
                while (mas[rightIndex] > piv && rightIndex>=oldLeft)
                    --rightIndex;
                if (leftIndex <= rightIndex)
                {
                    var temp = mas[leftIndex];
                    mas[leftIndex] = mas[rightIndex];
                    mas[rightIndex] = temp;
                    ++leftIndex;--rightIndex;
                }
            }
            if (rightIndex>oldLeft)
                QuickSort(oldLeft, rightIndex);
            if (leftIndex<oldRight)
                QuickSort(leftIndex, oldRight);
            IsSorted = true;
        }
        
        public void GenerateMassive()
        {
            var rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(100);
            }
        }
        public int Max
        {
            get
            {
                if (IsSorted)
                    return mas[mas.Length - 1];
                else
                {
                    var max = mas[0];
                    for (int i = 1; i < mas.Length; i++)
                    {
                        if (mas[i] > max)
                            max = mas[i];
                    }
                    return max;
                }
            }
        }

        public int Min
        {
            get
            {
                if (IsSorted)
                    return mas[0];
                else
                {
                    var min = mas[0];
                    for (int i = 1; i < mas.Length; i++)
                    {
                        if (mas[i] > min)
                            min = mas[i];
                    }
                    return min;
                }
            }
        }

        public void PrintMas()
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write($"{mas[i]} ");
            }
        }
    }
}
