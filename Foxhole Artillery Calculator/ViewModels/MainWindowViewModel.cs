using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Foxhole_Artillery_Calculator.ViewModels
{
	public class MainWindowViewModel : ViewModelBase
	{
		double _distance;
		double _azimuth;
		public double Distance
		{
			get => _distance;
			set => this.RaiseAndSetIfChanged(ref _distance, value);
		}
		public double Azimuth
		{
			get => _azimuth;
			set => this.RaiseAndSetIfChanged(ref _azimuth, ((value % 360) + 360) % 360);
		}		
	}
}
