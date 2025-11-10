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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BrokerId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "broker_id");

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [TerraformPropertyName("broker_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BrokerName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "broker_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    [TerraformPropertyName("authentication_strategy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthenticationStrategy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "authentication_strategy");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoMinorVersionUpgrade => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_minor_version_upgrade");

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformPropertyName("configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Configuration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "configuration");

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [TerraformPropertyName("deployment_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_mode");

    /// <summary>
    /// The encryption_options attribute.
    /// </summary>
    [TerraformPropertyName("encryption_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EncryptionOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "encryption_options");

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [TerraformPropertyName("engine_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_type");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_version");

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [TerraformPropertyName("host_instance_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostInstanceType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_instance_type");

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformPropertyName("instances")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Instances => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instances");

    /// <summary>
    /// The ldap_server_metadata attribute.
    /// </summary>
    [TerraformPropertyName("ldap_server_metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LdapServerMetadata => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ldap_server_metadata");

    /// <summary>
    /// The logs attribute.
    /// </summary>
    [TerraformPropertyName("logs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Logs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "logs");

    /// <summary>
    /// The maintenance_window_start_time attribute.
    /// </summary>
    [TerraformPropertyName("maintenance_window_start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> MaintenanceWindowStartTime => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "maintenance_window_start_time");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformPropertyName("security_groups")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroups => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_groups");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformPropertyName("storage_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_type");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformPropertyName("user")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> User => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "user");

}
