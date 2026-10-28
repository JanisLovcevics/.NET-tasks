using System.Linq;
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

            Console.WriteLine("Select module:");

            for (int i = 0; i < modules.Length; i++)
            {
                Console.WriteLine($"{i+1}. {modules[i].Name}");
            }

            Console.WriteLine();

            try
            {
                int moduleIndex = int.Parse(Console.ReadLine()) - 1;

                var selectedModuleTasks = modules[moduleIndex].GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);

                Console.WriteLine("Select task:");

                for (int i = 0; i < selectedModuleTasks.Length; i++)
                {
                    Console.WriteLine($"{i+1}. {selectedModuleTasks[i].Name}");
                }

                int methodIndex = int.Parse(Console.ReadLine()) - 1;

                Console.Clear();

                selectedModuleTasks[methodIndex].Invoke(null, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}