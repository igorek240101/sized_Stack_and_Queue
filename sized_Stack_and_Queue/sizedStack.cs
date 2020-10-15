using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public class sizedStack<T>
    {
        private T[] array;
        private long up_of_stack = -1;
        private const long STACK_SIZE = 5;


        /// <summary>
        /// Метод кладет значение value на вершину стека
        /// </summary>
        /// <param name="value">Значение, которое будет пололжено на вершину стека</param>
        /// <returns>true, если метод выполенен успешно, иначе false</returns>
        public bool Push(T value)
        {
            if(up_of_stack + 1 == array.Length)
            {
                return false;
            }
            else
            {
                up_of_stack++;
            }
            array[up_of_stack] = value;
            return true;
        }

        /// <summary>
        /// Извлекает и возвращает значение из вершины стека 
        /// </summary>
        /// <returns>Значение из вершины стека или значение о умолчанию для типа T, если стек пуст</returns>
        public T Pop()
        {
            if(up_of_stack < 0)
            {
                return default;
            }
            return array[up_of_stack--];
        }

        /// <summary>
        /// Создает объект размерного стека с размером по умолчанию (5)
        /// </summary>
        public sizedStack()
        {
            array = new T[STACK_SIZE];
        }


        /// <summary>
        /// Создает объект размерного стека
        /// </summary>
        /// <param name="size">Размер стека</param>
        public sizedStack(long size)
        {
            array = new T[size];
        }

        /// <summary>
        /// Создает объект размерного стека на основе существующего массива
        /// </summary>
        /// <param name="value">Массив типа T</param>
        /// <param name="isClone">true, если необходимо использовать неполную копию исходного массива</param>
        /// <param name="start_up_of_stack">Указатель на текущую вершину стека</param>
        public sizedStack(T[] value, bool isClone, long start_up_of_stack = -1)
        {
            if (isClone)
                array = value.Clone() as T[];
            else
                array = value;
            up_of_stack = start_up_of_stack;
        }
    }
}
