using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace MathsMenuDriven
{
    internal class Program
    {
        enum Operations { Exit,Add, Subtract, Multiplication , Division }

        static bool flag = true;

        public static object[] GetPara(MethodInfo methodInfo)
        {
            ParameterInfo[] allParameters = methodInfo.GetParameters();
            object[] arguments = new object[allParameters.Length];

            for (int i = 0; i < allParameters.Length; i++)
            {
                ParameterInfo para = allParameters[i];

                Console.WriteLine("Enter data of type " +
                    para.ParameterType.ToString() + " for "
                    + para.Name + " ");

                string data = Console.ReadLine();
                arguments[i] = Convert.ChangeType(data, para.ParameterType);
            }
            return arguments;
        }
        static void Main(string[] args)
        {
    
            int choice;
            string path = "D:\\.net\\c#\\Assignment 3 and 4\\MathsLib\\bin\\Debug\\net8.0\\MathsLib.dll";
            Assembly assembly = Assembly.LoadFrom(path);
            Type []alltypesinAssembly =assembly.GetTypes();
            foreach (Type type in alltypesinAssembly)
            {
                Object DynamicObject = assembly.CreateInstance(type.FullName);
                //MethodInfo [] allMethods = type.GetMethods();
                //foreach (MethodInfo method in allMethods)
                //{
                //   ParameterInfo [] allParameters = method.GetParameters();
                //   object []arguments = new object [allParameters.Length];

                //    for (int i = 0; i < allParameters.Length; i++)
                //    {
                //        ParameterInfo para = allParameters[i];

                //        Console.WriteLine("Enter data of type " +
                //            para.ParameterType.ToString() + " for "
                //            + para.Name + " ");

                //        string data = Console.ReadLine();
                //        arguments[i] = Convert.ChangeType(data, para.ParameterType);
                //    }

                //}
                MethodInfo methodInfo = null;

                while ((choice = menu())!= 0)
                {
                    if (choice == 1)
                    {

                        methodInfo = type.GetMethod("Add");
                        object Result = type.InvokeMember(methodInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, DynamicObject, GetPara(methodInfo));
                        Console.WriteLine(Result);
                    }
                    else if (choice == 2)
                    {
                        methodInfo = type.GetMethod("Subtract");
                        object Result = type.InvokeMember(methodInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, DynamicObject, GetPara(methodInfo));
                        Console.WriteLine(Result);
                    }
                    else if (choice == 3)
                    {
                        methodInfo = type.GetMethod("Mul");
                        object Result = type.InvokeMember(methodInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, DynamicObject, GetPara(methodInfo));
                        Console.WriteLine(Result);
       
                    }
                    else if (choice == 4)
                    {
                        methodInfo = type.GetMethod("Div");
                        object Result = type.InvokeMember(methodInfo.Name, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, DynamicObject, GetPara(methodInfo));
                        Console.WriteLine(Result);
               
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice!!");
            
                    }
                }
            }
            


        }

        public static int menu()
        {
            Array arr =Enum.GetValues(typeof(Operations));
            foreach (Operations i in arr)
            {
                Console.WriteLine($"{(int)i}. {i}");
            }
            Console.WriteLine("Enter your choice: ");
            return Convert.ToInt32(Console.ReadLine());
        }


    }
}
