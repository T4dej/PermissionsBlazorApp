namespace PermissionEnums
{

    public enum ConnectionCreated
    {
        BY_ME,
        BY_OTHERS
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
        public const string OWNER = "Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions Owner Permissions ";
        // Add other texts if needed
    }

}