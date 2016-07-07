//-----------------------------------------------------------------------
// <copyright file="FloatingButton.cs" company="Processa"> 
// Copyright (c) 2016 Todos los derechos reservados.
// </copyright>
// <author>dvarela</author>
// <date>7/6/2016 12:30:54 PM</date>
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
    public interface IFloatingButton
    {
        View BuildFloatingButton();
    }
}
