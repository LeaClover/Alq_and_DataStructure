using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.alg_and_data_str.HW3 {

    class Program {
        static void Main(string[] args) {

            LinkedList<Student> ll = new LinkedList<Student>();
            ll.AddLast(new Student{
                    SurName = "Иванов",
                    FirstName = "Иван",
                    Birthday = new DateTime(1993, 12, 20),
                    Group = 122});
            ll.AddLast(new Student{
                    SurName = "Рахманин",
                    FirstName = "Владислав",
                    Birthday = new DateTime(1992, 07, 11),
                    Group = 1});
            ll.AddLast(new Student{
                    SurName = "Петров",
                    FirstName = "Петр",
                    Birthday = new DateTime(1994, 02, 02),
                    Group = 11});
            ll.AddLast(new Student{
                    SurName = "Фролова",
                    FirstName = "Марина",
                    Birthday = new DateTime(1993, 04, 29),
                    Group = 22});
            ll.AddLast(new Student{
                    SurName = "Александров",
                    FirstName = "Александр",
                    Birthday = new DateTime(1990, 04, 28),
                    Group = 13});
            PrintStudents(ll);
            ll.Reverse(ll);
            PrintStudents(ll);
        }

        static void PrintStudents(LinkedList<Student> linkedList) {
            Console.WriteLine();
            var node = linkedList.Head;
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
