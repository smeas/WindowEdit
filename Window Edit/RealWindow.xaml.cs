using System.Windows;
using System.Windows.Input;

namespace WindowEdit {
	/// <summary>
	/// Interaction logic for RealWindow.xaml
	/// </summary>
	public partial class RealWindow : Window {
		public RealWindow() {
			InitializeComponent();
		}

		private void OnWindowProfilePressed(object sender, MouseButtonEventArgs e) {
			object pressedProfile = ((FrameworkElement)sender).DataContext;
			if (pressedProfile != null) {
				((Model)DataContext).SelectProfile.Execute(pressedProfile);
			}
		}
	}
}
