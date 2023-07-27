using System;
using System.Threading.Tasks;

namespace R5T.S0095
{
    class Program
    {
        static async Task Main()
        {
            // Create an empty repository (well, default that has .gitignore).
            await RepositoryGenerationScripts.Instance.Create_Repository();
        }
    }
}