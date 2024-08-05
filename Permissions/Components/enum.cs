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

    public enum Actions
    {
        DETAILS,
        REAUTHENTICATE,
        EDIT_PERMISSIONS,
        DELETE
    }
    public static class ActionsExtensions
    {
        public static string GetString(this Actions action)
        {
            return action switch
            {
                Actions.DETAILS => "Details",
                Actions.REAUTHENTICATE => "Reauthenticate",
                Actions.EDIT_PERMISSIONS => "Edit Permissions",
                Actions.DELETE => "Delete",
                _ => throw new ArgumentOutOfRangeException(nameof(action), action, null)
            };
        }
    }
    public static class PermissionsText
    {
        public static class OWNER_PERMISSIONS
        {
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();
            public static readonly string DELETE = Actions.DELETE.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            DETAILS,
            REAUTHENTICATE,
            EDIT_PERMISSIONS,
            DELETE
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }

        public static class NON_ADMIN_PERMISSIONS
        {
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            DETAILS,
            REAUTHENTICATE,
            EDIT_PERMISSIONS
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }
    }

}