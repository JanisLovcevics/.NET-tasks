using Tasks;
using System.Reflection;

namespace Programm
{
    class Class1
    {
        static void Main (string[] args)
        {
            var modules = typeof(Solutions).GetNestedTypes(BindingFlags.NonPublic)
            .Where(t => t.IsClass)
            .ToArray();

            try
            {
                int moduleIndex = 0;
                
                if (args.Length >= 1)
                {
                    moduleIndex = int.Parse(args[0]) - 1;
                }
                else
                {
                    Console.WriteLine("Select module:");

                    for (int i = 0; i < modules.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. {modules[i].Name}");
                    }

                    Console.WriteLine();
                    moduleIndex = int.Parse(Console.ReadLine()) - 1;
                }

                var selectedModuleTasks = modules[moduleIndex].GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);

                int methodIndex = 0;

                if(args.Length >= 2)
                {
                    methodIndex = int.Parse(args[1]) - 1;
                }
                else
                {
                    Console.WriteLine("Select task:");

                    for (int i = 0; i < selectedModuleTasks.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. {selectedModuleTasks[i].Name}");
                    }

                    methodIndex = int.Parse(Console.ReadLine()) - 1;
                }

                var paramInfo = selectedModuleTasks[methodIndex].GetParameters();
                object[] methodArgs = null;

                if (paramInfo.Length > 0)
                {
                    methodArgs = new object[paramInfo.Length];

                    if (args.Length > 2)
                    {
                        for (int i = 2; i < args.Length; i++)
                        {
                            methodArgs[i - 2] = Convert.ChangeType(args[i], paramInfo[i - 2].ParameterType);
                        }
                    }

                    if (methodArgs.Count(x => x == null) > 0)
                    {
                        Console.WriteLine($"Enter parameters for method {selectedModuleTasks[methodIndex].Name}");

                        for (int i = Array.IndexOf(methodArgs, null); i < paramInfo.Length; i++)
                        {
                            var param = paramInfo[i];

                            Console.Write($"  Enter {param.Name} ({param.ParameterType.Name}): ");
                            string userInput = Console.ReadLine();

                            methodArgs[i] = Convert.ChangeType(userInput, param.ParameterType);
                        }
                    }
                }

                Console.Clear();

                selectedModuleTasks[methodIndex].Invoke(null, methodArgs);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}