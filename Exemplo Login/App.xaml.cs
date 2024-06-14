using Exemplo_Login.Data;
using Exemplo_Login.Model;
using Exemplo_Login.Pages;

namespace Exemplo_Login
{
    public partial class App : Application
    {
        static SQLiteData _bancoDados;

        public static SQLiteData BancoDados
        {
            get
            {
                if (_bancoDados == null)
                {
                    _bancoDados = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Dados.db3"));

                }

                return _bancoDados;
            }
        }

        public static Usuario Usuario { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
