using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerConfigurationBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> Revision { get; set; } = default!;

}

/// <summary>
/// Block type for encryption_options in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerEncryptionOptionsBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The use_aws_owned_key attribute.
    /// </summary>
    [TerraformPropertyName("use_aws_owned_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseAwsOwnedKey { get; set; }

}

/// <summary>
/// Block type for ldap_server_metadata in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLdapServerMetadataBlock
{
    /// <summary>
    /// The hosts attribute.
    /// </summary>
    [TerraformPropertyName("hosts")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Hosts { get; set; }

    /// <summary>
    /// The role_base attribute.
    /// </summary>
    [TerraformPropertyName("role_base")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleBase { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleName { get; set; }

    /// <summary>
    /// The role_search_matching attribute.
    /// </summary>
    [TerraformPropertyName("role_search_matching")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleSearchMatching { get; set; }

    /// <summary>
    /// The role_search_subtree attribute.
    /// </summary>
    [TerraformPropertyName("role_search_subtree")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RoleSearchSubtree { get; set; }

    /// <summary>
    /// The service_account_password attribute.
    /// </summary>
    [TerraformPropertyName("service_account_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccountPassword { get; set; }

    /// <summary>
    /// The service_account_username attribute.
    /// </summary>
    [TerraformPropertyName("service_account_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServiceAccountUsername { get; set; }

    /// <summary>
    /// The user_base attribute.
    /// </summary>
    [TerraformPropertyName("user_base")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserBase { get; set; }

    /// <summary>
    /// The user_role_name attribute.
    /// </summary>
    [TerraformPropertyName("user_role_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserRoleName { get; set; }

    /// <summary>
    /// The user_search_matching attribute.
    /// </summary>
    [TerraformPropertyName("user_search_matching")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserSearchMatching { get; set; }

    /// <summary>
    /// The user_search_subtree attribute.
    /// </summary>
    [TerraformPropertyName("user_search_subtree")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UserSearchSubtree { get; set; }

}

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLogsBlock
{
    /// <summary>
    /// The audit attribute.
    /// </summary>
    [TerraformPropertyName("audit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Audit { get; set; }

    /// <summary>
    /// The general attribute.
    /// </summary>
    [TerraformPropertyName("general")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? General { get; set; }

}

/// <summary>
/// Block type for maintenance_window_start_time in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerMaintenanceWindowStartTimeBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DayOfWeek { get; set; }

    /// <summary>
    /// The time_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    [TerraformPropertyName("time_of_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeOfDay { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformPropertyName("time_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMqBrokerTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: set
/// </summary>
public class AwsMqBrokerUserBlock
{
    /// <summary>
    /// The console_access attribute.
    /// </summary>
    [TerraformPropertyName("console_access")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ConsoleAccess { get; set; }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [TerraformPropertyName("groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Groups { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Password { get; set; }

    /// <summary>
    /// The replication_user attribute.
    /// </summary>
    [TerraformPropertyName("replication_user")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ReplicationUser { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

}

/// <summary>
/// Manages a aws_mq_broker resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsMqBroker : TerraformResource
{
    public AwsMqBroker(string name) : base("aws_mq_broker", name)
    {
    }

    /// <summary>
    /// The apply_immediately attribute.
    /// </summary>
    [TerraformPropertyName("apply_immediately")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ApplyImmediately { get; set; }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    [TerraformPropertyName("authentication_strategy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AuthenticationStrategy { get; set; } = default!;

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerName is required")]
    [TerraformPropertyName("broker_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BrokerName { get; set; }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    [TerraformPropertyName("data_replication_mode")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DataReplicationMode { get; set; } = default!;

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    [TerraformPropertyName("data_replication_primary_broker_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DataReplicationPrimaryBrokerArn { get; set; }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [TerraformPropertyName("deployment_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeploymentMode { get; set; }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    [TerraformPropertyName("engine_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EngineType { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    [TerraformPropertyName("engine_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EngineVersion { get; set; }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostInstanceType is required")]
    [TerraformPropertyName("host_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> HostInstanceType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroups { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> StorageType { get; set; } = default!;

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SubnetIds { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsMqBrokerConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// Block for encryption_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionOptions block(s) allowed")]
    [TerraformPropertyName("encryption_options")]
    public TerraformList<TerraformBlock<AwsMqBrokerEncryptionOptionsBlock>>? EncryptionOptions { get; set; }

    /// <summary>
    /// Block for ldap_server_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LdapServerMetadata block(s) allowed")]
    [TerraformPropertyName("ldap_server_metadata")]
    public TerraformList<TerraformBlock<AwsMqBrokerLdapServerMetadataBlock>>? LdapServerMetadata { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AwsMqBrokerLogsBlock>>? Logs { get; set; }

    /// <summary>
    /// Block for maintenance_window_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowStartTime block(s) allowed")]
    [TerraformPropertyName("maintenance_window_start_time")]
    public TerraformList<TerraformBlock<AwsMqBrokerMaintenanceWindowStartTimeBlock>>? MaintenanceWindowStartTime { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMqBrokerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [TerraformPropertyName("user")]
    public TerraformSet<TerraformBlock<AwsMqBrokerUserBlock>>? User { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Instances => new TerraformReference(this, "instances");

    /// <summary>
    /// The pending_data_replication_mode attribute.
    /// </summary>
    [TerraformPropertyName("pending_data_replication_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PendingDataReplicationMode => new TerraformReference(this, "pending_data_replication_mode");

}
