﻿using System.ComponentModel;
using Xamarin.Forms;
using DateQRScanner.ViewModels;

namespace DateQRScanner.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}