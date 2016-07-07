
using Xamarin.Forms;

namespace EmbeddedNativeControl
{

    public partial class App
    {
        public App()
        {
            this.InitializeComponent();

            //Application.Current.MainPage = new MainPCode();
            Application.Current.MainPage = new FirstPage();
        }

    }
}
