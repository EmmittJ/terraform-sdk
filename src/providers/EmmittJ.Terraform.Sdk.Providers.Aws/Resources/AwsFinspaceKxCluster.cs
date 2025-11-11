using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterAutoScalingConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The auto_scaling_metric attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingMetric is required")]
    [TerraformProperty("auto_scaling_metric")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AutoScalingMetric { get; set; }

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    [TerraformProperty("max_node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaxNodeCount { get; set; }

    /// <summary>
    /// The metric_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTarget is required")]
    [TerraformProperty("metric_target")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MetricTarget { get; set; }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    [TerraformProperty("min_node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinNodeCount { get; set; }

    /// <summary>
    /// The scale_in_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleInCooldownSeconds is required")]
    [TerraformProperty("scale_in_cooldown_seconds")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ScaleInCooldownSeconds { get; set; }

    /// <summary>
    /// The scale_out_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutCooldownSeconds is required")]
    [TerraformProperty("scale_out_cooldown_seconds")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ScaleOutCooldownSeconds { get; set; }

}

/// <summary>
/// Block type for cache_storage_configurations in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterCacheStorageConfigurationsBlock : TerraformBlockBase
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Size { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for capacity_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterCapacityConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformProperty("node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    [TerraformProperty("node_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NodeType { get; set; }

}

/// <summary>
/// Block type for code in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterCodeBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    [TerraformProperty("s3_bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    [TerraformProperty("s3_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3Key { get; set; }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    [TerraformProperty("s3_object_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3ObjectVersion { get; set; }

}

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterDatabaseBlock : TerraformBlockBase
{
    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    [TerraformProperty("changeset_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ChangesetId { get; set; }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    [TerraformProperty("database_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatabaseName { get; set; }

    /// <summary>
    /// The dataview_name attribute.
    /// </summary>
    [TerraformProperty("dataview_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DataviewName { get; set; }

}

/// <summary>
/// Block type for savedown_storage_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterSavedownStorageConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [TerraformProperty("size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Size { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    [TerraformProperty("volume_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VolumeName { get; set; }

}

/// <summary>
/// Block type for scaling_group_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterScalingGroupConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    [TerraformProperty("cpu")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Cpu { get; set; }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    [TerraformProperty("memory_limit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MemoryLimit { get; set; }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryReservation is required")]
    [TerraformProperty("memory_reservation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MemoryReservation { get; set; }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    [TerraformProperty("node_count")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> NodeCount { get; set; }

    /// <summary>
    /// The scaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingGroupName is required")]
    [TerraformProperty("scaling_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScalingGroupName { get; set; }

}

/// <summary>
/// Block type for tickerplant_log_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterTickerplantLogConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The tickerplant_log_volumes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TickerplantLogVolumes is required")]
    [TerraformProperty("tickerplant_log_volumes")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> TickerplantLogVolumes { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsFinspaceKxClusterTimeoutsBlock : TerraformBlockBase
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
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsFinspaceKxClusterVpcConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressType is required")]
    [TerraformProperty("ip_address_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IpAddressType { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    [TerraformProperty("security_group_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    [TerraformProperty("subnet_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_finspace_kx_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFinspaceKxCluster : TerraformResource
{
    public AwsFinspaceKxCluster(string name) : base("aws_finspace_kx_cluster", name)
    {
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [TerraformProperty("availability_zone_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvailabilityZoneId { get; set; }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    [TerraformProperty("az_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AzMode { get; set; }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    [TerraformProperty("command_line_arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? CommandLineArguments { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    [TerraformProperty("environment_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EnvironmentId { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformProperty("execution_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExecutionRole { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initialization_script attribute.
    /// </summary>
    [TerraformProperty("initialization_script")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InitializationScript { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    [TerraformProperty("release_label")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReleaseLabel { get; set; }

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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for auto_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingConfiguration block(s) allowed")]
    [TerraformProperty("auto_scaling_configuration")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterAutoScalingConfigurationBlock>>? AutoScalingConfiguration { get; set; }

    /// <summary>
    /// Block for cache_storage_configurations.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("cache_storage_configurations")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>>? CacheStorageConfigurations { get; set; }

    /// <summary>
    /// Block for capacity_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfiguration block(s) allowed")]
    [TerraformProperty("capacity_configuration")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterCapacityConfigurationBlock>>? CapacityConfiguration { get; set; }

    /// <summary>
    /// Block for code.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Code block(s) allowed")]
    [TerraformProperty("code")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterCodeBlock>>? Code { get; set; }

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("database")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterDatabaseBlock>>? Database { get; set; }

    /// <summary>
    /// Block for savedown_storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SavedownStorageConfiguration block(s) allowed")]
    [TerraformProperty("savedown_storage_configuration")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>>? SavedownStorageConfiguration { get; set; }

    /// <summary>
    /// Block for scaling_group_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingGroupConfiguration block(s) allowed")]
    [TerraformProperty("scaling_group_configuration")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterScalingGroupConfigurationBlock>>? ScalingGroupConfiguration { get; set; }

    /// <summary>
    /// Block for tickerplant_log_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("tickerplant_log_configuration")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>>? TickerplantLogConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsFinspaceKxClusterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    [TerraformProperty("vpc_configuration")]
    public partial TerraformList<TerraformBlock<AwsFinspaceKxClusterVpcConfigurationBlock>>? VpcConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    [TerraformProperty("created_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTimestamp { get; }

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    [TerraformProperty("last_modified_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastModifiedTimestamp { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    [TerraformProperty("status_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusReason { get; }

}
