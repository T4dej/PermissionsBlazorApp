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

    public enum IsSpaceSwitched
    {
        YES,
    }

    public static class PermissionsText
    {
        public const string OWNER = "Owner Permissions";
        // Add other texts if needed
    }

}