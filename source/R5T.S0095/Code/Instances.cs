using System;


namespace R5T.S0095
{
    public static class Instances
    {
        public static L0038.IApplicationContextOperator ApplicationContextOperator => L0038.ApplicationContextOperator.Instance;
        public static Z0059.IOrganizationNames OrganizationNames => Z0059.OrganizationNames.Instance;
        public static Z0043.IOwnerNames RepositoryOwnerNames => Z0043.OwnerNames.Instance;
        public static O0016.IRepositoryOperations RepositoryOperations => O0016.RepositoryOperations.Instance;
        public static IValues Values => S0095.Values.Instance;
    }
}