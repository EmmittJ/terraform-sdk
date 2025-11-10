using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cloudwatch_logging_options in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    public required TerraformProperty<string> LogStreamArn
    {
        set => SetProperty("log_stream_arn", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        set => SetProperty("role_arn", value);
    }

}

/// <summary>
/// Block type for inputs in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationInputsBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamePrefix is required")]
    public required TerraformProperty<string> NamePrefix
    {
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The stream_names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? StreamNames
    {
        set => SetProperty("stream_names", value);
    }

}

/// <summary>
/// Block type for outputs in .
/// Nesting mode: set
/// </summary>
public class AwsKinesisAnalyticsApplicationOutputsBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for reference_data_sources in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock : TerraformBlock
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformProperty<string> TableName
    {
        set => SetProperty("table_name", value);
    }

}

/// <summary>
/// Manages a aws_kinesis_analytics_application resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKinesisAnalyticsApplication : TerraformResource
{
    public AwsKinesisAnalyticsApplication(string name) : base("aws_kinesis_analytics_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("create_timestamp");
        SetOutput("last_update_timestamp");
        SetOutput("status");
        SetOutput("version");
        SetOutput("code");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("start_application");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformProperty<string> Code
    {
        get => GetRequiredOutput<TerraformProperty<string>>("code");
        set => SetProperty("code", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The start_application attribute.
    /// </summary>
    public TerraformProperty<bool> StartApplication
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("start_application");
        set => SetProperty("start_application", value);
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
    /// Block for cloudwatch_logging_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public List<AwsKinesisAnalyticsApplicationCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        set => SetProperty("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// Block for inputs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Inputs block(s) allowed")]
    public List<AwsKinesisAnalyticsApplicationInputsBlock>? Inputs
    {
        set => SetProperty("inputs", value);
    }

    /// <summary>
    /// Block for outputs.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Outputs block(s) allowed")]
    public HashSet<AwsKinesisAnalyticsApplicationOutputsBlock>? Outputs
    {
        set => SetProperty("outputs", value);
    }

    /// <summary>
    /// Block for reference_data_sources.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceDataSources block(s) allowed")]
    public List<AwsKinesisAnalyticsApplicationReferenceDataSourcesBlock>? ReferenceDataSources
    {
        set => SetProperty("reference_data_sources", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_timestamp attribute.
    /// </summary>
    public TerraformExpression CreateTimestamp => this["create_timestamp"];

    /// <summary>
    /// The last_update_timestamp attribute.
    /// </summary>
    public TerraformExpression LastUpdateTimestamp => this["last_update_timestamp"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}
