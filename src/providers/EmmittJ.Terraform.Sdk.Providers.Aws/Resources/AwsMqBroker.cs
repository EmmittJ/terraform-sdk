using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformProperty<double>? Revision
    {
        set => SetProperty("revision", value);
    }

}

/// <summary>
/// Block type for encryption_options in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerEncryptionOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The use_aws_owned_key attribute.
    /// </summary>
    public TerraformProperty<bool>? UseAwsOwnedKey
    {
        set => SetProperty("use_aws_owned_key", value);
    }

}

/// <summary>
/// Block type for ldap_server_metadata in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLdapServerMetadataBlock : TerraformBlock
{
    /// <summary>
    /// The hosts attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Hosts
    {
        set => SetProperty("hosts", value);
    }

    /// <summary>
    /// The role_base attribute.
    /// </summary>
    public TerraformProperty<string>? RoleBase
    {
        set => SetProperty("role_base", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        set => SetProperty("role_name", value);
    }

    /// <summary>
    /// The role_search_matching attribute.
    /// </summary>
    public TerraformProperty<string>? RoleSearchMatching
    {
        set => SetProperty("role_search_matching", value);
    }

    /// <summary>
    /// The role_search_subtree attribute.
    /// </summary>
    public TerraformProperty<bool>? RoleSearchSubtree
    {
        set => SetProperty("role_search_subtree", value);
    }

    /// <summary>
    /// The service_account_password attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountPassword
    {
        set => SetProperty("service_account_password", value);
    }

    /// <summary>
    /// The service_account_username attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountUsername
    {
        set => SetProperty("service_account_username", value);
    }

    /// <summary>
    /// The user_base attribute.
    /// </summary>
    public TerraformProperty<string>? UserBase
    {
        set => SetProperty("user_base", value);
    }

    /// <summary>
    /// The user_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserRoleName
    {
        set => SetProperty("user_role_name", value);
    }

    /// <summary>
    /// The user_search_matching attribute.
    /// </summary>
    public TerraformProperty<string>? UserSearchMatching
    {
        set => SetProperty("user_search_matching", value);
    }

    /// <summary>
    /// The user_search_subtree attribute.
    /// </summary>
    public TerraformProperty<bool>? UserSearchSubtree
    {
        set => SetProperty("user_search_subtree", value);
    }

}

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLogsBlock : TerraformBlock
{
    /// <summary>
    /// The audit attribute.
    /// </summary>
    public TerraformProperty<string>? Audit
    {
        set => SetProperty("audit", value);
    }

    /// <summary>
    /// The general attribute.
    /// </summary>
    public TerraformProperty<bool>? General
    {
        set => SetProperty("general", value);
    }

}

/// <summary>
/// Block type for maintenance_window_start_time in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerMaintenanceWindowStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformProperty<string> DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

    /// <summary>
    /// The time_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    public required TerraformProperty<string> TimeOfDay
    {
        set => SetProperty("time_of_day", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        set => SetProperty("time_zone", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMqBrokerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: set
/// </summary>
public class AwsMqBrokerUserBlock : TerraformBlock
{
    /// <summary>
    /// The console_access attribute.
    /// </summary>
    public TerraformProperty<bool>? ConsoleAccess
    {
        set => SetProperty("console_access", value);
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Groups
    {
        set => SetProperty("groups", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The replication_user attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplicationUser
    {
        set => SetProperty("replication_user", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Manages a aws_mq_broker resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMqBroker : TerraformResource
{
    public AwsMqBroker(string name) : base("aws_mq_broker", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("instances");
        SetOutput("pending_data_replication_mode");
        SetOutput("apply_immediately");
        SetOutput("authentication_strategy");
        SetOutput("auto_minor_version_upgrade");
        SetOutput("broker_name");
        SetOutput("data_replication_mode");
        SetOutput("data_replication_primary_broker_arn");
        SetOutput("deployment_mode");
        SetOutput("engine_type");
        SetOutput("engine_version");
        SetOutput("host_instance_type");
        SetOutput("id");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("security_groups");
        SetOutput("storage_type");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_immediately");
        set => SetProperty("apply_immediately", value);
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationStrategy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_strategy");
        set => SetProperty("authentication_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool> AutoMinorVersionUpgrade
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => SetProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerName is required")]
    public required TerraformProperty<string> BrokerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("broker_name");
        set => SetProperty("broker_name", value);
    }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    public TerraformProperty<string> DataReplicationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_replication_mode");
        set => SetProperty("data_replication_mode", value);
    }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    public TerraformProperty<string> DataReplicationPrimaryBrokerArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("data_replication_primary_broker_arn");
        set => SetProperty("data_replication_primary_broker_arn", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformProperty<string> DeploymentMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deployment_mode");
        set => SetProperty("deployment_mode", value);
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    public required TerraformProperty<string> EngineType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_type");
        set => SetProperty("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformProperty<string> EngineVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_version");
        set => SetProperty("engine_version", value);
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostInstanceType is required")]
    public required TerraformProperty<string> HostInstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host_instance_type");
        set => SetProperty("host_instance_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroups
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_groups");
        set => SetProperty("security_groups", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string> StorageType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_type");
        set => SetProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public List<AwsMqBrokerConfigurationBlock>? Configuration
    {
        set => SetProperty("configuration", value);
    }

    /// <summary>
    /// Block for encryption_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionOptions block(s) allowed")]
    public List<AwsMqBrokerEncryptionOptionsBlock>? EncryptionOptions
    {
        set => SetProperty("encryption_options", value);
    }

    /// <summary>
    /// Block for ldap_server_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LdapServerMetadata block(s) allowed")]
    public List<AwsMqBrokerLdapServerMetadataBlock>? LdapServerMetadata
    {
        set => SetProperty("ldap_server_metadata", value);
    }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public List<AwsMqBrokerLogsBlock>? Logs
    {
        set => SetProperty("logs", value);
    }

    /// <summary>
    /// Block for maintenance_window_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowStartTime block(s) allowed")]
    public List<AwsMqBrokerMaintenanceWindowStartTimeBlock>? MaintenanceWindowStartTime
    {
        set => SetProperty("maintenance_window_start_time", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMqBrokerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    public HashSet<AwsMqBrokerUserBlock>? User
    {
        set => SetProperty("user", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The instances attribute.
    /// </summary>
    public TerraformExpression Instances => this["instances"];

    /// <summary>
    /// The pending_data_replication_mode attribute.
    /// </summary>
    public TerraformExpression PendingDataReplicationMode => this["pending_data_replication_mode"];

}
