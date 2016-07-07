//-----------------------------------------------------------------------
// <copyright file="FirstPageViewModel.cs" company="Processa"> 
// Copyright (c) 2016 Todos los derechos reservados.
// </copyright>
// <author>dvarela</author>
// <date>7/6/2016 4:36:10 PM</date>
//-----------------------------------------------------------------------
namespace EmbeddedNativeControl
{
    #region using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;
    using Xamarin.Forms;

    #endregion

    /// <summary>
    /// Representa la información del objeto MainPViewModel.
    /// </summary>
    public class FirstPageViewModel
    {
         public ICommand OnFloatButtonTap
        {
             get
             {
                 return new Command(
                     () =>
                     {
                         App.Current.MainPage.DisplayAlert("Test", "Event in Forms", "Ok");
                     });
             }
        }
    }
}
