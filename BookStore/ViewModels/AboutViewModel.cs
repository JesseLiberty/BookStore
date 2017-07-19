﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace BookStore {
   public class AboutViewModel : BaseViewModel {
      public AboutViewModel() {
         Title = "About";

         OpenWebCommand = new Command( () => Device.OpenUri( new Uri( "https://xamarin.com/platform" ) ) );
      }

      /// <summary>
      /// Command to open browser to xamarin.com
      /// </summary>
      public ICommand OpenWebCommand { get; }
   }
}
