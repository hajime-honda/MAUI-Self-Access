using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MAUI学習
{
    public class MyViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// プロパティの変更通知イベント
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Greeting = "Hello, MVVM";

        public string Greeting
        {
            get => _Greeting;
            set
            {
                if (_Greeting != null)
                {
                    _Greeting = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand OnGreetingClicked
        {
            get;
            private set;
        }

        /// <summary>
        /// プロパティの変更通知イベントを発生させる
        /// </summary>
        /// <param name="name">プロパティ名</param>
        /// <remarks>
        /// CallerMemberNameAttribute: メソッドの呼び出し元のメソッド名またはプロパティ名を取得できます。
        /// https://learn.microsoft.com/ja-jp/dotnet/api/system.runtime.compilerservices.callermembernameattribute?view=net-7.0
        /// </remarks>
        public void OnPropertyChanged([CallerMemberName] string name = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public MyViewModel()
        {
            OnGreetingClicked = new Command(() =>
            {
                this.Greeting = "ようこそ、.NET MAUIの世界へ！";
            });
        }
    }
}
