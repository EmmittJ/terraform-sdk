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
        get => GetRequiredProperty<TerraformProperty<string>>("auto_scaling_metric");
        set => WithProperty("auto_scaling_metric", value);
    }

    /// <summary>
    /// The max_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxNodeCount is required")]
    public required TerraformProperty<double> MaxNodeCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("max_node_count");
        set => WithProperty("max_node_count", value);
    }

    /// <summary>
    /// The metric_target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricTarget is required")]
    public required TerraformProperty<double> MetricTarget
    {
        get => GetRequiredProperty<TerraformProperty<double>>("metric_target");
        set => WithProperty("metric_target", value);
    }

    /// <summary>
    /// The min_node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinNodeCount is required")]
    public required TerraformProperty<double> MinNodeCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("min_node_count");
        set => WithProperty("min_node_count", value);
    }

    /// <summary>
    /// The scale_in_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleInCooldownSeconds is required")]
    public required TerraformProperty<double> ScaleInCooldownSeconds
    {
        get => GetRequiredProperty<TerraformProperty<double>>("scale_in_cooldown_seconds");
        set => WithProperty("scale_in_cooldown_seconds", value);
    }

    /// <summary>
    /// The scale_out_cooldown_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScaleOutCooldownSeconds is required")]
    public required TerraformProperty<double> ScaleOutCooldownSeconds
    {
        get => GetRequiredProperty<TerraformProperty<double>>("scale_out_cooldown_seconds");
        set => WithProperty("scale_out_cooldown_seconds", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetRequiredProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// The node_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeType is required")]
    public required TerraformProperty<string> NodeType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("node_type");
        set => WithProperty("node_type", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("s3_bucket");
        set => WithProperty("s3_bucket", value);
    }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Key is required")]
    public required TerraformProperty<string> S3Key
    {
        get => GetRequiredProperty<TerraformProperty<string>>("s3_key");
        set => WithProperty("s3_key", value);
    }

    /// <summary>
    /// The s3_object_version attribute.
    /// </summary>
    public TerraformProperty<string>? S3ObjectVersion
    {
        get => GetProperty<TerraformProperty<string>>("s3_object_version");
        set => WithProperty("s3_object_version", value);
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
        get => GetProperty<TerraformProperty<string>>("changeset_id");
        set => WithProperty("changeset_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The dataview_name attribute.
    /// </summary>
    public TerraformProperty<string>? DataviewName
    {
        get => GetProperty<TerraformProperty<string>>("dataview_name");
        set => WithProperty("dataview_name", value);
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
        get => GetProperty<TerraformProperty<double>>("size");
        set => WithProperty("size", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The volume_name attribute.
    /// </summary>
    public TerraformProperty<string>? VolumeName
    {
        get => GetProperty<TerraformProperty<string>>("volume_name");
        set => WithProperty("volume_name", value);
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
        get => GetProperty<TerraformProperty<double>>("cpu");
        set => WithProperty("cpu", value);
    }

    /// <summary>
    /// The memory_limit attribute.
    /// </summary>
    public TerraformProperty<double>? MemoryLimit
    {
        get => GetProperty<TerraformProperty<double>>("memory_limit");
        set => WithProperty("memory_limit", value);
    }

    /// <summary>
    /// The memory_reservation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemoryReservation is required")]
    public required TerraformProperty<double> MemoryReservation
    {
        get => GetRequiredProperty<TerraformProperty<double>>("memory_reservation");
        set => WithProperty("memory_reservation", value);
    }

    /// <summary>
    /// The node_count attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NodeCount is required")]
    public required TerraformProperty<double> NodeCount
    {
        get => GetRequiredProperty<TerraformProperty<double>>("node_count");
        set => WithProperty("node_count", value);
    }

    /// <summary>
    /// The scaling_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScalingGroupName is required")]
    public required TerraformProperty<string> ScalingGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scaling_group_name");
        set => WithProperty("scaling_group_name", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("tickerplant_log_volumes");
        set => WithProperty("tickerplant_log_volumes", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("ip_address_type");
        set => WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityGroupIds is required")]
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformProperty<string> VpcId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("created_timestamp");
        this.DeclareOutput("last_modified_timestamp");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
    }

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZoneId
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone_id");
        set => this.WithProperty("availability_zone_id", value);
    }

    /// <summary>
    /// The az_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzMode is required")]
    public required TerraformProperty<string> AzMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("az_mode");
        set => this.WithProperty("az_mode", value);
    }

    /// <summary>
    /// The command_line_arguments attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? CommandLineArguments
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("command_line_arguments");
        set => this.WithProperty("command_line_arguments", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The environment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvironmentId is required")]
    public required TerraformProperty<string> EnvironmentId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("environment_id");
        set => this.WithProperty("environment_id", value);
    }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    public TerraformProperty<string>? ExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("execution_role");
        set => this.WithProperty("execution_role", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The initialization_script attribute.
    /// </summary>
    public TerraformProperty<string>? InitializationScript
    {
        get => GetProperty<TerraformProperty<string>>("initialization_script");
        set => this.WithProperty("initialization_script", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The release_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReleaseLabel is required")]
    public required TerraformProperty<string> ReleaseLabel
    {
        get => GetRequiredProperty<TerraformProperty<string>>("release_label");
        set => this.WithProperty("release_label", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for auto_scaling_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoScalingConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterAutoScalingConfigurationBlock>? AutoScalingConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxClusterAutoScalingConfigurationBlock>>("auto_scaling_configuration");
        set => this.WithProperty("auto_scaling_configuration", value);
    }

    /// <summary>
    /// Block for cache_storage_configurations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>? CacheStorageConfigurations
    {
        get => GetProperty<List<AwsFinspaceKxClusterCacheStorageConfigurationsBlock>>("cache_storage_configurations");
        set => this.WithProperty("cache_storage_configurations", value);
    }

    /// <summary>
    /// Block for capacity_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CapacityConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterCapacityConfigurationBlock>? CapacityConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxClusterCapacityConfigurationBlock>>("capacity_configuration");
        set => this.WithProperty("capacity_configuration", value);
    }

    /// <summary>
    /// Block for code.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Code block(s) allowed")]
    public List<AwsFinspaceKxClusterCodeBlock>? Code
    {
        get => GetProperty<List<AwsFinspaceKxClusterCodeBlock>>("code");
        set => this.WithProperty("code", value);
    }

    /// <summary>
    /// Block for database.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxClusterDatabaseBlock>? Database
    {
        get => GetProperty<List<AwsFinspaceKxClusterDatabaseBlock>>("database");
        set => this.WithProperty("database", value);
    }

    /// <summary>
    /// Block for savedown_storage_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SavedownStorageConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>? SavedownStorageConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxClusterSavedownStorageConfigurationBlock>>("savedown_storage_configuration");
        set => this.WithProperty("savedown_storage_configuration", value);
    }

    /// <summary>
    /// Block for scaling_group_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScalingGroupConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterScalingGroupConfigurationBlock>? ScalingGroupConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxClusterScalingGroupConfigurationBlock>>("scaling_group_configuration");
        set => this.WithProperty("scaling_group_configuration", value);
    }

    /// <summary>
    /// Block for tickerplant_log_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>? TickerplantLogConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxClusterTickerplantLogConfigurationBlock>>("tickerplant_log_configuration");
        set => this.WithProperty("tickerplant_log_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFinspaceKxClusterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsFinspaceKxClusterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VpcConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public List<AwsFinspaceKxClusterVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetProperty<List<AwsFinspaceKxClusterVpcConfigurationBlock>>("vpc_configuration");
        set => this.WithProperty("vpc_configuration", value);
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
