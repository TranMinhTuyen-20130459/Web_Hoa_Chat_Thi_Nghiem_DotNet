using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.entity;
using Model.service;

namespace Program.service
{
    class TestNewsService
    {
        public static void TestAddNews()
        {
            News news = new News("Tuyen", "tuyentran");
            Admin admin = new Admin("tuyentran", "123", 1, 1, "TranMinhTuyen");

            Console.WriteLine(NewsService.AddNews(news,admin));
        }
    }
}
