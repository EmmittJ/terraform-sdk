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
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    [TerraformPropertyName("disable_email_notification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableEmailNotification { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformPropertyName("email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EmailAddress { get; set; }

    /// <summary>
    /// The graph_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GraphArn is required")]
    [TerraformPropertyName("graph_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GraphArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformPropertyName("message")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Message { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The administrator_id attribute.
    /// </summary>
    [TerraformPropertyName("administrator_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdministratorId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "administrator_id");

    /// <summary>
    /// The disabled_reason attribute.
    /// </summary>
    [TerraformPropertyName("disabled_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisabledReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "disabled_reason");

    /// <summary>
    /// The invited_time attribute.
    /// </summary>
    [TerraformPropertyName("invited_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvitedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invited_time");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The updated_time attribute.
    /// </summary>
    [TerraformPropertyName("updated_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_time");

    /// <summary>
    /// The volume_usage_in_bytes attribute.
    /// </summary>
    [TerraformPropertyName("volume_usage_in_bytes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VolumeUsageInBytes => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "volume_usage_in_bytes");

}
