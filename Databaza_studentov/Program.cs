using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaza_studentov
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList dbStudentov;

            StudentDB novaDB = new StudentDB();
            novaDB.NaplnDbStudentov(5);
            Console.WriteLine("--------------------Pred Sortom ------------------");
            novaDB.VypisDBStudentov(novaDB.dbStudentov);
            Console.WriteLine("--------------------Po Sorte ---------------------");
            Console.WriteLine("Trebalo triediť = {0}",novaDB.ZotriedPodlaVeku(novaDB.dbStudentov, out dbStudentov));
            novaDB.VypisDBStudentov(dbStudentov);

            Console.ReadLine();
        }
    }
}
