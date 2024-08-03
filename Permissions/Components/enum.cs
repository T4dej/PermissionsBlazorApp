namespace PermissionEnums
{

    public enum ConnectionOwner
    {
        ME,
        OTHER
    }

    public enum ConnectionStatus
    {
        PRIVATE,
        SHARED,
        SHARED_IN_CLIENT
    }

    public enum Role
    {
        OWNER,
        ADMIN,
        EDITOR,
        USER,
        VIEWER
    }

    public static class PermissionsText
    {
        public const string OWNER = "Owner Permissions";
        // Add other texts if needed
    }

}