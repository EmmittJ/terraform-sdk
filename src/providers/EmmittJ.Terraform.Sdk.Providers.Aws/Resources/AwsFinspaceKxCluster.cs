using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_scaling_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterAutoScalingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The auto_scaling_metric attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingMetric is required")]
    public required TerraformProperty<string> AutoScalingMetric
    {
        set => SetProperty("auto_scaling_metric", value);
    }

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformProperty<double> MaxNodeCount
    {
        set => SetProperty("max_node_count", value);
    }

    /// <summary>
    /// The metric_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTarget is required")]
    public required TerraformProperty<double> MetricTarget
    {
        set => SetProperty("metric_target", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformProperty<double> MinNodeCount
    {
        set => SetProperty("min_node_count", value);
    }

    /// <summary>
    /// The scale_in_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleInCooldownSeconds is required")]
    public required TerraformProperty<double> ScaleInCooldownSeconds
    {
        set => SetProperty("scale_in_cooldown_seconds", value);
    }

    /// <summary>
    /// The scale_out_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutCooldownSeconds is required")]
    public required TerraformProperty<double> ScaleOutCooldownSeconds
    {
        set => SetProperty("scale_out_cooldown_seconds", value);
    }

}

/// <summary>
/// Block type for cache_storage_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCacheStorageConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for capacity_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCapacityConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        set => SetProperty("node_type", value);
    }

}

/// <summary>
/// Block type for code in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterCodeBlock : TerraformBlock
{
    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformProperty<string> S3Bucket
    {
        set => SetProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformProperty<string> S3Key
    {
        set => SetProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? S3ObjectVersion
    {
        set => SetProperty("s3_object_version", value);
    }

}

/// <summary>
/// Block type for database in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// The changeset_id attribute.
    /// </summary>
    public TerraformProperty<string>? ChangesetId
    {
        set => SetProperty("changeset_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The dataview_name attribute.
    /// </summary>
    public TerraformProperty<string>? DataviewName
    {
        set => SetProperty("dataview_name", value);
    }

}

/// <summary>
/// Block type for savedown_storage_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterSavedownStorageConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    public TerraformProperty<double>? Size
    {
        set => SetProperty("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeName
    {
        set => SetProperty("volume_name", value);
    }

}

/// <summary>
/// Block type for scaling_group_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterScalingGroupConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The cpu attribute.
    /// </summary>
    public TerraformProperty<double>? Cpu
    {
        set => SetProperty("cpu", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryLimit
    {
        set => SetProperty("memory_limit", value);
    }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryReservation is required")]
    public required TerraformProperty<double> MemoryReservation
    {
        set => SetProperty("memory_reservation", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        set => SetProperty("node_count", value);
    }

    /// <summary>
    /// The scaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingGroupName is required")]
    public required TerraformProperty<string> ScalingGroupName
    {
        set => SetProperty("scaling_group_name", value);
    }

}

/// <summary>
/// Block type for tickerplant_log_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterTickerplantLogConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The tickerplant_log_volumes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TickerplantLogVolumes is required")]
    public HashSet<TerraformProperty<string>>? TickerplantLogVolumes
    {
        set => SetProperty("tickerplant_log_volumes", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFinspaceKxClusterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFinspaceKxClusterVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpAddressType is required")]
    public required TerraformProperty<string> IpAddressType
    {
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        set => SetProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        set => SetProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_finspace_kx_cluster resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFinspaceKxCluster : TerraformResource
{
    public AwsFinspaceKxCluster(string name) : base("aws_finspace_kx_cluster", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("created_timestamp");
        SetOutput("last_modified_timestamp");
        SetOutput("status");
        SetOutput("status_reason");
        SetOutput("availability_zone_id");
        SetOutput("az_mode");
        SetOutput("command_line_arguments");
        SetOutput("description");
        SetOutput("environment_id");
        SetOutput("execution_role");
        SetOutput("id");
        SetOutput("initialization_script");
        SetOutput("name");
        SetOutput("region");
        SetOutput("release_label");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("type");
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string> AvailabilityZoneId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone_id");
        set => SetProperty("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformProperty<string> AzMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("az_mode");
        set => SetProperty("az_mode", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> CommandLineArguments
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("command_line_arguments");
        set => SetProperty("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment_id");
        set => SetProperty("environment_id", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformProperty<string> ExecutionRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role");
        set => SetProperty("execution_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The initialization_script attribute.
    /// </summary>
    public TerraformProperty<string> InitializationScript
    {
        get => GetRequiredOutput<TerraformProperty<string>>("initialization_script");
        set => SetProperty("initialization_script", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformProperty<string> ReleaseLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_label");
        set => SetProperty("release_label", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for auto_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterAutoScalingConfigurationBlock>? AutoScalingConfiguration
    {
        set => SetProperty("auto_scaling_configuration", value);
    }

    /// <summary>
    /// Block for cache_storage_configurations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>? CacheStorageConfigurations
    {
        set => SetProperty("cache_storage_configurations", value);
    }

    /// <summary>
    /// Block for capacity_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterCapacityConfigurationBlock>? CapacityConfiguration
    {
        set => SetProperty("capacity_configuration", value);
    }

    /// <summary>
    /// Block for code.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Code block(s) allowed")]
    public List<AwsFinspaceKxClusterCodeBlock>? Code
    {
        set => SetProperty("code", value);
    }

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxClusterDatabaseBlock>? Database
    {
        set => SetProperty("database", value);
    }

    /// <summary>
    /// Block for savedown_storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SavedownStorageConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>? SavedownStorageConfiguration
    {
        set => SetProperty("savedown_storage_configuration", value);
    }

    /// <summary>
    /// Block for scaling_group_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingGroupConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterScalingGroupConfigurationBlock>? ScalingGroupConfiguration
    {
        set => SetProperty("scaling_group_configuration", value);
    }

    /// <summary>
    /// Block for tickerplant_log_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>? TickerplantLogConfiguration
    {
        set => SetProperty("tickerplant_log_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFinspaceKxClusterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterVpcConfigurationBlock>? VpcConfiguration
    {
        set => SetProperty("vpc_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformExpression CreatedTimestamp => this["created_timestamp"];

    /// <summary>
    /// The last_modified_timestamp attribute.
    /// </summary>
    public TerraformExpression LastModifiedTimestamp => this["last_modified_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
