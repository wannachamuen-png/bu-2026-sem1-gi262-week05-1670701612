using UnityEngine;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] < result[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = result[i];
                result[i] = result[minIndex];
                result[minIndex] = temp;
            }
            foreach (var n in result)
            {
                Debug.Log(n);
            }
            return result;
        }
        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            foreach (var n in result)
            {
                Debug.Log(n);
            }
            return result;
        }
        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] > key)
                {
                    result[j + 1] = result[j];
                    j--;
                }
                result[j + 1] = key;
            }
            foreach (var n in result)
            {
                Debug.Log(n);
            }
            return result;
        }
        #endregion
        #region Assignment
        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                int maxIndex = i;

                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[j] > result[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int temp = result[i];
                result[i] = result[maxIndex];
                result[maxIndex] = temp;
            }
            foreach (var n in result)
            {
                Debug.Log(n);
            }
            return result;
        }
        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] < result[j + 1])
                    {
                        int temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            foreach (var n in result)
            {
                Debug.Log(n);
            }
            return result;
        }
        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            for (int i = 1; i < result.Length; i++)
            {
                int key = result[i];
                int j = i - 1;

                while (j >= 0 && result[j] < key)
                {
                    result[j + 1] = result[j];
                    j--;
                }

                result[j + 1] = key;
            }
            foreach (var n in result)
            {
                Debug.Log(n);
            }
            return result;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            int[] result = (int[])numbers.Clone();

            Array.Sort(result);
            Array.Reverse(result);

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] < result[0])
                {
                    return result[i];
                }
            }
            return result[0];
        }
        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Debug.Log("The longest consecutive sequence is: 0");
                return 0;
            }

            int[] result = (int[])numbers.Clone();
            Array.Sort(result);

            int current = 1;
            int longest = 1;

            for (int i = 1; i < result.Length; i++)
            {
                if (result[i] == result[i - 1])
                {
                    continue;
                }
                if (result[i] == result[i - 1] + 1)
                {
                    current++;
                }
                else
                {
                    current = 1;
                }
                if (current > longest)
                {
                    longest = current;
                }
            }
            Debug.Log("The longest consecutive sequence is: " + longest);
            return longest;
        }
        #endregion
    }
}