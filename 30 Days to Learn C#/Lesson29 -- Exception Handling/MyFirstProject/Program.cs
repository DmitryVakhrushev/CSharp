using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MyFirstProject.MyFirstDataTypes;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)

        #region FirstExample
        //{
        //    try
        //    {
        //        Shape nullShape = null;
        //        Console.WriteLine(ShapeUtility.IsPolygon(nullShape));
        //    }

        //    // Specify the type of Exception you want to catch
        //    // Exception is the base type of all exceptions
        //    // We can have multiple catch 
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("We cannot evaluate the shape of this time");
        //    }
        //}
        #endregion
        {
            try
            {
                throw new System.Net.WebException(); // catch connectivity issues to the server
                throw new System.IO.FileNotFoundException();
                throw new OutOfMemoryException();
            }

            catch (System.Net.WebException webEx)
            {
                Console.WriteLine("We cannot retrieve the requested web resource");
            }

            catch (System.IO.FileNotFoundException fileEx)
            {
                Console.WriteLine("We cannot find the file needed to save the document");
            }

            catch (Exception ex)
            {
                Console.WriteLine("Something happened");
            }


            finally
            {
                Console.WriteLine("We are in the finally block");
            }
        }
    }
}
