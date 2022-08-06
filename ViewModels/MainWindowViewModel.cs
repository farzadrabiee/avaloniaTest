using System;
using System.IO;
using System.Net;
using System.Windows.Input;
using Avalonia.Controls;
using ReactiveUI;

namespace Avalonia.NETCoreMVVMApp1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private int count;
        public int Count
        {
            get => count; 
            set => this.RaiseAndSetIfChanged(ref count, value);
        }
        public ICommand EventClick { get; private set; }
        public MainWindowViewModel()
        {
            var ofd = new OpenFileDialog();
            EventClick = ReactiveCommand.Create(() =>
            {
                Console.WriteLine("Click!");
            });
        }
    }
}