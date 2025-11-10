using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Revision { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "revision");

}

/// <summary>
/// Block type for encryption_options in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerEncryptionOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_id");

    /// <summary>
    /// The use_aws_owned_key attribute.
    /// </summary>
    [TerraformPropertyName("use_aws_owned_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseAwsOwnedKey { get; set; }

}

/// <summary>
/// Block type for ldap_server_metadata in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLdapServerMetadataBlock : ITerraformBlock
{
    /// <summary>
    /// The hosts attribute.
    /// </summary>
    [TerraformPropertyName("hosts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Hosts { get; set; }

    /// <summary>
    /// The role_base attribute.
    /// </summary>
    [TerraformPropertyName("role_base")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleBase { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleName { get; set; }

    /// <summary>
    /// The role_search_matching attribute.
    /// </summary>
    [TerraformPropertyName("role_search_matching")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleSearchMatching { get; set; }

    /// <summary>
    /// The role_search_subtree attribute.
    /// </summary>
    [TerraformPropertyName("role_search_subtree")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RoleSearchSubtree { get; set; }

    /// <summary>
    /// The service_account_password attribute.
    /// </summary>
    [TerraformPropertyName("service_account_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccountPassword { get; set; }

    /// <summary>
    /// The service_account_username attribute.
    /// </summary>
    [TerraformPropertyName("service_account_username")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccountUsername { get; set; }

    /// <summary>
    /// The user_base attribute.
    /// </summary>
    [TerraformPropertyName("user_base")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserBase { get; set; }

    /// <summary>
    /// The user_role_name attribute.
    /// </summary>
    [TerraformPropertyName("user_role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserRoleName { get; set; }

    /// <summary>
    /// The user_search_matching attribute.
    /// </summary>
    [TerraformPropertyName("user_search_matching")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserSearchMatching { get; set; }

    /// <summary>
    /// The user_search_subtree attribute.
    /// </summary>
    [TerraformPropertyName("user_search_subtree")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UserSearchSubtree { get; set; }

}

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The audit attribute.
    /// </summary>
    [TerraformPropertyName("audit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Audit { get; set; }

    /// <summary>
    /// The general attribute.
    /// </summary>
    [TerraformPropertyName("general")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? General { get; set; }

}

/// <summary>
/// Block type for maintenance_window_start_time in .
/// Nesting mode: list
/// </summary>
public class AwsMqBrokerMaintenanceWindowStartTimeBlock : ITerraformBlock
{
    /// <summary>
    /// The day_of_week attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DayOfWeek { get; set; }

    /// <summary>
    /// The time_of_day attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeOfDay is required")]
    [TerraformPropertyName("time_of_day")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TimeOfDay { get; set; }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TimeZone is required")]
    [TerraformPropertyName("time_zone")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TimeZone { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMqBrokerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for user in .
/// Nesting mode: set
/// </summary>
public class AwsMqBrokerUserBlock : ITerraformBlock
{
    /// <summary>
    /// The console_access attribute.
    /// </summary>
    [TerraformPropertyName("console_access")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ConsoleAccess { get; set; }

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [TerraformPropertyName("groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Groups { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformPropertyName("password")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Password { get; set; }

    /// <summary>
    /// The replication_user attribute.
    /// </summary>
    [TerraformPropertyName("replication_user")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ReplicationUser { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

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
    public TerraformProperty<TerraformProperty<bool>>? ApplyImmediately { get; set; }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    [TerraformPropertyName("authentication_strategy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AuthenticationStrategy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authentication_strategy");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutoMinorVersionUpgrade { get; set; }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BrokerName is required")]
    [TerraformPropertyName("broker_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BrokerName { get; set; }

    /// <summary>
    /// The data_replication_mode attribute.
    /// </summary>
    [TerraformPropertyName("data_replication_mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DataReplicationMode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_replication_mode");

    /// <summary>
    /// The data_replication_primary_broker_arn attribute.
    /// </summary>
    [TerraformPropertyName("data_replication_primary_broker_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataReplicationPrimaryBrokerArn { get; set; }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [TerraformPropertyName("deployment_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeploymentMode { get; set; }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineType is required")]
    [TerraformPropertyName("engine_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EngineType { get; set; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineVersion is required")]
    [TerraformPropertyName("engine_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EngineVersion { get; set; }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostInstanceType is required")]
    [TerraformPropertyName("host_instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HostInstanceType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroups { get; set; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StorageType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsMqBrokerConfigurationBlock>>? Configuration { get; set; } = new();

    /// <summary>
    /// Block for encryption_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionOptions block(s) allowed")]
    [TerraformPropertyName("encryption_options")]
    public TerraformList<TerraformBlock<AwsMqBrokerEncryptionOptionsBlock>>? EncryptionOptions { get; set; } = new();

    /// <summary>
    /// Block for ldap_server_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LdapServerMetadata block(s) allowed")]
    [TerraformPropertyName("ldap_server_metadata")]
    public TerraformList<TerraformBlock<AwsMqBrokerLdapServerMetadataBlock>>? LdapServerMetadata { get; set; } = new();

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AwsMqBrokerLogsBlock>>? Logs { get; set; } = new();

    /// <summary>
    /// Block for maintenance_window_start_time.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindowStartTime block(s) allowed")]
    [TerraformPropertyName("maintenance_window_start_time")]
    public TerraformList<TerraformBlock<AwsMqBrokerMaintenanceWindowStartTimeBlock>>? MaintenanceWindowStartTime { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMqBrokerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 User block(s) required")]
    [TerraformPropertyName("user")]
    public TerraformSet<TerraformBlock<AwsMqBrokerUserBlock>>? User { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Instances => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instances");

    /// <summary>
    /// The pending_data_replication_mode attribute.
    /// </summary>
    [TerraformPropertyName("pending_data_replication_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PendingDataReplicationMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "pending_data_replication_mode");

}
