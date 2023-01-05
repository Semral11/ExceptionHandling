using System.Net.NetworkInformation;

namespace ExceptionHandling 
{
    class Program
    {
        static int ReturnInt(int n) => 10 / n;

        static int Foo(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException ex) when (index < 0)
            {
                throw new IndexOutOfRangeException("Burda Problem Var " + nameof(index));
            }
            catch (IndexOutOfRangeException ex) when (index > arr.Length - 1)
            {
                throw new IndexOutOfRangeException(nameof(index) + " Index 10 nan boyuk ola bilmez");
            }
        }
        static void Goo(string data)
        {
           if(data == null)
           {
               throw new NullReferenceException("Mene Gelen Data Nulldur " + nameof(data));
           }
        }

       
        

        static void Main()
        {
            //int[] arr = new int[] { 1, 2, 3 };
            //try
            //{
            //    Console.WriteLine(arr[-5]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            ////Console.WriteLine(arr[-5]);
            //Console.WriteLine("Finish");
            //try
            //{
            //    int netice = ReturnInt(0);
            //    Console.WriteLine(netice);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //int[] arr = new int[] { 21, 65, 16, 516, 51, 65, 165, 4, 86, 7464, 32, 156, 1, 68, 1321 };
            //try
            //{
            //    Console.WriteLine(Foo(arr,arr.Length));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    Goo(null);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    throw new ArgumentException("Semka + Maga");
            //}
            //catch (Exception ex) when (ex.Message == "Semka + Magadf")
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //string[] data = { "salam", "asdasd", "sad" };
            ////var data2 = Byte.Parse(data[2]);
            //try
            //{
            //    var data2 = Byte.Parse(data[2]);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            try
            {
                throw new Exception();
            }
            finally
            {
                Console.WriteLine("Works");
            }

        }
    }
}

