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
        get => GetProperty<TerraformProperty<string>>("cloudwatch_logging_option_id");
        set => WithProperty("cloudwatch_logging_option_id", value);
    }

    /// <summary>
    /// The log_stream_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogStreamArn is required")]
    public required TerraformProperty<string> LogStreamArn
    {
        get => GetProperty<TerraformProperty<string>>("log_stream_arn");
        set => WithProperty("log_stream_arn", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("create_timestamp");
        this.DeclareOutput("last_update_timestamp");
        this.DeclareOutput("status");
        this.DeclareOutput("version_id");
    }

    /// <summary>
    /// The application_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationMode
    {
        get => GetProperty<TerraformProperty<string>>("application_mode");
        set => this.WithProperty("application_mode", value);
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
    /// The force_stop attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceStop
    {
        get => GetProperty<TerraformProperty<bool>>("force_stop");
        set => this.WithProperty("force_stop", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    /// The runtime_environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeEnvironment is required")]
    public required TerraformProperty<string> RuntimeEnvironment
    {
        get => GetProperty<TerraformProperty<string>>("runtime_environment");
        set => this.WithProperty("runtime_environment", value);
    }

    /// <summary>
    /// The service_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceExecutionRole is required")]
    public required TerraformProperty<string> ServiceExecutionRole
    {
        get => GetProperty<TerraformProperty<string>>("service_execution_role");
        set => this.WithProperty("service_execution_role", value);
    }

    /// <summary>
    /// The start_application attribute.
    /// </summary>
    public TerraformProperty<bool>? StartApplication
    {
        get => GetProperty<TerraformProperty<bool>>("start_application");
        set => this.WithProperty("start_application", value);
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
    /// Block for application_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationConfiguration block(s) allowed")]
    public List<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock>? ApplicationConfiguration
    {
        get => GetProperty<List<AwsKinesisanalyticsv2ApplicationApplicationConfigurationBlock>>("application_configuration");
        set => this.WithProperty("application_configuration", value);
    }

    /// <summary>
    /// Block for cloudwatch_logging_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudwatchLoggingOptions block(s) allowed")]
    public List<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock>? CloudwatchLoggingOptions
    {
        get => GetProperty<List<AwsKinesisanalyticsv2ApplicationCloudwatchLoggingOptionsBlock>>("cloudwatch_logging_options");
        set => this.WithProperty("cloudwatch_logging_options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKinesisanalyticsv2ApplicationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsKinesisanalyticsv2ApplicationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
