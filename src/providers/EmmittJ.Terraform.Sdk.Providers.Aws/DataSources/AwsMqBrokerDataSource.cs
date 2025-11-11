using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker.
/// </summary>
public class AwsMqBrokerDataSource : TerraformDataSource
{
    public AwsMqBrokerDataSource(string name) : base("aws_mq_broker", name)
    {
    }

    /// <summary>
    /// The broker_id attribute.
    /// </summary>
    [TerraformPropertyName("broker_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BrokerId { get; set; } = default!;

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [TerraformPropertyName("broker_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BrokerName { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    [TerraformPropertyName("authentication_strategy")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AuthenticationStrategy => new TerraformReference(this, "authentication_strategy");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoMinorVersionUpgrade => new TerraformReference(this, "auto_minor_version_upgrade");

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformPropertyName("configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Configuration => new TerraformReference(this, "configuration");

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [TerraformPropertyName("deployment_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentMode => new TerraformReference(this, "deployment_mode");

    /// <summary>
    /// The encryption_options attribute.
    /// </summary>
    [TerraformPropertyName("encryption_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionOptions => new TerraformReference(this, "encryption_options");

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [TerraformPropertyName("engine_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineType => new TerraformReference(this, "engine_type");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [TerraformPropertyName("host_instance_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostInstanceType => new TerraformReference(this, "host_instance_type");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Instances => new TerraformReference(this, "instances");

    /// <summary>
    /// The ldap_server_metadata attribute.
    /// </summary>
    [TerraformPropertyName("ldap_server_metadata")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LdapServerMetadata => new TerraformReference(this, "ldap_server_metadata");

    /// <summary>
    /// The logs attribute.
    /// </summary>
    [TerraformPropertyName("logs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Logs => new TerraformReference(this, "logs");

    /// <summary>
    /// The maintenance_window_start_time attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window_start_time")]
    // Output-only attribute - read-only reference
    public TerraformList<object> MaintenanceWindowStartTime => new TerraformReference(this, "maintenance_window_start_time");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PubliclyAccessible => new TerraformReference(this, "publicly_accessible");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroups => new TerraformReference(this, "security_groups");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageType => new TerraformReference(this, "storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> User => new TerraformReference(this, "user");

}
