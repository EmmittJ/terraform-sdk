using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterAutoScalingConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The auto_scaling_metric attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingMetric is required")]
    [TerraformPropertyName("auto_scaling_metric")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AutoScalingMetric { get; set; }

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformPropertyName("max_node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaxNodeCount { get; set; }

    /// <summary>
    /// The metric_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTarget is required")]
    [TerraformPropertyName("metric_target")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MetricTarget { get; set; }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformPropertyName("min_node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinNodeCount { get; set; }

    /// <summary>
    /// The scale_in_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleInCooldownSeconds is required")]
    [TerraformPropertyName("scale_in_cooldown_seconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ScaleInCooldownSeconds { get; set; }

    /// <summary>
    /// The scale_out_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutCooldownSeconds is required")]
    [TerraformPropertyName("scale_out_cooldown_seconds")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ScaleOutCooldownSeconds { get; set; }

}

/// <summary>
/// Block type for cache_storage_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCacheStorageConfigurationsBlock : ITerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformPropertyName("size")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Size { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for capacity_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCapacityConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> NodeCount { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformPropertyName("node_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NodeType { get; set; }

}

/// <summary>
/// Block type for code in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCodeBlock : ITerraformBlock
{
    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformPropertyName("s3_bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    [TerraformPropertyName("s3_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3Key { get; set; }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    [TerraformPropertyName("s3_object_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3ObjectVersion { get; set; }

}

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterDatabaseBlock : ITerraformBlock
{
    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    [TerraformPropertyName("changeset_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ChangesetId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformPropertyName("database_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatabaseName { get; set; }

    /// <summary>
    /// The dataview_name attribute.
    /// </summary>
    [TerraformPropertyName("dataview_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DataviewName { get; set; }

}

/// <summary>
/// Block type for savedown_storage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterSavedownStorageConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformPropertyName("size")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Size { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [TerraformPropertyName("volume_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VolumeName { get; set; }

}

/// <summary>
/// Block type for scaling_group_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterScalingGroupConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformPropertyName("cpu")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Cpu { get; set; }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    [TerraformPropertyName("memory_limit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MemoryLimit { get; set; }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryReservation is required")]
    [TerraformPropertyName("memory_reservation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MemoryReservation { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformPropertyName("node_count")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> NodeCount { get; set; }

    /// <summary>
    /// The scaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingGroupName is required")]
    [TerraformPropertyName("scaling_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ScalingGroupName { get; set; }

}

/// <summary>
/// Block type for tickerplant_log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterTickerplantLogConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The tickerplant_log_volumes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TickerplantLogVolumes is required")]
    [TerraformPropertyName("tickerplant_log_volumes")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TickerplantLogVolumes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxClusterTimeoutsBlock : ITerraformBlock
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
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterVpcConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressType is required")]
    [TerraformPropertyName("ip_address_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IpAddressType { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformPropertyName("security_group_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformPropertyName("subnet_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_finspace_kx_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFinspaceKxCluster : TerraformResource
{
    public AwsFinspaceKxCluster(string name) : base("aws_finspace_kx_cluster", name)
    {
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AvailabilityZoneId { get; set; }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    [TerraformPropertyName("az_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AzMode { get; set; }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    [TerraformPropertyName("command_line_arguments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? CommandLineArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    [TerraformPropertyName("environment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnvironmentId { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformPropertyName("execution_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The initialization_script attribute.
    /// </summary>
    [TerraformPropertyName("initialization_script")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InitializationScript { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformPropertyName("release_label")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReleaseLabel { get; set; }

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// Block for auto_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingConfiguration block(s) allowed")]
    [TerraformPropertyName("auto_scaling_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterAutoScalingConfigurationBlock>>? AutoScalingConfiguration { get; set; } = new();

    /// <summary>
    /// Block for cache_storage_configurations.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("cache_storage_configurations")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>>? CacheStorageConfigurations { get; set; } = new();

    /// <summary>
    /// Block for capacity_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfiguration block(s) allowed")]
    [TerraformPropertyName("capacity_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterCapacityConfigurationBlock>>? CapacityConfiguration { get; set; } = new();

    /// <summary>
    /// Block for code.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Code block(s) allowed")]
    [TerraformPropertyName("code")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterCodeBlock>>? Code { get; set; } = new();

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("database")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterDatabaseBlock>>? Database { get; set; } = new();

    /// <summary>
    /// Block for savedown_storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SavedownStorageConfiguration block(s) allowed")]
    [TerraformPropertyName("savedown_storage_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>>? SavedownStorageConfiguration { get; set; } = new();

    /// <summary>
    /// Block for scaling_group_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingGroupConfiguration block(s) allowed")]
    [TerraformPropertyName("scaling_group_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterScalingGroupConfigurationBlock>>? ScalingGroupConfiguration { get; set; } = new();

    /// <summary>
    /// Block for tickerplant_log_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("tickerplant_log_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>>? TickerplantLogConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsFinspaceKxClusterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    [TerraformPropertyName("vpc_configuration")]
    public TerraformList<TerraformBlock<AwsFinspaceKxClusterVpcConfigurationBlock>>? VpcConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("created_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_timestamp");

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformPropertyName("status_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_reason");

}
