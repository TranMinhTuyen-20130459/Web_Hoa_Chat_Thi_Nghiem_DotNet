using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.entity
{
    public class News
    {
        private int id;
        private string title;
        private string content;
        private string path_image;
        private DateTime date_posted;
        private int quantity_comment;

        public News(string title, string content)
        {
            this.Title = title;
            this.Content = content;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Path_image { get => path_image; set => path_image = value; }
        public DateTime Date_posted { get => date_posted; set => date_posted = value; }
        public int Quantity_comment { get => quantity_comment; set => quantity_comment = value; }
    }
}
