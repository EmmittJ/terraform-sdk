using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_instance.
/// </summary>
public partial class AwsDmsReplicationInstanceDataSource : TerraformDataSource
{
    public AwsDmsReplicationInstanceDataSource(string name) : base("aws_dms_replication_instance", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    [TerraformProperty("replication_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ReplicationInstanceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformProperty("allocated_storage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AllocatedStorage { get; }

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformProperty("auto_minor_version_upgrade")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AutoMinorVersionUpgrade { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformProperty("engine_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EngineVersion { get; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyArn { get; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> MultiAz { get; }

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformProperty("network_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkType { get; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredMaintenanceWindow { get; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PubliclyAccessible { get; }

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [TerraformProperty("replication_instance_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationInstanceArn { get; }

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    [TerraformProperty("replication_instance_class")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationInstanceClass { get; }

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    [TerraformProperty("replication_instance_private_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReplicationInstancePrivateIps { get; }

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    [TerraformProperty("replication_instance_public_ips")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ReplicationInstancePublicIps { get; }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [TerraformProperty("replication_subnet_group_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ReplicationSubnetGroupId { get; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> VpcSecurityGroupIds { get; }

}
