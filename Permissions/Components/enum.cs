namespace PermissionEnums
{

    public enum ConnectionOwner
    {
        ME,
        OTHER,
        ASK_A_TEAMMATE
    }

    public enum ConnectionStatus
    {
        PRIVATE,
        SHARED,
        SHARED_IN_CLIENT,
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
        DELETE,
        CHANGE_REFRESH_FREQUENCY,
        USER_PREMISSIONS,
        EDIT_METADATA,
        SET_DATA_TIMEZONE,
        PURGE_HISTORY_DATA,
        SEE_ALL_METRICS,
        ACTIVITY_LOG,
        AMA_CONNECTION_PAGE,
        AMA_DATA_SOURCE_PAGE,
        P1_DATA_SOURCE_PAGE,
        CAN_NOT_SEE_CONNECTION,
        CAN_NOT_SEE_DATA_SOURCE,
    }
    public static class ActionsExtensions
    {
        public static string GetString(this Actions action)
        {
            return action switch
            {
                Actions.DETAILS => "- Details",
                Actions.REAUTHENTICATE => "- Reauthenticate",
                Actions.EDIT_PERMISSIONS => "- Edit Permissions",
                Actions.DELETE => "- Delete",

                Actions.CHANGE_REFRESH_FREQUENCY => "- Change Refresh Frequency",
                Actions.USER_PREMISSIONS => "- User Permissions",
                Actions.EDIT_METADATA => "- Edit Metadata",
                Actions.SET_DATA_TIMEZONE => "- Set Data Timezone",
                Actions.PURGE_HISTORY_DATA => "- Purge Historical Data",

                Actions.SEE_ALL_METRICS => "- See All Metrics",
                Actions.ACTIVITY_LOG => "- Activity Log",

                Actions.AMA_CONNECTION_PAGE => "AMA Connection Page",
                Actions.AMA_DATA_SOURCE_PAGE => "AMA Data Source Page",
                Actions.P1_DATA_SOURCE_PAGE => "P1 Data Source Page",

                Actions.CAN_NOT_SEE_CONNECTION => "- Can't See Connection",
                Actions.CAN_NOT_SEE_DATA_SOURCE => "- Can't See Data Source",
                _ => throw new ArgumentOutOfRangeException(nameof(action), action, null)
            };
        }
    }
    public static class PermissionsText
    {
        public static class CONNECTION_OWNER_PERMISSIONS //Connection owner
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string USER_PERMISSIONS = Actions.USER_PREMISSIONS.GetString();
            public static readonly string SET_DATA_TIMEZONE = Actions.SET_DATA_TIMEZONE.GetString();
            public static readonly string PURGE_HISTORICAL_DATA = Actions.PURGE_HISTORY_DATA.GetString();
            public static readonly string ACTIVITY_LOG = Actions.ACTIVITY_LOG.GetString();
            public static readonly string DELETE = Actions.DELETE.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string EDIT_METADATA = Actions.EDIT_METADATA.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            P1_DATA_SOURCE_PAGE,
            DETAILS,
            SEE_ALL_METRICS,
            REAUTHENTICATE,
            USER_PERMISSIONS,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            ACTIVITY_LOG,
            DELETE,

            AMA_DATA_SOURCE_PAGE,
            DETAILS,
            CHANGE_REFRESH_FREQUENCY,
            REAUTHENTICATE,
            USER_PERMISSIONS,
            EDIT_METADATA,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            DELETE,

            AMA_CONNECTION_PAGE,
            DETAILS,
            REAUTHENTICATE,
            EDIT_PERMISSIONS,
            DELETE,
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }

        public static class ADMIN_PERMISSIONS //Not owner of connection, admin role
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string USER_PERMISSIONS = Actions.USER_PREMISSIONS.GetString();
            public static readonly string SET_DATA_TIMEZONE = Actions.SET_DATA_TIMEZONE.GetString();
            public static readonly string PURGE_HISTORICAL_DATA = Actions.PURGE_HISTORY_DATA.GetString();
            public static readonly string ACTIVITY_LOG = Actions.ACTIVITY_LOG.GetString();
            public static readonly string DELETE = Actions.DELETE.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string EDIT_METADATA = Actions.EDIT_METADATA.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            P1_DATA_SOURCE_PAGE,
            DETAILS,
            SEE_ALL_METRICS,
            REAUTHENTICATE,
            USER_PERMISSIONS,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            ACTIVITY_LOG,
            DELETE,

            AMA_DATA_SOURCE_PAGE,
            DETAILS,
            CHANGE_REFRESH_FREQUENCY,
            REAUTHENTICATE,
            USER_PERMISSIONS,
            EDIT_METADATA,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            DELETE,

            AMA_CONNECTION_PAGE,
            DETAILS,
            REAUTHENTICATE,
            EDIT_PERMISSIONS,
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }

        public static class ADMIN_PERMISSIONS_PRIVATE_CONNECTION //Not owner of connection which is private, admin role
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string USER_PERMISSIONS = Actions.USER_PREMISSIONS.GetString();
            public static readonly string SET_DATA_TIMEZONE = Actions.SET_DATA_TIMEZONE.GetString();
            public static readonly string PURGE_HISTORICAL_DATA = Actions.PURGE_HISTORY_DATA.GetString();
            public static readonly string ACTIVITY_LOG = Actions.ACTIVITY_LOG.GetString();
            public static readonly string DELETE = Actions.DELETE.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string EDIT_METADATA = Actions.EDIT_METADATA.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();
            public static readonly string CAN_NOT_SEE_CONNECTION = Actions.CAN_NOT_SEE_CONNECTION.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            P1_DATA_SOURCE_PAGE,
            DETAILS,
            SEE_ALL_METRICS,
            USER_PERMISSIONS,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            ACTIVITY_LOG,
            DELETE,

            AMA_DATA_SOURCE_PAGE,
            DETAILS,
            CHANGE_REFRESH_FREQUENCY,
            USER_PERMISSIONS,
            EDIT_METADATA,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            DELETE,

            AMA_CONNECTION_PAGE,
            CAN_NOT_SEE_CONNECTION,
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }

        public static class NON_ADMIN_PERMISSIONS //Not connection owner, non admin role
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string CAN_NOT_SEE_DATA_SOURCE = Actions.CAN_NOT_SEE_DATA_SOURCE.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();


            public static List<string> GetAllPermissions(bool privateDataSource)
            {
                var permissions = new List<string>
            {
                P1_DATA_SOURCE_PAGE,
                DETAILS,
                SEE_ALL_METRICS,
                AMA_CONNECTION_PAGE,
                DETAILS
            };

                if (privateDataSource)
                {
                    permissions.AddRange(new List<string>
                {
                    AMA_DATA_SOURCE_PAGE,
                    CAN_NOT_SEE_DATA_SOURCE
                });
                }
                else
                {
                    permissions.AddRange(new List<string>
                {
                    AMA_DATA_SOURCE_PAGE,
                    DETAILS,
                    CHANGE_REFRESH_FREQUENCY
                });
                }

                return permissions;
            }

            public static string GetCombinedPermissions(bool privateDataSource)
            {
                return string.Join("\n", GetAllPermissions(privateDataSource));
            }
        }

        /*public static readonly List<string> AllPermissions = new List<string>
    {
        P1_DATA_SOURCE_PAGE,
        DETAILS,
        SEE_ALL_METRICS,

        AMA_DATA_SOURCE_PAGE,
        DETAILS,
        CHANGE_REFRESH_FREQUENCY,

        AMA_CONNECTION_PAGE,
        DETAILS
    };

        public static string CombinedPermissions => string.Join("\n", AllPermissions);
    }*/

        public static class NON_ADMIN_PERMISSIONS_PRIVATE_CONNECTION //Not owner of connection which is private, non admin role
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string CAN_NOT_SEE_DATA_SOURCE = Actions.CAN_NOT_SEE_DATA_SOURCE.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();
            public static readonly string CAN_NOT_SEE_CONNECTION = Actions.CAN_NOT_SEE_CONNECTION.GetString();

            public static List<string> GetAllPermissions(bool privateDataSource)
            {
                var permissions = new List<string>
            {
                P1_DATA_SOURCE_PAGE,
                DETAILS,
                SEE_ALL_METRICS,

                AMA_CONNECTION_PAGE,
                CAN_NOT_SEE_CONNECTION
            };

                if (privateDataSource)
                {
                    permissions.AddRange(new List<string>
                {
                    AMA_DATA_SOURCE_PAGE,
                    CAN_NOT_SEE_DATA_SOURCE
                });
                }
                else
                {
                    permissions.AddRange(new List<string>
                {
                    AMA_DATA_SOURCE_PAGE,
                    DETAILS,
                    CHANGE_REFRESH_FREQUENCY,
                });
                }

                return permissions;
            }

            public static string GetCombinedPermissions(bool privateDataSource)
            {
                return string.Join("\n", GetAllPermissions(privateDataSource));
            }
        }

            public static class CONNECTION_OWNER_NON_ADMIN_PERMISSIONS //Connection owner, non admin role
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string USER_PERMISSIONS = Actions.USER_PREMISSIONS.GetString();
            public static readonly string SET_DATA_TIMEZONE = Actions.SET_DATA_TIMEZONE.GetString();
            public static readonly string PURGE_HISTORICAL_DATA = Actions.PURGE_HISTORY_DATA.GetString();
            public static readonly string ACTIVITY_LOG = Actions.ACTIVITY_LOG.GetString();
            public static readonly string DELETE = Actions.DELETE.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string EDIT_METADATA = Actions.EDIT_METADATA.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            P1_DATA_SOURCE_PAGE,
            DETAILS,
            SEE_ALL_METRICS,
            REAUTHENTICATE,
            USER_PERMISSIONS,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            DELETE,

            AMA_DATA_SOURCE_PAGE,
            DETAILS,
            CHANGE_REFRESH_FREQUENCY,
            REAUTHENTICATE,
            USER_PERMISSIONS,
            EDIT_METADATA,
            SET_DATA_TIMEZONE,
            PURGE_HISTORICAL_DATA,
            DELETE,

            AMA_CONNECTION_PAGE,
            DETAILS,
            REAUTHENTICATE,
            EDIT_PERMISSIONS,
            DELETE,
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }

        public static class CONNECTION_PERMISSIONS_CLIENT_SWITCH //Connection owner, non admin role v agency, switch v client space 
        {
            public static readonly string P1_DATA_SOURCE_PAGE = Actions.P1_DATA_SOURCE_PAGE.GetString();
            public static readonly string DETAILS = Actions.DETAILS.GetString();
            public static readonly string SEE_ALL_METRICS = Actions.SEE_ALL_METRICS.GetString();
            public static readonly string REAUTHENTICATE = Actions.REAUTHENTICATE.GetString();
            public static readonly string USER_PERMISSIONS = Actions.USER_PREMISSIONS.GetString();
            public static readonly string SET_DATA_TIMEZONE = Actions.SET_DATA_TIMEZONE.GetString();
            public static readonly string PURGE_HISTORICAL_DATA = Actions.PURGE_HISTORY_DATA.GetString();
            public static readonly string ACTIVITY_LOG = Actions.ACTIVITY_LOG.GetString();
            public static readonly string DELETE = Actions.DELETE.GetString();

            public static readonly string AMA_DATA_SOURCE_PAGE = Actions.AMA_DATA_SOURCE_PAGE.GetString();
            public static readonly string CHANGE_REFRESH_FREQUENCY = Actions.CHANGE_REFRESH_FREQUENCY.GetString();
            public static readonly string EDIT_METADATA = Actions.EDIT_METADATA.GetString();

            public static readonly string AMA_CONNECTION_PAGE = Actions.AMA_CONNECTION_PAGE.GetString();
            public static readonly string EDIT_PERMISSIONS = Actions.EDIT_PERMISSIONS.GetString();

            public static readonly List<string> AllPermissions = new List<string>
        {
            P1_DATA_SOURCE_PAGE,

            AMA_DATA_SOURCE_PAGE,

            AMA_CONNECTION_PAGE,
            DETAILS,
        };

            public static string CombinedPermissions => string.Join("\n", AllPermissions);
        }
    }

}