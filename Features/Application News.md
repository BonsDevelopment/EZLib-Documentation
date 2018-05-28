# Application News

**Description**

The news feature gives developers their own blog on their application (i.e. new release notes, what's upcoming in the next release).

## Using News Posts

__Requirements__
* A created [application](https://ezlib.io/apps/new)
* Premium or Premium Plus
* JSON.NET/Newtonsoft.Json

__Creating a news post__
1. Navigate to the EZLib website and onto the application page
2. Click on the application you want to create a news post for
3. Click the `Application News` found under the options of your application
4. Click `Create` on the page
5. Add a title and body for the news post

__Creating a news post form__
1. Create a new form to view news posts

C#:
```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace EZLib.Example
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
```

VB:
```vb
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Newtonsoft.Json

Namespace EZLib.Test
    Public Partial Class NewsForm
        Inherits Form

        Public Sub New(ByVal news As IEnumerable(Of String))
            InitializeComponent()
            If news.Count() >= 1 Then UpdateList(news)
        End Sub

        Private Sub UpdateList(ByVal news As IEnumerable(Of String))
            NewsListView.Items.Clear()
            NewsListView.BeginUpdate()

            For Each post In news
                Dim jsonList = JsonConvert.DeserializeObject(Of Post)(post)
                Dim item = New ListViewItem(jsonList.title) With {
                    .Tag = jsonList.body
                }
                NewsListView.Items.Add(item)
            Next

            NewsListView.EndUpdate()
        End Sub

        Private Sub NewsListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            If NewsListView.SelectedIndices.Count = 0 Then Return

            Using viewPost = New ViewNewsPost(NewsListView.SelectedItems(0).Text, NewsListView.SelectedItems(0).Tag.ToString())
                viewPost.ShowDialog()
            End Using
        End Sub

        Public Class Post
            Public Property title As String
            Public Property body As String
        End Class
    End Class
End Namespace
```

2. Create another form to view the news post

C#:
```csharp
using System.Windows.Forms;

namespace EZLib.Test
{
    public partial class ViewNewsPost : Form
    {
        public ViewNewsPost(string title, string body)
        {
            InitializeComponent();

            TitleLabel.Text = $"You're reading {title}.";
            BodyTextbox.Text = body;
        }
    }
}
```

VB:
```vb
Imports System.Windows.Forms

Namespace EZLib.Test
    Public Partial Class ViewNewsPost
        Inherits Form

        Public Sub New(ByVal title As String, ByVal body As String)
            InitializeComponent()
            TitleLabel.Text = $"You're reading {title}."
            BodyTextbox.Text = body
        End Sub
    End Class
End Namespace
```
