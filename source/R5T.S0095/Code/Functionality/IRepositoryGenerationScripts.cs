using System;
using System.Threading.Tasks;

using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0132;


namespace R5T.S0095
{
    [FunctionalityMarker]
    public partial interface IRepositoryGenerationScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Creates an empty repository.
        /// This is THE script to create an empty repository.
        /// </summary>
        /// <remarks>
        /// Ensures the repository has a .gitignore file, but does nothing else.
        /// </remarks>
        public async Task Create_Repository()
        {
            /// Inputs.
            var repositoryName =
                Instances.Values.Sample_RepositoryName
                ;
            var repositoryDescription =
                Instances.Values.Sample_RepositoryDescription
                ;
            var organization =
                Instances.OrganizationNames.SafetyCone
                ;
            var isPrivate = true;


            /// Run.
            //var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
            //    Instances.Values.ApplicationName,
            //    ApplicationContextOperation);

            //async Task ApplicationContextOperation(IApplicationContext applicationContext)
            //{
            //    await Instances.RepositoryOperations.Create_Repository(
            //        repositoryName,
            //        repositoryDescription,
            //        repositoryOwner,
            //        applicationContext.TextOutput);
            //}

            // Ignore the human output and log files.
        }
    }
}
