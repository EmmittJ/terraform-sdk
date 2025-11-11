using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_detective_member resource.
/// </summary>
public class AwsDetectiveMember : TerraformResource
{
    public AwsDetectiveMember(string name) : base("aws_detective_member", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformPropertyName("account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    [TerraformPropertyName("disable_email_notification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DisableEmailNotification { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformPropertyName("email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    [TerraformPropertyName("graph_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GraphArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformPropertyName("message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The administrator_id attribute.
    /// </summary>
    [TerraformPropertyName("administrator_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdministratorId => new TerraformReference(this, "administrator_id");

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    [TerraformPropertyName("disabled_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisabledReason => new TerraformReference(this, "disabled_reason");

    /// <summary>
    /// The invited_time attribute.
    /// </summary>
    [TerraformPropertyName("invited_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InvitedTime => new TerraformReference(this, "invited_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The updated_time attribute.
    /// </summary>
    [TerraformPropertyName("updated_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdatedTime => new TerraformReference(this, "updated_time");

    /// <summary>
    /// The volume_usage_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("volume_usage_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VolumeUsageInBytes => new TerraformReference(this, "volume_usage_in_bytes");

}
