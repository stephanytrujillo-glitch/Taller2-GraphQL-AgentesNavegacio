using ClienteAgentesGraphQL.GUI;

namespace ClienteAgentesGraphQL
{
    internal static class Program
    {
        /// <summary>
        ///  Punto de entrada principal del cliente.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GUIPrincipal());
        }
    }
}
