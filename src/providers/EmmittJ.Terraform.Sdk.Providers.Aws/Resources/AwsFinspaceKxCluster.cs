using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_configuration in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterAutoScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_scaling_configuration";

    /// <summary>
    /// The auto_scaling_metric attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingMetric is required")]
    public required TerraformValue<string> AutoScalingMetric
    {
        get => GetArgument<TerraformValue<string>>("auto_scaling_metric");
        set => SetArgument("auto_scaling_metric", value);
    }

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformValue<double> MaxNodeCount
    {
        get => GetArgument<TerraformValue<double>>("max_node_count");
        set => SetArgument("max_node_count", value);
    }

    /// <summary>
    /// The metric_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTarget is required")]
    public required TerraformValue<double> MetricTarget
    {
        get => GetArgument<TerraformValue<double>>("metric_target");
        set => SetArgument("metric_target", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformValue<double> MinNodeCount
    {
        get => GetArgument<TerraformValue<double>>("min_node_count");
        set => SetArgument("min_node_count", value);
    }

    /// <summary>
    /// The scale_in_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleInCooldownSeconds is required")]
    public required TerraformValue<double> ScaleInCooldownSeconds
    {
        get => GetArgument<TerraformValue<double>>("scale_in_cooldown_seconds");
        set => SetArgument("scale_in_cooldown_seconds", value);
    }

    /// <summary>
    /// The scale_out_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutCooldownSeconds is required")]
    public required TerraformValue<double> ScaleOutCooldownSeconds
    {
        get => GetArgument<TerraformValue<double>>("scale_out_cooldown_seconds");
        set => SetArgument("scale_out_cooldown_seconds", value);
    }

}


/// <summary>
/// Block type for cache_storage_configurations in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCacheStorageConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_storage_configurations";

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for capacity_configuration in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCapacityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "capacity_configuration";

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformValue<double> NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformValue<string> NodeType
    {
        get => GetArgument<TerraformValue<string>>("node_type");
        set => SetArgument("node_type", value);
    }

}


/// <summary>
/// Block type for code in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "code";

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformValue<string> S3Key
    {
        get => GetArgument<TerraformValue<string>>("s3_key");
        set => SetArgument("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? S3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("s3_object_version");
        set => SetArgument("s3_object_version", value);
    }

}


/// <summary>
/// Block type for database in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database";

    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    public TerraformValue<string>? ChangesetId
    {
        get => GetArgument<TerraformValue<string>>("changeset_id");
        set => SetArgument("changeset_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The dataview_name attribute.
    /// </summary>
    public TerraformValue<string>? DataviewName
    {
        get => GetArgument<TerraformValue<string>>("dataview_name");
        set => SetArgument("dataview_name", value);
    }

    /// <summary>
    /// CacheConfigurations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFinspaceKxClusterDatabaseBlockCacheConfigurationsBlock>? CacheConfigurations
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterDatabaseBlockCacheConfigurationsBlock>>("cache_configurations");
        set => SetArgument("cache_configurations", value);
    }

}

/// <summary>
/// Block type for cache_configurations in AwsFinspaceKxClusterDatabaseBlock.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterDatabaseBlockCacheConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_configurations";

    /// <summary>
    /// The cache_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheType is required")]
    public required TerraformValue<string> CacheType
    {
        get => GetArgument<TerraformValue<string>>("cache_type");
        set => SetArgument("cache_type", value);
    }

    /// <summary>
    /// The db_paths attribute.
    /// </summary>
    public TerraformSet<string>? DbPaths
    {
        get => GetArgument<TerraformSet<string>>("db_paths");
        set => SetArgument("db_paths", value);
    }

}


