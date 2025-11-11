using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_sms_channel resource.
/// </summary>
public partial class AwsPinpointSmsChannel : TerraformResource
{
    public AwsPinpointSmsChannel(string name) : base("aws_pinpoint_sms_channel", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformProperty("application_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ApplicationId { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sender_id attribute.
    /// </summary>
    [TerraformProperty("sender_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SenderId { get; set; }

    /// <summary>
    /// The short_code attribute.
    /// </summary>
    [TerraformProperty("short_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ShortCode { get; set; }

    /// <summary>
    /// The promotional_messages_per_second attribute.
    /// </summary>
    [TerraformProperty("promotional_messages_per_second")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> PromotionalMessagesPerSecond { get; }

    /// <summary>
    /// The transactional_messages_per_second attribute.
    /// </summary>
    [TerraformProperty("transactional_messages_per_second")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> TransactionalMessagesPerSecond { get; }

}
