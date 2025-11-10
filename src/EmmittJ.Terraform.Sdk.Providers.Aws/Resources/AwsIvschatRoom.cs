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
        get => GetProperty<TerraformProperty<string>>("fallback_result");
        set => WithProperty("fallback_result", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformProperty<string>? Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
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
        this.DeclareOutput("arn");
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
    /// The logging_configuration_identifiers attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LoggingConfigurationIdentifiers
    {
        get => GetProperty<List<TerraformProperty<string>>>("logging_configuration_identifiers");
        set => this.WithProperty("logging_configuration_identifiers", value);
    }

    /// <summary>
    /// The maximum_message_length attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumMessageLength
    {
        get => GetProperty<TerraformProperty<double>>("maximum_message_length");
        set => this.WithProperty("maximum_message_length", value);
    }

    /// <summary>
    /// The maximum_message_rate_per_second attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumMessageRatePerSecond
    {
        get => GetProperty<TerraformProperty<double>>("maximum_message_rate_per_second");
        set => this.WithProperty("maximum_message_rate_per_second", value);
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
    /// Block for message_review_handler.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageReviewHandler block(s) allowed")]
    public List<AwsIvschatRoomMessageReviewHandlerBlock>? MessageReviewHandler
    {
        get => GetProperty<List<AwsIvschatRoomMessageReviewHandlerBlock>>("message_review_handler");
        set => this.WithProperty("message_review_handler", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsIvschatRoomTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsIvschatRoomTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
