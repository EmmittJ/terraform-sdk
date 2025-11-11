using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_email_channel resource.
/// </summary>
public class AwsPinpointEmailChannel : TerraformResource
{
    public AwsPinpointEmailChannel(string name) : base("aws_pinpoint_email_channel", name)
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
    /// The configuration_set attribute.
    /// </summary>
    [TerraformPropertyName("configuration_set")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationSet { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    [TerraformPropertyName("from_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FromAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    [TerraformPropertyName("identity")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Identity { get; set; }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("orchestration_sending_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrchestrationSendingRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    [TerraformPropertyName("messages_per_second")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MessagesPerSecond => new TerraformReference(this, "messages_per_second");

}
