//-----------------------------------------------------------------------
// <copyright file="MainPage.cs" company="Processa"> 
// Copyright (c) 2016 Todos los derechos reservados.
// </copyright>
// <author>dvarela</author>
// <date>7/6/2016 2:42:48 PM</date>
//-----------------------------------------------------------------------
namespace EmbeddedNativeControl
{
    #region using

    using EmbeddedNativeControl.Controls;
    using Xamarin.Forms;

    #endregion

    /// <summary>
    /// Representa la información del objeto MainPage.
    /// </summary>
    public class MainPCode : ContentPage
    {
        public MainPCode()
        {
            //var list = new ListView
            //{
            //    ItemsSource = new[] { "Hello", "World", "This", "Is", "Native", "Embedding" }
            //};
            //
            //// Main page layout
            var pageLayout = new StackLayout
            {
                Children =
                {
                    //list,
                    new Label(){Text = "Native control test"}
                }
            };

            var absolute = new AbsoluteLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            // Position the pageLayout to fill the entire screen.
            // Manage positioning of child elements on the page by editing the pageLayout.
            AbsoluteLayout.SetLayoutFlags(pageLayout, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(pageLayout, new Rectangle(0f, 0f, 1f, 1f));
            absolute.Children.Add(pageLayout);


            var stack = new StackLayout
            {
                Padding = 8,
                HorizontalOptions = LayoutOptions.Center,
            };

            stack.Children.Add(FloatingButton.FloatingButtonImplementation.BuildFloatingButton());
            absolute.Children.Add(stack);

            AbsoluteLayout.SetLayoutFlags(stack, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(stack, new Rectangle(1f, 1f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            Content = absolute;
        }
    }
}
