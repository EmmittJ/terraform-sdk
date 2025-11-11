using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker.
/// </summary>
public partial class AwsMqBrokerDataSource : TerraformDataSource
{
    public AwsMqBrokerDataSource(string name) : base("aws_mq_broker", name)
    {
    }

    /// <summary>
    /// The broker_id attribute.
    /// </summary>
    [TerraformProperty("broker_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BrokerId { get; set; }

    /// <summary>
    /// The broker_name attribute.
    /// </summary>
    [TerraformProperty("broker_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BrokerName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The authentication_strategy attribute.
    /// </summary>
    [TerraformProperty("authentication_strategy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthenticationStrategy { get; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> AutoMinorVersionUpgrade { get; }

    /// <summary>
    /// The configuration attribute.
    /// </summary>
    [TerraformProperty("configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Configuration { get; }

    /// <summary>
    /// The deployment_mode attribute.
    /// </summary>
    [TerraformProperty("deployment_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentMode { get; }

    /// <summary>
    /// The encryption_options attribute.
    /// </summary>
    [TerraformProperty("encryption_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionOptions { get; }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [TerraformProperty("engine_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineType { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [TerraformProperty("host_instance_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HostInstanceType { get; }

    /// <summary>
    /// The instances attribute.
    /// </summary>
    [TerraformProperty("instances")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Instances { get; }

    /// <summary>
    /// The ldap_server_metadata attribute.
    /// </summary>
    [TerraformProperty("ldap_server_metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LdapServerMetadata { get; }

    /// <summary>
    /// The logs attribute.
    /// </summary>
    [TerraformProperty("logs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Logs { get; }

    /// <summary>
    /// The maintenance_window_start_time attribute.
    /// </summary>
    [TerraformProperty("maintenance_window_start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaintenanceWindowStartTime { get; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> PubliclyAccessible { get; }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    [TerraformProperty("security_groups")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SecurityGroups { get; }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StorageType { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [TerraformProperty("user")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> User { get; }

}
