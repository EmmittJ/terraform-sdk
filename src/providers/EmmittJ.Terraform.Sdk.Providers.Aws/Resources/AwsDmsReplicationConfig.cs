using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_config in .
/// Nesting mode: list
/// </summary>
public class AwsDmsReplicationConfigComputeConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "availability_zone");

    /// <summary>
    /// The dns_name_servers attribute.
    /// </summary>
    [TerraformPropertyName("dns_name_servers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DnsNameServers { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_id");

    /// <summary>
    /// The max_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxCapacityUnits { get; set; }

    /// <summary>
    /// The min_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("min_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MinCapacityUnits { get; set; }

    /// <summary>
    /// The multi_az attribute.
    /// </summary>
    [TerraformPropertyName("multi_az")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> MultiAz { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "multi_az");

    /// <summary>
    /// The preferred_maintenance_window attribute.
    /// </summary>
    [TerraformPropertyName("preferred_maintenance_window")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreferredMaintenanceWindow { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "preferred_maintenance_window");

    /// <summary>
    /// The replication_subnet_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationSubnetGroupId is required")]
    [TerraformPropertyName("replication_subnet_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationSubnetGroupId { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>("", "vpc_security_group_ids");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDmsReplicationConfigTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_dms_replication_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDmsReplicationConfig : TerraformResource
{
    public AwsDmsReplicationConfig(string name) : base("aws_dms_replication_config", name)
    {
    }

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
    /// The replication_config_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationConfigIdentifier is required")]
    [TerraformPropertyName("replication_config_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationConfigIdentifier { get; set; }

    /// <summary>
    /// The replication_settings attribute.
    /// </summary>
    [TerraformPropertyName("replication_settings")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ReplicationSettings { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "replication_settings");

    /// <summary>
    /// The replication_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicationType is required")]
    [TerraformPropertyName("replication_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReplicationType { get; set; }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [TerraformPropertyName("resource_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_identifier");

    /// <summary>
    /// The source_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceEndpointArn is required")]
    [TerraformPropertyName("source_endpoint_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceEndpointArn { get; set; }

    /// <summary>
    /// The start_replication attribute.
    /// </summary>
    [TerraformPropertyName("start_replication")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StartReplication { get; set; }

    /// <summary>
    /// The supplemental_settings attribute.
    /// </summary>
    [TerraformPropertyName("supplemental_settings")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SupplementalSettings { get; set; }

    /// <summary>
    /// The table_mappings attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableMappings is required")]
    [TerraformPropertyName("table_mappings")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TableMappings { get; set; }

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
    /// The target_endpoint_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetEndpointArn is required")]
    [TerraformPropertyName("target_endpoint_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetEndpointArn { get; set; }

    /// <summary>
    /// Block for compute_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ComputeConfig block(s) allowed")]
    [TerraformPropertyName("compute_config")]
    public TerraformList<TerraformBlock<AwsDmsReplicationConfigComputeConfigBlock>>? ComputeConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDmsReplicationConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
