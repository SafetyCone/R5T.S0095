using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0038;
using R5T.T0132;
using R5T.T0197.Extensions;
using R5T.T0201;


namespace R5T.S0095
{
    [FunctionalityMarker]
    public partial interface IRepositoryGenerationScripts : IFunctionalityMarker
    {
        public async Task Create_RazorLibraryWithWebAssemblyClientAndServerSolution()
        {
            /// Inputs.
            var libraryName =
                //Instances.Values.Sample_LibraryName.Value.ToUnadjustedLibraryName()
                "R5T.R0011".ToLibraryName()
                ;
            var libraryDescription =
                //Instances.Values.Sample_LibraryDescription
                "Conventional Tailwind CSS access strategy components.".ToLibraryDescription()
                ;
            var organizationName =
                Instances.OrganizationNames.SafetyCone
                ;
            var isPrivate = false;


            /// Run.
            var repositoryName = Instances.LibraryNameOperator.Get_DefaultRepositoryName(libraryName);
            var repositoryDescription = Instances.LibraryDescriptionOperator.Get_DefaultRepositoryDescription(libraryDescription);

            var solutionSpecification = Instances.SolutionSpecificationGenerationOperations.Get_WebLibraryWithConstructionSolutionSpecification(
                libraryName,
                libraryDescription,
                isPrivate);

            var creationOutput = new WebLibraryWithConstructionCreationOutput();

            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                await Instances.RepositoryContextOperator.In_New_RepositoryContext(
                    repositoryName,
                    organizationName,
                    repositoryDescription,
                    isPrivate,
                    applicationContext.TextOutput,
                    Instances.RepositoryContextOperations.In_LocalGitRepositoryContext(
                        organizationName,
                        Instances.LocalGitRepositoryContextOperations.In_CommitContext(
                            Instances.CommitMessages.InitialCommit,
                            async localGitRepositoryContext =>
                            {
                                var repositoryUrl = await Instances.LocalRepositoryContextOperations.Get_RepositoryUrl(localGitRepositoryContext);

                                var solutionContextOperations = Instances.SolutionContextOperationSets.Create_WebLibraryForBlazorWithConstructionServerAndClient(
                                    solutionSpecification,
                                    IsSet.Set(repositoryUrl),
                                    creationOutput);

                                await localGitRepositoryContext.Run(
                                    Instances.LocalRepositoryContextOperations.In_SolutionContext(
                                        solutionSpecification.SolutionName,
                                        solutionContextOperations
                                    )
                                );
                            }
                        )
                    )
                );
            }

            Instances.VisualStudioOperator.Open_SolutionFile(
                creationOutput.SolutionFilePath.Value);
        }

        /// <summary>
        /// Creates an empty repository.
        /// This is THE script to create an empty repository.
        /// </summary>
        /// <remarks>
        /// Add a .gitignore file, but nothing else.
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
            var organizationName =
                Instances.OrganizationNames.SafetyCone
                ;
            var isPrivate = true;


            /// Run.
            var (humanOutputTextFilePath, logFilePath) = await Instances.ApplicationContextOperator.In_ApplicationContext_Undated(
                Instances.Values.ApplicationName,
                ApplicationContextOperation);

            async Task ApplicationContextOperation(IApplicationContext applicationContext)
            {
                var repositoryCreationResult = await Instances.RepositoryGenerationOperations.Create_Repository(
                    repositoryName,
                    repositoryDescription,
                    organizationName,
                    isPrivate,
                    applicationContext.TextOutput);

                Instances.WindowsExplorerOperator.Open(
                    repositoryCreationResult.LocalGitRepositoryDirectoryPath.Value);
            }

            Instances.NotepadPlusPlusOperator.Open(
                humanOutputTextFilePath
                // Ignore the log file.
                );
        }
    }
}
