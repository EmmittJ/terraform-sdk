using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudwatchMetricStreamExcludeFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The metric_names attribute.
    /// </summary>
    [TerraformProperty("metric_names")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? MetricNames { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Namespace { get; set; }

}

/// <summary>
/// Block type for include_filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudwatchMetricStreamIncludeFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The metric_names attribute.
    /// </summary>
    [TerraformProperty("metric_names")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? MetricNames { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Namespace { get; set; }

}

/// <summary>
/// Block type for statistics_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AwsCloudwatchMetricStreamStatisticsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The additional_statistics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalStatistics is required")]
    [TerraformProperty("additional_statistics")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AdditionalStatistics { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudwatchMetricStreamTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_metric_stream resource.
/// </summary>
public partial class AwsCloudwatchMetricStream : TerraformResource
{
    public AwsCloudwatchMetricStream(string name) : base("aws_cloudwatch_metric_stream", name)
    {
    }

    /// <summary>
    /// The firehose_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirehoseArn is required")]
    [TerraformProperty("firehose_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FirehoseArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_linked_accounts_metrics attribute.
    /// </summary>
    [TerraformProperty("include_linked_accounts_metrics")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeLinkedAccountsMetrics { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformProperty("name_prefix")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> NamePrefix { get; set; }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputFormat is required")]
    [TerraformProperty("output_format")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OutputFormat { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for exclude_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("exclude_filter")]
    public TerraformSet<TerraformBlock<AwsCloudwatchMetricStreamExcludeFilterBlock>>? ExcludeFilter { get; set; }

    /// <summary>
    /// Block for include_filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("include_filter")]
    public TerraformSet<TerraformBlock<AwsCloudwatchMetricStreamIncludeFilterBlock>>? IncludeFilter { get; set; }

    /// <summary>
    /// Block for statistics_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("statistics_configuration")]
    public TerraformSet<TerraformBlock<AwsCloudwatchMetricStreamStatisticsConfigurationBlock>>? StatisticsConfiguration { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsCloudwatchMetricStreamTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The last_update_date attribute.
    /// </summary>
    [TerraformProperty("last_update_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdateDate { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
