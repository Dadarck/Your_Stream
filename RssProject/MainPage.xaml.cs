﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RssProject.Model;
using RssProject.ViewModel;

// Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=391641

namespace RssProject
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainViewModel model;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
            model = new MainViewModel();
            this.DataContext = model;
        }

        /// <summary>
        /// Invoqué lorsque cette page est sur le point d'être affichée dans un frame.
        /// </summary>
        /// <param name="e">Données d’événement décrivant la manière dont l’utilisateur a accédé à cette page.
        /// Ce paramètre est généralement utilisé pour configurer la page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void afficheRss(object sender, RoutedEventArgs e)
        {
            string url = urlAjout.Text;

            if (!model.IsLoaded)
            {
                model.LoadRss(url);
            }
        }
    }
}
