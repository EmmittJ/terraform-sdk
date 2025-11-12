using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsDmsReplicationConfigComputeConfigBlock() : TerraformBlock("compute_config")
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AvailabilityZone { get; set; }

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    [TerraformProperty("dns_name_servers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DnsNameServers { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The max_capacity_units attribute.
    /// </summary>
    [TerraformProperty("max_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxCapacityUnits { get; set; }

    /// <summary>
    /// The min_capacity_units attribute.
    /// </summary>
    [TerraformProperty("min_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MinCapacityUnits { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformProperty("multi_az")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> MultiAz { get; set; }

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformProperty("preferred_maintenance_window")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreferredMaintenanceWindow { get; set; }

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    [TerraformProperty("replication_subnet_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationSubnetGroupId { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDmsReplicationConfigTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a aws_dms_replication_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsDmsReplicationConfig : TerraformResource
{
    public AwsDmsReplicationConfig(string name) : base("aws_dms_replication_config", name)
    {
    }

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
    /// The replication_config_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationConfigIdentifier is required")]
    [TerraformProperty("replication_config_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationConfigIdentifier { get; set; }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    [TerraformProperty("replication_settings")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ReplicationSettings { get; set; }

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationType is required")]
    [TerraformProperty("replication_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReplicationType { get; set; }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformProperty("resource_identifier")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceIdentifier { get; set; }

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    [TerraformProperty("source_endpoint_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceEndpointArn { get; set; }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    [TerraformProperty("start_replication")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartReplication { get; set; }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    [TerraformProperty("supplemental_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SupplementalSettings { get; set; }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    [TerraformProperty("table_mappings")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableMappings { get; set; }

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
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    [TerraformProperty("target_endpoint_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetEndpointArn { get; set; }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    [TerraformProperty("compute_config")]
    public required TerraformList<AwsDmsReplicationConfigComputeConfigBlock> ComputeConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDmsReplicationConfigTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
