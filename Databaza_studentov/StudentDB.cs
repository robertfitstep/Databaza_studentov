using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databaza_studentov
{
    class StudentDB
    {
        string[] mena = new string[] { "Robert", "Michal", "Peter", "Ivan", "Martin" };
        string[] priezvyska = new string[] { "Potočka", "Mrkva", "Suchý", "Mokrý", "Mrva" };
        public ArrayList dbStudentov = new ArrayList();
        //ArrayList dbStudentovSorted;

        public void NaplnDbStudentov(int pocetStudentov)
        {
            Random VyberNahodneCislo = new Random();

            for (int i = 1; i <= pocetStudentov; i++)
            {
                dbStudentov.Add(new Student(mena[VyberNahodneCislo.Next(mena.Length)], priezvyska[VyberNahodneCislo.Next(priezvyska.Length)], VyberNahodneCislo.Next(15, 81)));
            }
        }

        public void VypisDBStudentov(ArrayList dbStudentov)
        {
            foreach (Student Student1 in dbStudentov)
            {
                Console.WriteLine("Meno: {0}\nPriezvysko: {1}\nVek: {2}", Student1.meno, Student1.priezvysko, Student1.vek);
            }
        }

        public bool ZotriedPodlaVeku(ArrayList dbStudentov, out ArrayList dbStudentovSorted)
        {
            Student[] dbStudentov1 = dbStudentov.ToArray(typeof(Student)) as Student[];
            Student temp;
            dbStudentovSorted = new ArrayList();
            bool trebaTriedit = false;

            for (int p = 0; p <= dbStudentov1.Length - 2; p++)
            {
                for (int i = 0; i <= dbStudentov1.Length - 2; i++)
                {
                    if (dbStudentov1[i].vek > dbStudentov1[i + 1].vek)
                    {
                        temp = dbStudentov1[i + 1];
                        dbStudentov1[i + 1] = dbStudentov1[i];
                        dbStudentov1[i] = temp;
                        trebaTriedit = true;
                    }
                }
            }
                for (int i=0; i < dbStudentov1.Length; i++)
                {
                    dbStudentovSorted.Add(dbStudentov1[i]);
                }

            return trebaTriedit;

        }
    }
}

