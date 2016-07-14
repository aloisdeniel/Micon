﻿using Micon.Portable.Bitmaps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Micon.Windows.Controls
{
    public class Preview : UserControl
    {
        public IBitmap Icon
        {
            get { return (IBitmap)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        
        public static readonly DependencyProperty IconProperty =  DependencyProperty.Register("Icon", typeof(IBitmap), typeof(Preview), new PropertyMetadata(null));
        
        public static readonly DependencyProperty IsAnimatedVisibleProperty = DependencyProperty.Register("IsAnimatedVisible", typeof(bool), typeof(Preview), new FrameworkPropertyMetadata(false, OnVisiblePropertyChanged));

        public bool IsAnimatedVisible
        {
            get { return (bool)GetValue(IsAnimatedVisibleProperty); }
            set { SetValue(IsAnimatedVisibleProperty, value); }
        }

        private static void OnVisiblePropertyChanged(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            var control = source as Preview;
            var visible = (bool)e.NewValue;

            if (visible)
            {
                control.Show();
            }
            else
            {
                control.Hide();
            }
        }

        public void Show()
        {
            var sb = (Storyboard)this.Resources["ShowStoryboard"];
            sb.Begin();
        }

        public void Hide()
        {
            var sb = (Storyboard)this.Resources["HideStoryboard"];
            sb.Begin();
        }
    }
}
