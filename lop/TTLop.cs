using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop
{
    internal class TTLop
    {
        private string idClass;
        private string nameClass;
        private string nameTeacher;
        private string nameSubject;
        private string numberLearners;
        private DateTime dateCreated;
        //private string iduser;
        //private string username;

        public TTLop() { }

        public TTLop(string idClass1, string nameClass1, string nameTeacher1, string nameSubject1, string numberLearners1, DateTime dateCreated1/*string iduser1, string username1*/)
        {
            idClass = idClass1;
            nameClass = nameClass1;
            nameTeacher = nameTeacher1;
            nameSubject = nameSubject1;
            numberLearners = numberLearners1;
            dateCreated = dateCreated1;
            //iduser = iduser1;
            //username = username1;
        }


        public string IdClass { get => idClass; set => idClass = value; }
        public string NameClass { get => nameClass; set => nameClass = value; }
        public string NameSubject { get => nameSubject; set => nameSubject = value; }
        public string NameTeacher { get => nameTeacher; set => nameTeacher = value; }
        public string NumberLearners { get => numberLearners; set => numberLearners = value; }
        public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
        /*public string Iduser { get => iduser; set => iduser = value; }
        public string Username { get => username; set => username = value; }*/
    }
}
