using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using AvaloniaEdit.CodeCompletion;
using AvaloniaEdit.Demo.Resources;
using AvaloniaEdit.Document;
using AvaloniaEdit.Editing;
using AvaloniaEdit.Rendering;
using AvaloniaEdit.TextMate;
using TextMateSharp.Model;
using TextMateSharp.Registry;
using TextMateSharp.Themes;

namespace AvaloniaEdit.Base
{
    using Pair = KeyValuePair<int, IControl>;

    public class MainWindow : Window
    {
        private MainView _mainView;

        public MainWindow()
        {
            InitializeComponent();

            _mainView = new MainView();
            this.Content = _mainView;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _mainView.Dispose();
        }
    }
}
