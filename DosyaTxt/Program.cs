using System;
using System.Collections.Generic;
using System.Linq;
namespace DosyaTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            Operations operations = new Operations();
            string FilePath = @"C:\file\students.txt";
            string surnamePath= @"C:\file\surnames.txt";
            string nameKPath = @"C:\file\namesK.txt";
            string nameEPath = @"C:\file\nameE.txt";
            string class1Path = @"C:\file\class1.txt";
            string class2Path = @"C:\file\class2.txt";
            string class3Path = @"C:\file\class3.txt";
            string class4Path = @"C:\file\class4.txt";
            string ganoPath = @"C:\file\Gano.txt";
            string noPath = @"C:\file\No.txt";
            string girlPath = @"C:\file\Girl.txt";
            string boyPath = @"C:\file\Boy.txt";
            

            for (int i =0; i < 10000; i++)
            {
                studentList.Add(new Student());  
            }
            
            operations.AssignNumber(studentList);
            operations.AssignGender(studentList);
            operations.AssignGrade(studentList);
            operations.AssignGano(studentList);
            operations.AssignSurname(surnamePath, studentList);
            operations.AssignName(nameKPath, nameEPath, studentList);
            operations.AssignDepertmantGre(studentList,ganoPath);
            operations.AssignClassGre1(studentList,class1Path);
            operations.AssignClassGre2(studentList, class2Path);
            operations.AssignClassGre3(studentList, class3Path);
            operations.AssignClassGre4( class4Path, studentList);
            operations.WriteToLineBoy(boyPath, studentList);
            operations.WriteToLineGirl(girlPath, studentList);
            operations.WriteToNo(studentList, noPath);
            operations.WriteToFile(FilePath, studentList);



            List<Student> sortedList = studentList.OrderByDescending(o => o.gano).ToList();
            foreach (Student st in sortedList)
            {
                st.Write();
            }
        }
    }
}
