using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsMqBroker.
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformValue<double> Revision
    {
        get => GetArgument<TerraformValue<double>>("revision") ?? CreateReference("revision");
        set => SetArgument("revision", value);
    }

}


/// <summary>
/// Block type for encryption_options in AwsMqBroker.
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerEncryptionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_options";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id") ?? CreateReference("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The use_aws_owned_key attribute.
    /// </summary>
    public TerraformValue<bool>? UseAwsOwnedKey
    {
        get => GetArgument<TerraformValue<bool>>("use_aws_owned_key");
        set => SetArgument("use_aws_owned_key", value);
    }

}


/// <summary>
/// Block type for ldap_server_metadata in AwsMqBroker.
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLdapServerMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ldap_server_metadata";

    /// <summary>
    /// The hosts attribute.
    /// </summary>
    public TerraformList<string>? Hosts
    {
        get => GetArgument<TerraformList<string>>("hosts");
        set => SetArgument("hosts", value);
    }

    /// <summary>
    /// The role_base attribute.
    /// </summary>
    public TerraformValue<string>? RoleBase
    {
        get => GetArgument<TerraformValue<string>>("role_base");
        set => SetArgument("role_base", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformValue<string>? RoleName
    {
        get => GetArgument<TerraformValue<string>>("role_name");
        set => SetArgument("role_name", value);
    }

    /// <summary>
    /// The role_search_matching attribute.
    /// </summary>
    public TerraformValue<string>? RoleSearchMatching
    {
        get => GetArgument<TerraformValue<string>>("role_search_matching");
        set => SetArgument("role_search_matching", value);
    }

    /// <summary>
    /// The role_search_subtree attribute.
    /// </summary>
    public TerraformValue<bool>? RoleSearchSubtree
    {
        get => GetArgument<TerraformValue<bool>>("role_search_subtree");
        set => SetArgument("role_search_subtree", value);
    }

    /// <summary>
    /// The service_account_password attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccountPassword
    {
        get => GetArgument<TerraformValue<string>>("service_account_password");
        set => SetArgument("service_account_password", value);
    }

    /// <summary>
    /// The service_account_username attribute.
    /// </summary>
    public TerraformValue<string>? ServiceAccountUsername
    {
        get => GetArgument<TerraformValue<string>>("service_account_username");
        set => SetArgument("service_account_username", value);
    }

    /// <summary>
    /// The user_base attribute.
    /// </summary>
    public TerraformValue<string>? UserBase
    {
        get => GetArgument<TerraformValue<string>>("user_base");
        set => SetArgument("user_base", value);
    }

    /// <summary>
    /// The user_role_name attribute.
    /// </summary>
    public TerraformValue<string>? UserRoleName
    {
        get => GetArgument<TerraformValue<string>>("user_role_name");
        set => SetArgument("user_role_name", value);
    }

    /// <summary>
    /// The user_search_matching attribute.
    /// </summary>
    public TerraformValue<string>? UserSearchMatching
    {
        get => GetArgument<TerraformValue<string>>("user_search_matching");
        set => SetArgument("user_search_matching", value);
    }

    /// <summary>
    /// The user_search_subtree attribute.
    /// </summary>
    public TerraformValue<bool>? UserSearchSubtree
    {
        get => GetArgument<TerraformValue<bool>>("user_search_subtree");
        set => SetArgument("user_search_subtree", value);
    }

}


/// <summary>
/// Block type for logs in AwsMqBroker.
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";

    /// <summary>
    /// The audit attribute.
    /// </summary>
    public TerraformValue<string>? Audit
    {
        get => GetArgument<TerraformValue<string>>("audit");
        set => SetArgument("audit", value);
    }

    /// <summary>
    /// The general attribute.
    /// </summary>
    public TerraformValue<bool>? General
    {
        get => GetArgument<TerraformValue<bool>>("general");
        set => SetArgument("general", value);
    }

}


