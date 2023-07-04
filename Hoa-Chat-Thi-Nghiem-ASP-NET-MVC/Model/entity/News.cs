using System;

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

        public News(int id, string title, string content, DateTime date_posted)
        {
            this.id = id;
            this.title = title;
            this.content = content;
            this.date_posted = date_posted;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public string Path_image { get => path_image; set => path_image = value; }
        public DateTime Date_posted { get => date_posted; set => date_posted = value; }
        public int Quantity_comment { get => quantity_comment; set => quantity_comment = value; }

        public override string ToString()
        {
            return "id=" + Id + ";title=" + Title + ";content=" 
                + Content + " ;date=" + Date_posted;

        }
    }
}
