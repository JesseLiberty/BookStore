﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookStore {
   public partial class NewItemPage : ContentPage {
      public Item Item { get; set; }

      public NewItemPage() {
         InitializeComponent();

         Item = new Item {
            Text = "Item name",
            Description = "This is a nice description"
         };

         BindingContext = this;
      }

      async void Save_Clicked( object sender,EventArgs e ) {
         MessagingCenter.Send( this,"AddItem",Item );
         await Navigation.PopToRootAsync();
      }
   }
}