/// <summary>
/// Block type for maintenance_window_start_time in AwsMqBroker.
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerMaintenanceWindowStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window_start_time";

    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// The time_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    public required TerraformValue<string> TimeOfDay
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_of_day");
        set => SetArgument("time_of_day", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformValue<string> TimeZone
    {
        get => GetRequiredArgument<TerraformValue<string>>("time_zone");
        set => SetArgument("time_zone", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsMqBroker.
/// Nesting mode: single
/// </summary>
public class AwsMqBrokerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user in AwsMqBroker.
/// Nesting mode: set
/// </summary>
public class AwsMqBrokerUserBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user";

    /// <summary>
    /// The console_access attribute.
    /// </summary>
    public TerraformValue<bool>? ConsoleAccess
    {
        get => GetArgument<TerraformValue<bool>>("console_access");
        set => SetArgument("console_access", value);
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    public TerraformSet<string>? Groups
    {
        get => GetArgument<TerraformSet<string>>("groups");
        set => SetArgument("groups", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => GetRequiredArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The replication_user attribute.
    /// </summary>
    public TerraformValue<bool>? ReplicationUser
    {
        get => GetArgument<TerraformValue<bool>>("replication_user");
        set => SetArgument("replication_user", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => GetRequiredArgument<TerraformValue<string>>("username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Represents a aws_mq_broker Terraform resource.
/// Manages a aws_mq_broker resource.
/// </summary>
public partial class AwsMqBroker(string name) : TerraformResource("aws_mq_broker", name)
{
    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyImmediately
    {
        get => GetArgument<TerraformValue<bool>>("apply_immediately");
        set => SetArgument("apply_immediately", value);
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformValue<string> AuthenticationStrategy
    {
        get => GetArgument<TerraformValue<string>>("authentication_strategy") ?? CreateReference("authentication_strategy");
        set => SetArgument("authentication_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformValue<bool>? AutoMinorVersionUpgrade
    {
        get => GetArgument<TerraformValue<bool>>("auto_minor_version_upgrade");
        set => SetArgument("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerName is required")]
    public required TerraformValue<string> BrokerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("broker_name");
        set => SetArgument("broker_name", value);
    }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    public TerraformValue<string> DataReplicationMode
    {
        get => GetArgument<TerraformValue<string>>("data_replication_mode") ?? CreateReference("data_replication_mode");
        set => SetArgument("data_replication_mode", value);
    }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    public TerraformValue<string>? DataReplicationPrimaryBrokerArn
    {
        get => GetArgument<TerraformValue<string>>("data_replication_primary_broker_arn");
        set => SetArgument("data_replication_primary_broker_arn", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformValue<string>? DeploymentMode
    {
        get => GetArgument<TerraformValue<string>>("deployment_mode");
        set => SetArgument("deployment_mode", value);
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    public required TerraformValue<string> EngineType
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine_type");
        set => SetArgument("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformValue<string> EngineVersion
    {
        get => GetRequiredArgument<TerraformValue<string>>("engine_version");
        set => SetArgument("engine_version", value);
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostInstanceType is required")]
    public required TerraformValue<string> HostInstanceType
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_instance_type");
        set => SetArgument("host_instance_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroups
    {
        get => GetArgument<TerraformSet<string>>("security_groups");
        set => SetArgument("security_groups", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => GetArgument<TerraformValue<string>>("storage_type") ?? CreateReference("storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids") ?? CreateReference("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Instances
        => CreateReference("instances");

    /// <summary>
    /// The pending_data_replication_mode attribute.
    /// </summary>
    public TerraformValue<string> PendingDataReplicationMode
        => CreateReference("pending_data_replication_mode");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsMqBrokerConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsMqBrokerConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// EncryptionOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionOptions block(s) allowed")]
    public TerraformList<AwsMqBrokerEncryptionOptionsBlock>? EncryptionOptions
    {
        get => GetArgument<TerraformList<AwsMqBrokerEncryptionOptionsBlock>>("encryption_options");
        set => SetArgument("encryption_options", value);
    }

    /// <summary>
    /// LdapServerMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LdapServerMetadata block(s) allowed")]
    public TerraformList<AwsMqBrokerLdapServerMetadataBlock>? LdapServerMetadata
    {
        get => GetArgument<TerraformList<AwsMqBrokerLdapServerMetadataBlock>>("ldap_server_metadata");
        set => SetArgument("ldap_server_metadata", value);
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public TerraformList<AwsMqBrokerLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AwsMqBrokerLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// MaintenanceWindowStartTime block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowStartTime block(s) allowed")]
    public TerraformList<AwsMqBrokerMaintenanceWindowStartTimeBlock>? MaintenanceWindowStartTime
    {
        get => GetArgument<TerraformList<AwsMqBrokerMaintenanceWindowStartTimeBlock>>("maintenance_window_start_time");
        set => SetArgument("maintenance_window_start_time", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsMqBrokerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsMqBrokerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// User block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    public required TerraformSet<AwsMqBrokerUserBlock> User
    {
        get => GetRequiredArgument<TerraformSet<AwsMqBrokerUserBlock>>("user");
        set => SetArgument("user", value);
    }

}
