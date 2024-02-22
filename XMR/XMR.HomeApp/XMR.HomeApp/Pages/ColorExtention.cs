﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin.Forms.Xaml;

namespace XMR.HomeApp.Pages
{
    public class ColorExtention : IMarkupExtension
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return Color.FromArgb(Red, Green, Blue);
        }
    }
}