/// <summary>
/// Block type for savedown_storage_configuration in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterSavedownStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "savedown_storage_configuration";

    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformValue<double>? Size
    {
        get => GetArgument<TerraformValue<double>>("size");
        set => SetArgument("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    public TerraformValue<string>? VolumeName
    {
        get => GetArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

}


/// <summary>
/// Block type for scaling_group_configuration in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterScalingGroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scaling_group_configuration";

    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformValue<double>? Cpu
    {
        get => GetArgument<TerraformValue<double>>("cpu");
        set => SetArgument("cpu", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformValue<double>? MemoryLimit
    {
        get => GetArgument<TerraformValue<double>>("memory_limit");
        set => SetArgument("memory_limit", value);
    }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryReservation is required")]
    public required TerraformValue<double> MemoryReservation
    {
        get => GetArgument<TerraformValue<double>>("memory_reservation");
        set => SetArgument("memory_reservation", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformValue<double> NodeCount
    {
        get => GetArgument<TerraformValue<double>>("node_count");
        set => SetArgument("node_count", value);
    }

    /// <summary>
    /// The scaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingGroupName is required")]
    public required TerraformValue<string> ScalingGroupName
    {
        get => GetArgument<TerraformValue<string>>("scaling_group_name");
        set => SetArgument("scaling_group_name", value);
    }

}


/// <summary>
/// Block type for tickerplant_log_configuration in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterTickerplantLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tickerplant_log_configuration";

    /// <summary>
    /// The tickerplant_log_volumes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TickerplantLogVolumes is required")]
    public required TerraformSet<string> TickerplantLogVolumes
    {
        get => GetArgument<TerraformSet<string>>("tickerplant_log_volumes");
        set => SetArgument("tickerplant_log_volumes", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsFinspaceKxCluster.
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vpc_configuration in AwsFinspaceKxCluster.
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_configuration";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressType is required")]
    public required TerraformValue<string> IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public required TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids");
        set => SetArgument("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Represents a aws_finspace_kx_cluster Terraform resource.
/// Manages a aws_finspace_kx_cluster resource.
/// </summary>
public partial class AwsFinspaceKxCluster(string name) : TerraformResource("aws_finspace_kx_cluster", name)
{
    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformValue<string> AzMode
    {
        get => GetArgument<TerraformValue<string>>("az_mode");
        set => SetArgument("az_mode", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public TerraformMap<string>? CommandLineArguments
    {
        get => GetArgument<TerraformMap<string>>("command_line_arguments");
        set => SetArgument("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformValue<string> EnvironmentId
    {
        get => GetArgument<TerraformValue<string>>("environment_id");
        set => SetArgument("environment_id", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRole
    {
        get => GetArgument<TerraformValue<string>>("execution_role");
        set => SetArgument("execution_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The initialization_script attribute.
    /// </summary>
    public TerraformValue<string>? InitializationScript
    {
        get => GetArgument<TerraformValue<string>>("initialization_script");
        set => SetArgument("initialization_script", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformValue<string> ReleaseLabel
    {
        get => GetArgument<TerraformValue<string>>("release_label");
        set => SetArgument("release_label", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreatedTimestamp
        => AsReference("created_timestamp");

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedTimestamp
        => AsReference("last_modified_timestamp");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// AutoScalingConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingConfiguration block(s) allowed")]
    public TerraformList<AwsFinspaceKxClusterAutoScalingConfigurationBlock>? AutoScalingConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterAutoScalingConfigurationBlock>>("auto_scaling_configuration");
        set => SetArgument("auto_scaling_configuration", value);
    }

    /// <summary>
    /// CacheStorageConfigurations block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>? CacheStorageConfigurations
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>>("cache_storage_configurations");
        set => SetArgument("cache_storage_configurations", value);
    }

    /// <summary>
    /// CapacityConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfiguration block(s) allowed")]
    public TerraformList<AwsFinspaceKxClusterCapacityConfigurationBlock>? CapacityConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterCapacityConfigurationBlock>>("capacity_configuration");
        set => SetArgument("capacity_configuration", value);
    }

    /// <summary>
    /// Code block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Code block(s) allowed")]
    public TerraformList<AwsFinspaceKxClusterCodeBlock>? Code
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterCodeBlock>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// Database block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFinspaceKxClusterDatabaseBlock>? Database
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterDatabaseBlock>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// SavedownStorageConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SavedownStorageConfiguration block(s) allowed")]
    public TerraformList<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>? SavedownStorageConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>>("savedown_storage_configuration");
        set => SetArgument("savedown_storage_configuration", value);
    }

    /// <summary>
    /// ScalingGroupConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingGroupConfiguration block(s) allowed")]
    public TerraformList<AwsFinspaceKxClusterScalingGroupConfigurationBlock>? ScalingGroupConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterScalingGroupConfigurationBlock>>("scaling_group_configuration");
        set => SetArgument("scaling_group_configuration", value);
    }

    /// <summary>
    /// TickerplantLogConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>? TickerplantLogConfiguration
    {
        get => GetArgument<TerraformList<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>>("tickerplant_log_configuration");
        set => SetArgument("tickerplant_log_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsFinspaceKxClusterTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsFinspaceKxClusterTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public required TerraformList<AwsFinspaceKxClusterVpcConfigurationBlock> VpcConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsFinspaceKxClusterVpcConfigurationBlock>>("vpc_configuration");
        set => SetArgument("vpc_configuration", value);
    }

}
