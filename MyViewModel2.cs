using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace MAUI学習
{
    // Prismを使用したMyViewModelクラス
    public class MyViewModel2 : BindableBase
    {
        private string _Greeting = "Hello, World";

        public string Greeting
        {
            get => _Greeting;
            set
            {
                SetProperty(ref _Greeting, value, nameof(Greeting));
            }
        }

        public ICommand OnGreetingClicked
        {
            get;
            private set;
        }

        public MyViewModel2()
        {
            OnGreetingClicked = new DelegateCommand(() =>
            {
                this.Greeting = "ようこそ、.NET MAUIの世界へ";
            });
        }
    }
}
