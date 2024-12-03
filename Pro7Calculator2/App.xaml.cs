using Pro7Calculator2.MVVM;

namespace Pro7Calculator2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalcView();
        }
    }
}
