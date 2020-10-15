using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public class sizedQueue<T>
    {
        private T[] array;
        private long read = -1;
        private long write = 0;
        private const long QUEUE_SIZE = 7;


        /// <summary>
        /// Метод кладет занчение в конец очерди
        /// </summary>
        /// <param name="value">Значение, которое будет пололжено в конец очереди</param>
        /// <returns>true, если функция выполнена успешно, иначе false</returns>
        public bool Push(T value)
        {
            if (write == read) return false;
            array[write] = value;
            if (read == -1) read = write;
            if(++write == array.LongLength)
            {
                write = 0;
            }
            return true;
        }

        /// <summary>
        /// Извлекает и возвращает элемент из начала очерди
        /// </summary>
        /// <returns>Элемент из начала очереди или значение по умолчанию для данного типв данных, если очередь пуста</returns>
        public T Pop()
        {
            if (read == -1) return default;
            T res = array[read];
            if (++read == array.LongLength)
            {
                read = 0;
            }
            if (read == write) read = -1;
            return res;
        }

        /// <summary>
        /// Создает объект размерной очереди, размер задается по умолчанию (7)
        /// </summary>
        public sizedQueue()
        {
            array = new T[QUEUE_SIZE];
        }

        /// <summary>
        /// Создает объект размерной очереди
        /// </summary>
        /// <param name="size">размер, создаваемой очерди</param>
        public sizedQueue(long size)
        {
            array = new T[size];
        }

        /// <summary>
        /// Создает объект размерной очереди из массива того же типа
        /// </summary>
        /// <param name="value">Массив того же типа,что и очередь</param>
        /// <param name="start_write">Указатель на начало письма для очереди</param>
        /// <param name="start_read">Уазатель наначало чтения для очереди</param>
        /// <param name="isClone">true, если необходимо использовать неполную копию исходного массива</param>
        public sizedQueue(T[] value, bool isClone, long start_write = 0, long start_read = -1)
        {
            if (isClone)
                array = value.Clone() as T[];
            else
                array = value;
            write = start_write;
            read = start_read;
        }
    }
}
