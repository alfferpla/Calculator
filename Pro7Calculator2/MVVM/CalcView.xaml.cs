using Pro7Calculator2.MVVM.ViewModels;

namespace Pro7Calculator2.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new CalcViewModel();
	}
}