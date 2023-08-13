using System;


namespace R5T.S0095
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static Z0036.ICommitMessages CommitMessages => Z0036.CommitMessages.Instance;
        public static F0133.ILibraryDescriptionOperator LibraryDescriptionOperator => F0133.LibraryDescriptionOperator.Instance;
        public static F0133.ILibraryNameOperator LibraryNameOperator => F0133.LibraryNameOperator.Instance;
        public static L0047.O001.ILocalGitRepositoryContextOperations LocalGitRepositoryContextOperations => L0047.O001.LocalGitRepositoryContextOperations.Instance;
        public static L0047.O001.ILocalRepositoryContextOperations LocalRepositoryContextOperations => L0047.O001.LocalRepositoryContextOperations.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static Z0059.IOrganizationNames OrganizationNames => Z0059.OrganizationNames.Instance;
        public static Z0043.IOwnerNames RepositoryOwnerNames => Z0043.OwnerNames.Instance;
        public static O0028.IRepositoryGenerationOperations RepositoryGenerationOperations => O0028.RepositoryGenerationOperations.Instance;
        public static O0028.IRepositoryOperations RepositoryOperations => O0028.RepositoryOperations.Instance;
        public static L0042.O001.IRepositoryContextOperations RepositoryContextOperations => L0042.O001.RepositoryContextOperations.Instance;
        public static O0016.IRepositoryContextOperator RepositoryContextOperator => O0016.RepositoryContextOperator.Instance;
        public static O0013.ISolutionContextOperationSets SolutionContextOperationSets => O0013.SolutionContextOperationSets.Instance;
        public static O0015.ISolutionSpecificationGenerationOperations SolutionSpecificationGenerationOperations => O0015.SolutionSpecificationGenerationOperations.Instance;
        public static IValues Values => S0095.Values.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}