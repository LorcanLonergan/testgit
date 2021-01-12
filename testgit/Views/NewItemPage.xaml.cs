using System;
using System.Collections.Generic;
using System.ComponentModel;
using testgit.Models;
using testgit.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace testgit.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}