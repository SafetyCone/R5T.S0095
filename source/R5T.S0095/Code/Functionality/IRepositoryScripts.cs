using System;
using System.Threading.Tasks;

using R5T.L0038;
using R5T.T0132;
using R5T.T0184.Extensions;


namespace R5T.S0095
{
    [FunctionalityMarker]
    public partial interface IRepositoryScripts : IFunctionalityMarker
    {
        public async Task Delete_Repository()
        {
            /// Inputs.
            var repositoryName =
                //Instances.Values.Sample_RepositoryName
                "R5T.NG0027".ToRepositoryName()
                ;
            var organizationName =
                Instances.OrganizationNames.SafetyCone
                ;
            var isPrivate = false;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.RepositoryOperations.Delete_Repository(
                    repositoryName,
                    organizationName,
                    isPrivate,
                    applicationContext.TextOutput);
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath
                // Ignore the log file.
                );
        }
    }
}
