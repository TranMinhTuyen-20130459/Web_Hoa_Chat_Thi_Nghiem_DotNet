using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.model
{
    public class Admin
    {
        private string username;
        private string passAD;
        private int id_role_admin;
        private int id_status_acc;
        private string fullname;

        public string Username { get => username; set => username = value; }
        public string PassAD { get => passAD; set => passAD = value; }
        public int Id_role_admin { get => id_role_admin; set => id_role_admin = value; }
        public int Id_status_acc { get => id_status_acc; set => id_status_acc = value; }
        public string Fullname { get => fullname; set => fullname = value; }

        public Admin(string username, string passAD, int id_role_admin, int id_status_acc, string fullname)
        {
            this.username = username;
            this.passAD = passAD;
            this.id_role_admin = id_role_admin;
            this.id_status_acc = id_status_acc;
            this.fullname = fullname;
        }

        public override string ToString()
        {
            return "username=" + username + " password=" + passAD + " role="
                    + id_role_admin + " status=" + id_status_acc + " fullname=" + fullname;
        }
    }
}
