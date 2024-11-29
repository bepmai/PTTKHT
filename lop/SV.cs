using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lop
{
    internal class SV
    {
        private string iduser;
        private string username;
        public SV() { }

        public SV(string iduser1, string username1)
        {
            iduser = iduser1;
            username = username1;
        }
        public string Iduser { get => iduser; set => iduser = value; }
        public string Username { get => username; set => username = value; }
    }
}
