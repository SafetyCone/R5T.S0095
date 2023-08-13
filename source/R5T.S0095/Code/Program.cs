using System;
using System.Threading.Tasks;


namespace R5T.S0095
{
    class Program
    {
        static async Task Main()
        {
            //await RepositoryScripts.Instance.Delete_Repository();

            //await RepositoryGenerationScripts.Instance.Create_Repository();
            await RepositoryGenerationScripts.Instance.Create_RazorLibraryWithWebAssemblyClientAndServerSolution();
        }
    }
}