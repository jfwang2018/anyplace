﻿#pragma checksum "C:\Users\panag\Desktop\anyplace\windows\AnyPlace\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CB88BF0025107275CB26C5DE7FFABC04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace AnyPlace {
    
    
    public partial class Settings : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid downloading;
        
        internal System.Windows.Controls.TextBlock txt_download;
        
        internal Microsoft.Phone.Controls.ToggleSwitch showTiles;
        
        internal Microsoft.Phone.Controls.ToggleSwitch showZoom;
        
        internal Microsoft.Phone.Controls.ToggleSwitch showTrackme;
        
        internal Microsoft.Phone.Controls.ListPicker listpicker;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/AnyPlace;component/Settings.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.downloading = ((System.Windows.Controls.Grid)(this.FindName("downloading")));
            this.txt_download = ((System.Windows.Controls.TextBlock)(this.FindName("txt_download")));
            this.showTiles = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("showTiles")));
            this.showZoom = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("showZoom")));
            this.showTrackme = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("showTrackme")));
            this.listpicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("listpicker")));
        }
    }
}

