using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dms_replication_instance.
/// </summary>
public class AwsDmsReplicationInstanceDataSource : TerraformDataSource
{
    public AwsDmsReplicationInstanceDataSource(string name) : base("aws_dms_replication_instance", name)
    {
    }

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
    /// The replication_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationInstanceId is required")]
    [TerraformPropertyName("replication_instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReplicationInstanceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The allocated_storage attribute.
    /// </summary>
    [TerraformPropertyName("allocated_storage")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AllocatedStorage => new TerraformReference(this, "allocated_storage");

    /// <summary>
    /// The auto_minor_version_upgrade attribute.
    /// </summary>
    [TerraformPropertyName("auto_minor_version_upgrade")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AutoMinorVersionUpgrade => new TerraformReference(this, "auto_minor_version_upgrade");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    [TerraformPropertyName("engine_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EngineVersion => new TerraformReference(this, "engine_version");

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyArn => new TerraformReference(this, "kms_key_arn");

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MultiAz => new TerraformReference(this, "multi_az");

    /// <summary>
    /// The network_type attribute.
    /// </summary>
    [TerraformPropertyName("network_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkType => new TerraformReference(this, "network_type");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredMaintenanceWindow => new TerraformReference(this, "preferred_maintenance_window");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PubliclyAccessible => new TerraformReference(this, "publicly_accessible");

    /// <summary>
    /// The replication_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationInstanceArn => new TerraformReference(this, "replication_instance_arn");

    /// <summary>
    /// The replication_instance_class attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_class")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationInstanceClass => new TerraformReference(this, "replication_instance_class");

    /// <summary>
    /// The replication_instance_private_ips attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_private_ips")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ReplicationInstancePrivateIps => new TerraformReference(this, "replication_instance_private_ips");

    /// <summary>
    /// The replication_instance_public_ips attribute.
    /// </summary>
    [TerraformPropertyName("replication_instance_public_ips")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ReplicationInstancePublicIps => new TerraformReference(this, "replication_instance_public_ips");

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [TerraformPropertyName("replication_subnet_group_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ReplicationSubnetGroupId => new TerraformReference(this, "replication_subnet_group_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> VpcSecurityGroupIds => new TerraformReference(this, "vpc_security_group_ids");

}
