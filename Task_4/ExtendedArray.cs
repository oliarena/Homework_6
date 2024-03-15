using System.Drawing;

namespace Task_4
{
    internal static class ExtendedArray
    {
        static public void ShellSort(this int[] array)
        {
            for (int interval = array.Length / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < array.Length; i++)
                {
                    var key = array[i];
                    var k = i;
                    while (k >= interval && array[k - interval] > key)
                    {
                        array[k] = array[k - interval];
                        k -= interval;
                    }
                    array[k] = key;
                }
            }
        }

    }
}
