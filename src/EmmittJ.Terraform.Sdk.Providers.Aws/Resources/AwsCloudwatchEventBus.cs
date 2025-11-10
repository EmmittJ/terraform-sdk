using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for dead_letter_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventBusDeadLetterConfigBlock : TerraformBlock
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => WithProperty("arn", value);
    }

}

/// <summary>
/// Block type for log_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudwatchEventBusLogConfigBlock : TerraformBlock
{
    /// <summary>
    /// The include_detail attribute.
    /// </summary>
    public TerraformProperty<string>? IncludeDetail
    {
        get => GetProperty<TerraformProperty<string>>("include_detail");
        set => WithProperty("include_detail", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<string>? Level
    {
        get => GetProperty<TerraformProperty<string>>("level");
        set => WithProperty("level", value);
    }

}

/// <summary>
/// Manages a aws_cloudwatch_event_bus resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudwatchEventBus : TerraformResource
{
    public AwsCloudwatchEventBus(string name) : base("aws_cloudwatch_event_bus", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The event_source_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventSourceName
    {
        get => GetProperty<TerraformProperty<string>>("event_source_name");
        set => this.WithProperty("event_source_name", value);
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
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_identifier");
        set => this.WithProperty("kms_key_identifier", value);
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
    /// Block for dead_letter_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeadLetterConfig block(s) allowed")]
    public List<AwsCloudwatchEventBusDeadLetterConfigBlock>? DeadLetterConfig
    {
        get => GetProperty<List<AwsCloudwatchEventBusDeadLetterConfigBlock>>("dead_letter_config");
        set => this.WithProperty("dead_letter_config", value);
    }

    /// <summary>
    /// Block for log_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LogConfig block(s) allowed")]
    public List<AwsCloudwatchEventBusLogConfigBlock>? LogConfig
    {
        get => GetProperty<List<AwsCloudwatchEventBusLogConfigBlock>>("log_config");
        set => this.WithProperty("log_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
