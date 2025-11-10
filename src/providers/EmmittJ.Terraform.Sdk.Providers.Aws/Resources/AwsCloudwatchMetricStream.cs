using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamExcludeFilterBlock : TerraformBlock
{
    /// <summary>
    /// The metric_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MetricNames
    {
        set => SetProperty("metric_names", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        set => SetProperty("namespace", value);
    }

}

/// <summary>
/// Block type for include_filter in .
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamIncludeFilterBlock : TerraformBlock
{
    /// <summary>
    /// The metric_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? MetricNames
    {
        set => SetProperty("metric_names", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        set => SetProperty("namespace", value);
    }

}

/// <summary>
/// Block type for statistics_configuration in .
/// Nesting mode: set
/// </summary>
public class AwsCloudwatchMetricStreamStatisticsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The additional_statistics attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalStatistics is required")]
    public HashSet<TerraformProperty<string>>? AdditionalStatistics
    {
        set => SetProperty("additional_statistics", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudwatchMetricStreamTimeoutsBlock : TerraformBlock
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
/// Manages a aws_cloudwatch_metric_stream resource.
/// </summary>
public class AwsCloudwatchMetricStream : TerraformResource
{
    public AwsCloudwatchMetricStream(string name) : base("aws_cloudwatch_metric_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("creation_date");
        SetOutput("last_update_date");
        SetOutput("state");
        SetOutput("firehose_arn");
        SetOutput("id");
        SetOutput("include_linked_accounts_metrics");
        SetOutput("name");
        SetOutput("name_prefix");
        SetOutput("output_format");
        SetOutput("region");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The firehose_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirehoseArn is required")]
    public required TerraformProperty<string> FirehoseArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("firehose_arn");
        set => SetProperty("firehose_arn", value);
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
    /// The include_linked_accounts_metrics attribute.
    /// </summary>
    public TerraformProperty<bool> IncludeLinkedAccountsMetrics
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("include_linked_accounts_metrics");
        set => SetProperty("include_linked_accounts_metrics", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputFormat is required")]
    public required TerraformProperty<string> OutputFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("output_format");
        set => SetProperty("output_format", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
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
    /// Block for exclude_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricStreamExcludeFilterBlock>? ExcludeFilter
    {
        set => SetProperty("exclude_filter", value);
    }

    /// <summary>
    /// Block for include_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricStreamIncludeFilterBlock>? IncludeFilter
    {
        set => SetProperty("include_filter", value);
    }

    /// <summary>
    /// Block for statistics_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlock>? StatisticsConfiguration
    {
        set => SetProperty("statistics_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudwatchMetricStreamTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The last_update_date attribute.
    /// </summary>
    public TerraformExpression LastUpdateDate => this["last_update_date"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
