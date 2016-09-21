using Windows.UI.Xaml.Controls;
using MVVM_Lab1_UWP.ViewModels;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409


namespace MVVM_Lab1_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Organization = new OrganizationViewModel("Office");
        }

        public OrganizationViewModel Organization { get; set; }
    }
}
