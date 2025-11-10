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
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformProperty<double>? Revision
    {
        get => GetProperty<TerraformProperty<double>>("revision");
        set => WithProperty("revision", value);
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
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The use_aws_owned_key attribute.
    /// </summary>
    public TerraformProperty<bool>? UseAwsOwnedKey
    {
        get => GetProperty<TerraformProperty<bool>>("use_aws_owned_key");
        set => WithProperty("use_aws_owned_key", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("hosts");
        set => WithProperty("hosts", value);
    }

    /// <summary>
    /// The role_base attribute.
    /// </summary>
    public TerraformProperty<string>? RoleBase
    {
        get => GetProperty<TerraformProperty<string>>("role_base");
        set => WithProperty("role_base", value);
    }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    public TerraformProperty<string>? RoleName
    {
        get => GetProperty<TerraformProperty<string>>("role_name");
        set => WithProperty("role_name", value);
    }

    /// <summary>
    /// The role_search_matching attribute.
    /// </summary>
    public TerraformProperty<string>? RoleSearchMatching
    {
        get => GetProperty<TerraformProperty<string>>("role_search_matching");
        set => WithProperty("role_search_matching", value);
    }

    /// <summary>
    /// The role_search_subtree attribute.
    /// </summary>
    public TerraformProperty<bool>? RoleSearchSubtree
    {
        get => GetProperty<TerraformProperty<bool>>("role_search_subtree");
        set => WithProperty("role_search_subtree", value);
    }

    /// <summary>
    /// The service_account_password attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountPassword
    {
        get => GetProperty<TerraformProperty<string>>("service_account_password");
        set => WithProperty("service_account_password", value);
    }

    /// <summary>
    /// The service_account_username attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountUsername
    {
        get => GetProperty<TerraformProperty<string>>("service_account_username");
        set => WithProperty("service_account_username", value);
    }

    /// <summary>
    /// The user_base attribute.
    /// </summary>
    public TerraformProperty<string>? UserBase
    {
        get => GetProperty<TerraformProperty<string>>("user_base");
        set => WithProperty("user_base", value);
    }

    /// <summary>
    /// The user_role_name attribute.
    /// </summary>
    public TerraformProperty<string>? UserRoleName
    {
        get => GetProperty<TerraformProperty<string>>("user_role_name");
        set => WithProperty("user_role_name", value);
    }

    /// <summary>
    /// The user_search_matching attribute.
    /// </summary>
    public TerraformProperty<string>? UserSearchMatching
    {
        get => GetProperty<TerraformProperty<string>>("user_search_matching");
        set => WithProperty("user_search_matching", value);
    }

    /// <summary>
    /// The user_search_subtree attribute.
    /// </summary>
    public TerraformProperty<bool>? UserSearchSubtree
    {
        get => GetProperty<TerraformProperty<bool>>("user_search_subtree");
        set => WithProperty("user_search_subtree", value);
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
        get => GetProperty<TerraformProperty<string>>("audit");
        set => WithProperty("audit", value);
    }

    /// <summary>
    /// The general attribute.
    /// </summary>
    public TerraformProperty<bool>? General
    {
        get => GetProperty<TerraformProperty<bool>>("general");
        set => WithProperty("general", value);
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
        get => GetProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
    }

    /// <summary>
    /// The time_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    public required TerraformProperty<string> TimeOfDay
    {
        get => GetProperty<TerraformProperty<string>>("time_of_day");
        set => WithProperty("time_of_day", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    public required TerraformProperty<string> TimeZone
    {
        get => GetProperty<TerraformProperty<string>>("time_zone");
        set => WithProperty("time_zone", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetProperty<TerraformProperty<bool>>("console_access");
        set => WithProperty("console_access", value);
    }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Groups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("groups");
        set => WithProperty("groups", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformProperty<string> Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The replication_user attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplicationUser
    {
        get => GetProperty<TerraformProperty<bool>>("replication_user");
        set => WithProperty("replication_user", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("instances");
        this.DeclareOutput("pending_data_replication_mode");
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("apply_immediately");
        set => this.WithProperty("apply_immediately", value);
    }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("authentication_strategy");
        set => this.WithProperty("authentication_strategy", value);
    }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoMinorVersionUpgrade
    {
        get => GetProperty<TerraformProperty<bool>>("auto_minor_version_upgrade");
        set => this.WithProperty("auto_minor_version_upgrade", value);
    }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerName is required")]
    public required TerraformProperty<string> BrokerName
    {
        get => GetProperty<TerraformProperty<string>>("broker_name");
        set => this.WithProperty("broker_name", value);
    }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DataReplicationMode
    {
        get => GetProperty<TerraformProperty<string>>("data_replication_mode");
        set => this.WithProperty("data_replication_mode", value);
    }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DataReplicationPrimaryBrokerArn
    {
        get => GetProperty<TerraformProperty<string>>("data_replication_primary_broker_arn");
        set => this.WithProperty("data_replication_primary_broker_arn", value);
    }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    public TerraformProperty<string>? DeploymentMode
    {
        get => GetProperty<TerraformProperty<string>>("deployment_mode");
        set => this.WithProperty("deployment_mode", value);
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    public required TerraformProperty<string> EngineType
    {
        get => GetProperty<TerraformProperty<string>>("engine_type");
        set => this.WithProperty("engine_type", value);
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    public required TerraformProperty<string> EngineVersion
    {
        get => GetProperty<TerraformProperty<string>>("engine_version");
        set => this.WithProperty("engine_version", value);
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostInstanceType is required")]
    public required TerraformProperty<string> HostInstanceType
    {
        get => GetProperty<TerraformProperty<string>>("host_instance_type");
        set => this.WithProperty("host_instance_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroups
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageType
    {
        get => GetProperty<TerraformProperty<string>>("storage_type");
        set => this.WithProperty("storage_type", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public List<AwsMqBrokerConfigurationBlock>? Configuration
    {
        get => GetProperty<List<AwsMqBrokerConfigurationBlock>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// Block for encryption_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionOptions block(s) allowed")]
    public List<AwsMqBrokerEncryptionOptionsBlock>? EncryptionOptions
    {
        get => GetProperty<List<AwsMqBrokerEncryptionOptionsBlock>>("encryption_options");
        set => this.WithProperty("encryption_options", value);
    }

    /// <summary>
    /// Block for ldap_server_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LdapServerMetadata block(s) allowed")]
    public List<AwsMqBrokerLdapServerMetadataBlock>? LdapServerMetadata
    {
        get => GetProperty<List<AwsMqBrokerLdapServerMetadataBlock>>("ldap_server_metadata");
        set => this.WithProperty("ldap_server_metadata", value);
    }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public List<AwsMqBrokerLogsBlock>? Logs
    {
        get => GetProperty<List<AwsMqBrokerLogsBlock>>("logs");
        set => this.WithProperty("logs", value);
    }

    /// <summary>
    /// Block for maintenance_window_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowStartTime block(s) allowed")]
    public List<AwsMqBrokerMaintenanceWindowStartTimeBlock>? MaintenanceWindowStartTime
    {
        get => GetProperty<List<AwsMqBrokerMaintenanceWindowStartTimeBlock>>("maintenance_window_start_time");
        set => this.WithProperty("maintenance_window_start_time", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsMqBrokerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsMqBrokerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    public HashSet<AwsMqBrokerUserBlock>? User
    {
        get => GetProperty<HashSet<AwsMqBrokerUserBlock>>("user");
        set => this.WithProperty("user", value);
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
