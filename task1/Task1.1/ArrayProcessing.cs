using System;
using System.Collections.Generic;
using System.Text;

namespace Task1._1
{
    public class ArrayProcessing
    {
        public int[] Mas { get; private set; }
        public bool IsSorted { get; private set; }
        public ArrayProcessing(int n)
        {
            Mas = new int[n];
            GenerateMassive();
            IsSorted = false;
        }
        public void QuickSort()
        {
            QuickSort(0, Mas.Length - 1);
        }
        private void QuickSort(int leftIndex,int rightIndex)
        {
            var oldLeft = leftIndex;
            var oldRight = rightIndex;
            var piv = (Mas[leftIndex] + Mas[rightIndex]) / 2;
            while (leftIndex <= rightIndex)
            {
                while (Mas[leftIndex] < piv && leftIndex<=oldRight)
                    ++leftIndex;
                while (Mas[rightIndex] > piv && rightIndex>=oldLeft)
                    --rightIndex;
                if (leftIndex <= rightIndex)
                {
                    var temp = Mas[leftIndex];
                    Mas[leftIndex] = Mas[rightIndex];
                    Mas[rightIndex] = temp;
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
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = rand.Next(100);
            }
        }
        public int Max
        {
            get
            {
                if (IsSorted)
                    return Mas[Mas.Length - 1];
                else
                {
                    var max = Mas[0];
                    for (int i = 1; i < Mas.Length; i++)
                    {
                        if (Mas[i] > max)
                            max = Mas[i];
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
                    return Mas[0];
                else
                {
                    var min = Mas[0];
                    for (int i = 1; i < Mas.Length; i++)
                    {
                        if (Mas[i] > min)
                            min = Mas[i];
                    }
                    return min;
                }
            }
        }

        public void PrintMas()
        {
            for (int i = 0; i < Mas.Length; i++)
            {
                Console.Write($"{Mas[i]} ");
            }
        }
    }
}
