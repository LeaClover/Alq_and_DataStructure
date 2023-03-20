using System.Runtime.InteropServices;
namespace GB.alg_and_data_str.HW4 {

    class Program {
        static void Main(string[] args) {

            RedBlackTree rbt = new RedBlackTree();
            Console.WriteLine("Введите количество узлов которые хотите добавить в дерево: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значения узлов через Enter: ");
            for (int i = 0; i < num; i++) {
                int value = Convert.ToInt32(Console.ReadLine());
                rbt.add(value);
            }
            Console.WriteLine("finish");
            rbt.DisplayTree(1);
        }

        
    }
}