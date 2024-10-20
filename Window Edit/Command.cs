using System;
using System.Windows.Input;

namespace WindowEdit {
	public sealed class Command : ICommand {
		private readonly Action action;

		public Command(Action action) {
			this.action = action;
		}

		public void Execute(object parameter) {
			action();
		}

		public bool CanExecute(object parameter) {
			return true;
		}

		public event EventHandler CanExecuteChanged;
	}

	sealed class ParamCommand : ICommand {
		private readonly Action<object> action;

		public ParamCommand(Action<object> action) {
			this.action = action;
		}

		public void Execute(object parameter) {
			action(parameter);
		}

		public bool CanExecute(object parameter) {
			return true;
		}

		public event EventHandler CanExecuteChanged;
	}

	sealed class Command1<T> : ICommand {
		private readonly Action<T> action;

		public Command1(Action<T> action) {
			this.action = action;
		}

		public void Execute(object parameter) {
			action((T)parameter);
		}

		public bool CanExecute(object parameter) {
			return true;
		}

		public event EventHandler CanExecuteChanged;
	}
}
