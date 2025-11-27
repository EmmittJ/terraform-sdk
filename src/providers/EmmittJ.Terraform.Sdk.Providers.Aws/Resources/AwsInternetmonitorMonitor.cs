using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for health_events_config in AwsInternetmonitorMonitor.
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorHealthEventsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "health_events_config";

    /// <summary>
    /// The availability_score_threshold attribute.
    /// </summary>
    public TerraformValue<double>? AvailabilityScoreThreshold
    {
        get => new TerraformReference<double>(this, "availability_score_threshold");
        set => SetArgument("availability_score_threshold", value);
    }

    /// <summary>
    /// The performance_score_threshold attribute.
    /// </summary>
    public TerraformValue<double>? PerformanceScoreThreshold
    {
        get => new TerraformReference<double>(this, "performance_score_threshold");
        set => SetArgument("performance_score_threshold", value);
    }

}


/// <summary>
/// Block type for internet_measurements_log_delivery in AwsInternetmonitorMonitor.
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "internet_measurements_log_delivery";

    /// <summary>
    /// S3Config block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Config block(s) allowed")]
    public TerraformList<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlockS3ConfigBlock>? S3Config
    {
        get => GetArgument<TerraformList<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlockS3ConfigBlock>>("s3_config");
        set => SetArgument("s3_config", value);
    }

}

/// <summary>
/// Block type for s3_config in AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock.
/// Nesting mode: list
/// </summary>
public class AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlockS3ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => new TerraformReference<string>(this, "bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => new TerraformReference<string>(this, "bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The log_delivery_status attribute.
    /// </summary>
    public TerraformValue<string>? LogDeliveryStatus
    {
        get => new TerraformReference<string>(this, "log_delivery_status");
        set => SetArgument("log_delivery_status", value);
    }

}


/// <summary>
/// Represents a aws_internetmonitor_monitor Terraform resource.
/// Manages a aws_internetmonitor_monitor resource.
/// </summary>
public partial class AwsInternetmonitorMonitor(string name) : TerraformResource("aws_internetmonitor_monitor", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    public TerraformValue<double>? MaxCityNetworksToMonitor
    {
        get => new TerraformReference<double>(this, "max_city_networks_to_monitor");
        set => SetArgument("max_city_networks_to_monitor", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformValue<string> MonitorName
    {
        get => new TerraformReference<string>(this, "monitor_name");
        set => SetArgument("monitor_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "resources").ResolveNodes(ctx));
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    public TerraformValue<double>? TrafficPercentageToMonitor
    {
        get => new TerraformReference<double>(this, "traffic_percentage_to_monitor");
        set => SetArgument("traffic_percentage_to_monitor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// HealthEventsConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HealthEventsConfig block(s) allowed")]
    public TerraformList<AwsInternetmonitorMonitorHealthEventsConfigBlock>? HealthEventsConfig
    {
        get => GetArgument<TerraformList<AwsInternetmonitorMonitorHealthEventsConfigBlock>>("health_events_config");
        set => SetArgument("health_events_config", value);
    }

    /// <summary>
    /// InternetMeasurementsLogDelivery block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InternetMeasurementsLogDelivery block(s) allowed")]
    public TerraformList<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>? InternetMeasurementsLogDelivery
    {
        get => GetArgument<TerraformList<AwsInternetmonitorMonitorInternetMeasurementsLogDeliveryBlock>>("internet_measurements_log_delivery");
        set => SetArgument("internet_measurements_log_delivery", value);
    }

}
