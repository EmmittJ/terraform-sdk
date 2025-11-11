using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_sms_channel resource.
/// </summary>
public class AwsPinpointSmsChannel : TerraformResource
{
    public AwsPinpointSmsChannel(string name) : base("aws_pinpoint_sms_channel", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The sender_id attribute.
    /// </summary>
    [TerraformPropertyName("sender_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SenderId { get; set; }

    /// <summary>
    /// The short_code attribute.
    /// </summary>
    [TerraformPropertyName("short_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ShortCode { get; set; }

    /// <summary>
    /// The promotional_messages_per_second attribute.
    /// </summary>
    [TerraformPropertyName("promotional_messages_per_second")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> PromotionalMessagesPerSecond => new TerraformReference(this, "promotional_messages_per_second");

    /// <summary>
    /// The transactional_messages_per_second attribute.
    /// </summary>
    [TerraformPropertyName("transactional_messages_per_second")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TransactionalMessagesPerSecond => new TerraformReference(this, "transactional_messages_per_second");

}
