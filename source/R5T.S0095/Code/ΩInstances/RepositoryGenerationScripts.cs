using System;


namespace R5T.S0095
{
    public class RepositoryGenerationScripts : IRepositoryGenerationScripts
    {
        #region Infrastructure

        public static IRepositoryGenerationScripts Instance { get; } = new RepositoryGenerationScripts();


        private RepositoryGenerationScripts()
        {
        }

        #endregion
    }
}
