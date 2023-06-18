using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace MAUI学習
{
    public class MVVMFormViewModel : BindableBase
    {
        private string _Name = "";
        private string _Address = "";
        private string _Message = "";

        public string Name
        {
            get => _Name;
            set
            {
                SetProperty(ref _Name, value, nameof(Name));
            }
        }

        public string Address
        {
            get => _Address;
            set
            {
                SetProperty(ref _Address, value, nameof(Address));
            }
        }

        public string Message
        {
            get => _Message;
            set
            {
                SetProperty(ref _Message, value, nameof(Message));
            }
        }

        public ICommand OnSendClicked
        {
            get;
            private set;
        }

        public ICommand OnClearClicked
        {
            get;
            private set;
        }

        public MVVMFormViewModel()
        {
            OnSendClicked = new DelegateCommand(() =>
            {
                Message = $"{Name} in {Address}";
            });

            OnClearClicked = new DelegateCommand(() =>
            {
                Name = "";
                Address = "";
                Message = "";
            });
        }
    }
}
