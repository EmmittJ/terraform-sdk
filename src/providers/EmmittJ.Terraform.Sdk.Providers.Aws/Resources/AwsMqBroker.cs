using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsMqBrokerConfigurationBlock() : TerraformBlock("configuration")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Revision { get; set; }

}

/// <summary>
/// Block type for encryption_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsMqBrokerEncryptionOptionsBlock() : TerraformBlock("encryption_options")
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The use_aws_owned_key attribute.
    /// </summary>
    [TerraformProperty("use_aws_owned_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseAwsOwnedKey { get; set; }

}

/// <summary>
/// Block type for ldap_server_metadata in .
/// Nesting mode: list
/// </summary>
public partial class AwsMqBrokerLdapServerMetadataBlock() : TerraformBlock("ldap_server_metadata")
{
    /// <summary>
    /// The hosts attribute.
    /// </summary>
    [TerraformProperty("hosts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Hosts { get; set; }

    /// <summary>
    /// The role_base attribute.
    /// </summary>
    [TerraformProperty("role_base")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleBase { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformProperty("role_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleName { get; set; }

    /// <summary>
    /// The role_search_matching attribute.
    /// </summary>
    [TerraformProperty("role_search_matching")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleSearchMatching { get; set; }

    /// <summary>
    /// The role_search_subtree attribute.
    /// </summary>
    [TerraformProperty("role_search_subtree")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RoleSearchSubtree { get; set; }

    /// <summary>
    /// The service_account_password attribute.
    /// </summary>
    [TerraformProperty("service_account_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccountPassword { get; set; }

    /// <summary>
    /// The service_account_username attribute.
    /// </summary>
    [TerraformProperty("service_account_username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceAccountUsername { get; set; }

    /// <summary>
    /// The user_base attribute.
    /// </summary>
    [TerraformProperty("user_base")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserBase { get; set; }

    /// <summary>
    /// The user_role_name attribute.
    /// </summary>
    [TerraformProperty("user_role_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserRoleName { get; set; }

    /// <summary>
    /// The user_search_matching attribute.
    /// </summary>
    [TerraformProperty("user_search_matching")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserSearchMatching { get; set; }

    /// <summary>
    /// The user_search_subtree attribute.
    /// </summary>
    [TerraformProperty("user_search_subtree")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UserSearchSubtree { get; set; }

}

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public partial class AwsMqBrokerLogsBlock() : TerraformBlock("logs")
{
    /// <summary>
    /// The audit attribute.
    /// </summary>
    [TerraformProperty("audit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Audit { get; set; }

    /// <summary>
    /// The general attribute.
    /// </summary>
    [TerraformProperty("general")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? General { get; set; }

}

/// <summary>
/// Block type for maintenance_window_start_time in .
/// Nesting mode: list
/// </summary>
public partial class AwsMqBrokerMaintenanceWindowStartTimeBlock() : TerraformBlock("maintenance_window_start_time")
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformProperty("day_of_week")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The time_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    [TerraformProperty("time_of_day")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeOfDay { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformProperty("time_zone")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMqBrokerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: set
/// </summary>
public partial class AwsMqBrokerUserBlock() : TerraformBlock("user")
{
    /// <summary>
    /// The console_access attribute.
    /// </summary>
    [TerraformProperty("console_access")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ConsoleAccess { get; set; }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [TerraformProperty("groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Groups { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The replication_user attribute.
    /// </summary>
    [TerraformProperty("replication_user")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReplicationUser { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Manages a aws_mq_broker resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsMqBroker : TerraformResource
{
    public AwsMqBroker(string name) : base("aws_mq_broker", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformProperty("apply_immediately")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    [TerraformProperty("authentication_strategy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AuthenticationStrategy { get; set; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerName is required")]
    [TerraformProperty("broker_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BrokerName { get; set; }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    [TerraformProperty("data_replication_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DataReplicationMode { get; set; }

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    [TerraformProperty("data_replication_primary_broker_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataReplicationPrimaryBrokerArn { get; set; }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [TerraformProperty("deployment_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeploymentMode { get; set; }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    [TerraformProperty("engine_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineType { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    [TerraformProperty("engine_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostInstanceType is required")]
    [TerraformProperty("host_instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HostInstanceType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageType { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformProperty("configuration")]
    public TerraformList<AwsMqBrokerConfigurationBlock> Configuration { get; set; } = new();

    /// <summary>
    /// Block for encryption_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionOptions block(s) allowed")]
    [TerraformProperty("encryption_options")]
    public TerraformList<AwsMqBrokerEncryptionOptionsBlock> EncryptionOptions { get; set; } = new();

    /// <summary>
    /// Block for ldap_server_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LdapServerMetadata block(s) allowed")]
    [TerraformProperty("ldap_server_metadata")]
    public TerraformList<AwsMqBrokerLdapServerMetadataBlock> LdapServerMetadata { get; set; } = new();

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformProperty("logs")]
    public TerraformList<AwsMqBrokerLogsBlock> Logs { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowStartTime block(s) allowed")]
    [TerraformProperty("maintenance_window_start_time")]
    public TerraformList<AwsMqBrokerMaintenanceWindowStartTimeBlock> MaintenanceWindowStartTime { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsMqBrokerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [TerraformProperty("user")]
    public required TerraformSet<AwsMqBrokerUserBlock> User { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Instances { get; }

    /// <summary>
    /// The pending_data_replication_mode attribute.
    /// </summary>
    [TerraformProperty("pending_data_replication_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PendingDataReplicationMode { get; }

}
