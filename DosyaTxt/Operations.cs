using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DosyaTxt
{
    class Operations
    {
        Random random = new Random();
        int stdNo = 1030520000;
        public void WriteToFile(string FilePath,List<Student> students)
         {
             StreamWriter streamWriter = new StreamWriter(FilePath);
             foreach(Student st in students)
             {
                 streamWriter.WriteLine(st.Write());
             }
             streamWriter.Close();
         }
        public void AssignGender(List<Student> students)
        {
            foreach (Student st in students)
            {
                if (random.Next(0, 2) == 1)
                {
                    st.gender = "kız";
                }

                else { st.gender = "erkek"; }

            }
        }
        public void WriteToLineGirl(string girlPath, List<Student> students)
        {
            List<Student> SortList = students.OrderBy(o => o.gender).ToList();
            StreamWriter writer = new StreamWriter(girlPath);
            foreach(Student st in SortList)
            {
                if (st.gender == "kız")
                {
                   
                    writer.WriteLine(st.Write());
                }
            }
            writer.Close();
        }
        public void WriteToLineBoy( string boyPath, List<Student> students)
        {
            List<Student> SortList = students.OrderBy(o => o.gender).ToList();
            StreamWriter writer = new StreamWriter(boyPath);
            foreach (Student st in SortList)
            {
                if (st.gender == "erkek")
                {
                    
                    writer.WriteLine(st.Write());
                }
            }
            writer.Close();
        }
        public void WriteToNo(List<Student> students, string no)
        {
            List<Student> SortList = students.OrderBy(o => o.no).ToList();
            StreamWriter writer = new StreamWriter(no);
            foreach (Student st in SortList )
            {
               

                    writer.WriteLine(st.Write());
                
            }
            writer.Close();

        }

        public void AssignNumber(List<Student> students)
        {
            int counter = 0;
            foreach (Student std in students)
            {
                std.no = stdNo + counter;
                counter++;
            }
        }
       
        public void AssignGrade(List<Student> students)
        {
            foreach(Student st in students)
            {
                if(((st.no>=1030520000) & (st.no < 1030522500)))
                {
                    st.Grade = 4;
                }
                else if (((st.no >= 1030522500) & (st.no < 1030525000)))
                {
                    st.Grade = 3;
                }
               else if (((st.no >= 1030525000) & (st.no < 1030527500)))
                {
                    st.Grade = 2;
                }
               else if (((st.no >= 1030527500) & (st.no < 1030530000)))
                {
                    st.Grade = 1;
                }
            }
        }
        public void AssignGano(List<Student> students)
        {
            foreach(Student st in students)
            {
                st.gano=4* random.NextDouble();
            }
        }
        public void AssignSurname(string surnamePath,List<Student> students)
        {
            string[] surnames = System.IO.File.ReadAllLines(surnamePath);
           foreach(Student st in students)
            {
                int rnd = random.Next(0, surnames.Length);
                st.surname = surnames[rnd];
            }        
         }
        public void AssignName(string nameKPath,string nameEPath, List<Student> students)
        {
            string[] namesK = System.IO.File.ReadAllLines(nameKPath);
            string[] namesE = System.IO.File.ReadAllLines(nameEPath);
            foreach (Student st in students)
            {
                if (st.gender == "kız")
                {
                    int rnd = random.Next(0, namesK.Length);
                    st.name = namesK[rnd];
                }
                if (st.gender == "erkek")
                {
                    int rnd = random.Next(0, namesE.Length);
                    st.name = namesE[rnd];
                }
           }
        }
        public void AssignDepertmantGre(List<Student> students,string ganoPath)
        {
            StreamWriter writer = new StreamWriter(ganoPath);
            List<Student> SortList = students.OrderByDescending(o => o.gano).ToList();
            int cnt = 1;
            foreach(Student st in SortList)
            {
                st.depertmantGre = cnt;
                cnt++;
                writer.WriteLine(st.Write());

            }
            writer.Close();
        }
        public void AssignClassGre1(List<Student> students,string class1)
        {
            List<Student> SortList= students.OrderByDescending(o => o.gano).ToList();
            StreamWriter writer = new StreamWriter(class1);
            int cnt = 1;
            foreach (Student st in SortList)
            {
                if (st.Grade == 1)
                {
                    SortList = new List<Student>(2500);
                    st.classGre = cnt;
                    cnt++;
                  writer.WriteLine(st.Write());

                }
               writer.Close();

               
            }
            
            
        }
        public void AssignClassGre2(List<Student> students, string class2)
        {
            List<Student> SortList = students.OrderByDescending(o => o.gano).ToList();
            StreamWriter writer = new StreamWriter(class2);
            int cnt = 1;
            foreach (Student st in SortList)
            {
                if (st.Grade == 2)
                {
                    SortList = new List<Student>(2500);
                    st.classGre = cnt;
                    cnt++;
                    writer.WriteLine(st.Write());

                }
                writer.Close();


            }


        }
        public void AssignClassGre3(List<Student> students, string class3)
        {
            List<Student> SortList = students.OrderByDescending(o => o.gano).ToList();
            StreamWriter writer = new StreamWriter(class3);
            int cnt = 1;
            foreach (Student st in SortList)
            {
                if (st.Grade == 3)
                {
                    SortList = new List<Student>(2500);
                    st.classGre = cnt;
                    cnt++;
                    writer.WriteLine(st.Write());

                }
                writer.Close();


            }


        }
        public void AssignClassGre4(string class4, List<Student> students)
        {
            StreamWriter writer = new StreamWriter(class4);
            List<Student> SortList = students.OrderByDescending(o => o.gano).ToList();
            
            int cnt = 1;
            foreach (Student st in SortList)
            {
                if (st.Grade == 4)
                {
                    SortList = new List<Student>(2500);
                    st.classGre = cnt;
                    cnt++;
                    writer.WriteLine(st.Write());

                }
                writer.Close();


            }


        }



    } 
        }
    

