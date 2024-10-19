using System.Windows;

namespace WindowEdit {
	/// <summary>
	/// Interaction logic for RealWindow.xaml
	/// </summary>
	public partial class RealWindow : Window {
		public RealWindow() {
			InitializeComponent();
			ClearSelectedProfile = new Command(DoClearSelectedProfile);
		}

		public Command ClearSelectedProfile { get; }

		private void DoClearSelectedProfile() {
			ProfilesListBox.UnselectAll();
		}
	}
}
