//-----------------------------------------------------------------------
// <copyright file="FloatingButton.cs" company="Processa"> 
// Copyright (c) 2016 Todos los derechos reservados.
// </copyright>
// <author>dvarela</author>
// <date>7/6/2016 4:57:49 PM</date>
//-----------------------------------------------------------------------
namespace EmbeddedNativeControl.Controls
{
    #region using

    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    #endregion

    /// <summary>
    /// Representa la información del objeto FloatingButton.
    /// </summary>
    public class FloatingButton : AbsoluteLayout
    {
        private StackLayout innerLayout;

        public static readonly BindableProperty TapCommandProperty = BindableProperty.Create("TapCommand", typeof(ICommand), typeof(FloatingButton), null, BindingMode.TwoWay,propertyChanged: OnTapCommandChange);

        private static void OnTapCommandChange(BindableObject bindable, object oldvalue, object newvalue)
        {
            FloatingButton floatingButton = bindable as FloatingButton;
            if (floatingButton != null)
            {
                floatingButton.TapCommand = (ICommand)newvalue;
            }
        }

        public static IFloatingButton FloatingButtonImplementation
        {
            get
            {
                return DependencyService.Get<IFloatingButton>();
            }
        }

        public static bool HasFloatingButtonImplementation
        {
            get
            {
                return FloatingButtonImplementation != null;
            }
        }

        public TapGestureRecognizer tapGesture = new TapGestureRecognizer();

        public FloatingButton()
        {
            if (!HasFloatingButtonImplementation)
            {
                this.IsVisible = false;
                return;
            }

            VerticalOptions = LayoutOptions.FillAndExpand;
            HorizontalOptions = LayoutOptions.FillAndExpand;

            innerLayout = new StackLayout
            {
                Padding = 8,
                HorizontalOptions = LayoutOptions.Center,
            };

            View floatingButton = FloatingButtonImplementation.BuildFloatingButton();
            floatingButton.GestureRecognizers.Add(tapGesture);

            innerLayout.Children.Add(floatingButton);
            this.Children.Add(innerLayout);

            SetLayoutFlags(innerLayout, AbsoluteLayoutFlags.PositionProportional);
            SetLayoutBounds(innerLayout, new Rectangle(1f, 1f, AutoSize, AutoSize));
        }

        public ICommand TapCommand
        {
            get
            {
                return (ICommand)this.GetValue(TapCommandProperty);
            }

            set
            {
                tapGesture.Command = value;
                this.SetValue(TapCommandProperty, value);
            }
        }

    }
}
