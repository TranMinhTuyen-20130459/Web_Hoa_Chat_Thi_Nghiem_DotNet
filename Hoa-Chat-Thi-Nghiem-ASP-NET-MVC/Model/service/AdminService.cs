using Model.dao;
using Model.entity;
using System.Collections;

namespace Model.service
{
    public class AdminService
    {

        // đăng nhập cho Admin
        public static Admin checkLogin(string username, string password)
        {
            AdminDAO dao = new AdminDAO();

            // lấy ra danh sách admin theo username
            ArrayList admins = dao.ListAdmin(username);

            // không thể tồn tại nhiều username trùng tên trên hệ thống
            if (admins.Count != 1) { return null; } 
            else
            {
                Admin admin = (Admin) admins[0];
                if (admin.PassAD.Equals(password)) return admin;
            }

            return null;
        }

    }
}
