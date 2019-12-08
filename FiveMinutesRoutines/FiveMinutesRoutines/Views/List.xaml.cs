using System;
using System.Collections.Generic;
using FiveMinutesRoutines.Models;
using SQLite;
using Xamarin.Forms;

namespace FiveMinutesRoutines.Views
{
    public partial class List : ContentPage
    {
        public List()
        {
            InitializeComponent();
        }



        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Test>();
                var posts = conn.Table<Test>().ToList();
                postListView.ItemsSource = posts;
                postListView1.ItemsSource = posts;
            }
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedPost = postListView.SelectedItem as Test;
            var selectedPost1 = postListView.SelectedItem as Test;
            if (selectedPost != null)
            {
              //  Navigation.PushAsync(new PostDetailPage(selectedPost));
            }
        }

    }
}
