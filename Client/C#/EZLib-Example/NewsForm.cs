using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EZLib.Test
{
    public partial class NewsForm : Form
    {
        public NewsForm(IEnumerable<string> news)
        {
            InitializeComponent();

            if (news.Count() >= 1)
                UpdateList(news);
        }

        private void UpdateList(IEnumerable<string> news)
        {
            NewsListView.Items.Clear();
            NewsListView.BeginUpdate();

            foreach (var post in news)
            {
                var jsonList = JsonConvert.DeserializeObject<Post>(post);

                var item = new ListViewItem(jsonList.title)
                {
                    Tag = jsonList.body
                };

                NewsListView.Items.Add(item);
            }

            NewsListView.EndUpdate();
        }


        private void NewsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NewsListView.SelectedIndices.Count == 0) return;

            using (var viewPost =
                new ViewNewsPost(NewsListView.SelectedItems[0].Text, NewsListView.SelectedItems[0].Tag.ToString()))
            {
                viewPost.ShowDialog();
            }
        }

        // This should not change. Leave it the way it looks.
        public class Post
        {
            public string title { get; set; }
            public string body { get; set; }
        }
    }
}