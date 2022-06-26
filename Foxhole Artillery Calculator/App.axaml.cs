using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Foxhole_Artillery_Calculator.ViewModels;
using Foxhole_Artillery_Calculator.Views;

namespace Foxhole_Artillery_Calculator
{
	public partial class App : Application
	{
		public override void Initialize()
		{
			AvaloniaXamlLoader.Load(this);
		}

		public override void OnFrameworkInitializationCompleted()
		{
			if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
			{
				desktop.MainWindow = new MainWindow
				{
					DataContext = new MainWindowViewModel(),
				};
			}

			base.OnFrameworkInitializationCompleted();
		}
	}
}
