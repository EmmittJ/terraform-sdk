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
        get => GetArgument<TerraformValue<double>>("availability_score_threshold");
        set => SetArgument("availability_score_threshold", value);
    }

    /// <summary>
    /// The performance_score_threshold attribute.
    /// </summary>
    public TerraformValue<double>? PerformanceScoreThreshold
    {
        get => GetArgument<TerraformValue<double>>("performance_score_threshold");
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
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The log_delivery_status attribute.
    /// </summary>
    public TerraformValue<string>? LogDeliveryStatus
    {
        get => GetArgument<TerraformValue<string>>("log_delivery_status");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    public TerraformValue<double>? MaxCityNetworksToMonitor
    {
        get => GetArgument<TerraformValue<double>>("max_city_networks_to_monitor");
        set => SetArgument("max_city_networks_to_monitor", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformValue<string> MonitorName
    {
        get => GetRequiredArgument<TerraformValue<string>>("monitor_name");
        set => SetArgument("monitor_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformSet<string>? Resources
    {
        get => GetArgument<TerraformSet<string>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    public TerraformValue<double>? TrafficPercentageToMonitor
    {
        get => GetArgument<TerraformValue<double>>("traffic_percentage_to_monitor");
        set => SetArgument("traffic_percentage_to_monitor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

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
