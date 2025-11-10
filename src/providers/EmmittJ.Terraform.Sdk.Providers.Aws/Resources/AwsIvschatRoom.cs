using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for message_review_handler in .
/// Nesting mode: list
/// </summary>
public class AwsIvschatRoomMessageReviewHandlerBlock : TerraformBlock
{
    /// <summary>
    /// The fallback_result attribute.
    /// </summary>
    public TerraformProperty<string>? FallbackResult
    {
        set => SetProperty("fallback_result", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        set => SetProperty("uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsIvschatRoomTimeoutsBlock : TerraformBlock
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
/// Manages a aws_ivschat_room resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIvschatRoom : TerraformResource
{
    public AwsIvschatRoom(string name) : base("aws_ivschat_room", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("id");
        SetOutput("logging_configuration_identifiers");
        SetOutput("maximum_message_length");
        SetOutput("maximum_message_rate_per_second");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The logging_configuration_identifiers attribute.
    /// </summary>
    public List<TerraformProperty<string>> LoggingConfigurationIdentifiers
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("logging_configuration_identifiers");
        set => SetProperty("logging_configuration_identifiers", value);
    }

    /// <summary>
    /// The maximum_message_length attribute.
    /// </summary>
    public TerraformProperty<double> MaximumMessageLength
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_message_length");
        set => SetProperty("maximum_message_length", value);
    }

    /// <summary>
    /// The maximum_message_rate_per_second attribute.
    /// </summary>
    public TerraformProperty<double> MaximumMessageRatePerSecond
    {
        get => GetRequiredOutput<TerraformProperty<double>>("maximum_message_rate_per_second");
        set => SetProperty("maximum_message_rate_per_second", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for message_review_handler.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageReviewHandler block(s) allowed")]
    public List<AwsIvschatRoomMessageReviewHandlerBlock>? MessageReviewHandler
    {
        set => SetProperty("message_review_handler", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsIvschatRoomTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
