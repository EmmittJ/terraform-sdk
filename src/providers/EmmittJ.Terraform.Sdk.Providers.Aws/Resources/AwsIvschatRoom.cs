using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for message_review_handler in .
/// Nesting mode: list
/// </summary>
public partial class AwsIvschatRoomMessageReviewHandlerBlock() : TerraformBlock("message_review_handler")
{
    /// <summary>
    /// The fallback_result attribute.
    /// </summary>
    [TerraformProperty("fallback_result")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> FallbackResult { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [TerraformProperty("uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Uri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsIvschatRoomTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_ivschat_room resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIvschatRoom : TerraformResource
{
    public AwsIvschatRoom(string name) : base("aws_ivschat_room", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The logging_configuration_identifiers attribute.
    /// </summary>
    [TerraformProperty("logging_configuration_identifiers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LoggingConfigurationIdentifiers { get; set; }

    /// <summary>
    /// The maximum_message_length attribute.
    /// </summary>
    [TerraformProperty("maximum_message_length")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaximumMessageLength { get; set; }

    /// <summary>
    /// The maximum_message_rate_per_second attribute.
    /// </summary>
    [TerraformProperty("maximum_message_rate_per_second")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaximumMessageRatePerSecond { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for message_review_handler.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MessageReviewHandler block(s) allowed")]
    [TerraformProperty("message_review_handler")]
    public TerraformList<AwsIvschatRoomMessageReviewHandlerBlock> MessageReviewHandler { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsIvschatRoomTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
