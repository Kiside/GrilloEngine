using GrilloEngineEditor.GameProject;

namespace GrilloEngineEditor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EngineHub());
            
        }
    }
}
