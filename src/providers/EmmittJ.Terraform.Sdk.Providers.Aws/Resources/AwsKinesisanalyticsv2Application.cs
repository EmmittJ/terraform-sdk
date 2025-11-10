using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for application_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock : TerraformBlock
{
}

/// <summary>
/// Block type for cloudwatch_logging_options in .
/// Nesting mode: list
/// </summary>
public class AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The cloudwatch_logging_option_id attribute.
    /// </summary>
    public TerraformProperty<string>? CloudwatchLoggingOptionId
    {
        set => SetProperty("cloudwatch_logging_option_id", value);
    }

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    public required TerraformProperty<string> LogStreamArn
    {
        set => SetProperty("log_stream_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKinesisanalyticsv2ApplicationTimeoutsBlock : TerraformBlock
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
/// Manages a aws_kinesisanalyticsv2_application resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKinesisanalyticsv2Application : TerraformResource
{
    public AwsKinesisanalyticsv2Application(string name) : base("aws_kinesisanalyticsv2_application", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("create_timestamp");
        SetOutput("last_update_timestamp");
        SetOutput("status");
        SetOutput("version_id");
        SetOutput("application_mode");
        SetOutput("description");
        SetOutput("force_stop");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("runtime_environment");
        SetOutput("service_execution_role");
        SetOutput("start_application");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    public TerraformProperty<string> ApplicationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_mode");
        set => SetProperty("application_mode", value);
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
    /// The force_stop attribute.
    /// </summary>
    public TerraformProperty<bool> ForceStop
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_stop");
        set => SetProperty("force_stop", value);
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
    /// The runtime_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeEnvironment is required")]
    public required TerraformProperty<string> RuntimeEnvironment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("runtime_environment");
        set => SetProperty("runtime_environment", value);
    }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRole is required")]
    public required TerraformProperty<string> ServiceExecutionRole
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_execution_role");
        set => SetProperty("service_execution_role", value);
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
    /// Block for application_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationConfiguration block(s) allowed")]
    public List<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock>? ApplicationConfiguration
    {
        set => SetProperty("application_configuration", value);
    }

    /// <summary>
    /// Block for cloudwatch_logging_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public List<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        set => SetProperty("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKinesisanalyticsv2ApplicationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

}
