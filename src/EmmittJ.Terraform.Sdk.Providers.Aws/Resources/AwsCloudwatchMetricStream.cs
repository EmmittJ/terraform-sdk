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
        get => GetProperty<HashSet<TerraformProperty<string>>>("metric_names");
        set => WithProperty("metric_names", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("metric_names");
        set => WithProperty("metric_names", value);
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("additional_statistics");
        set => WithProperty("additional_statistics", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("last_update_date");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The firehose_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirehoseArn is required")]
    public required TerraformProperty<string> FirehoseArn
    {
        get => GetProperty<TerraformProperty<string>>("firehose_arn");
        set => this.WithProperty("firehose_arn", value);
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
    /// The include_linked_accounts_metrics attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeLinkedAccountsMetrics
    {
        get => GetProperty<TerraformProperty<bool>>("include_linked_accounts_metrics");
        set => this.WithProperty("include_linked_accounts_metrics", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The output_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputFormat is required")]
    public required TerraformProperty<string> OutputFormat
    {
        get => GetProperty<TerraformProperty<string>>("output_format");
        set => this.WithProperty("output_format", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
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
    /// Block for exclude_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricStreamExcludeFilterBlock>? ExcludeFilter
    {
        get => GetProperty<HashSet<AwsCloudwatchMetricStreamExcludeFilterBlock>>("exclude_filter");
        set => this.WithProperty("exclude_filter", value);
    }

    /// <summary>
    /// Block for include_filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricStreamIncludeFilterBlock>? IncludeFilter
    {
        get => GetProperty<HashSet<AwsCloudwatchMetricStreamIncludeFilterBlock>>("include_filter");
        set => this.WithProperty("include_filter", value);
    }

    /// <summary>
    /// Block for statistics_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlock>? StatisticsConfiguration
    {
        get => GetProperty<HashSet<AwsCloudwatchMetricStreamStatisticsConfigurationBlock>>("statistics_configuration");
        set => this.WithProperty("statistics_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudwatchMetricStreamTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudwatchMetricStreamTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
