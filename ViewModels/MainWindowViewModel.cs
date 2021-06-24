using System.Reactive;
using System.Windows.Input;
using Avalonia.Input;
using ReactiveUI;

namespace AvaloniaTextBoxKeyDown.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";

        public ICommand KeyPressCommand { get; set; }

        public MainWindowViewModel()
        {
            this.KeyPressCommand = ReactiveCommand.Create<KeyEventArgs, Unit>(this.OnKeyPress);
        }

        private Unit OnKeyPress(KeyEventArgs arg)
        {
            if (arg.Key == Key.Enter)
            {
                // do what you need to do
            }

            return Unit.Default;
        }
    }
}
