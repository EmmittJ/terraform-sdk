using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGuarddutyMemberTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_guardduty_member resource.
/// </summary>
public class AwsGuarddutyMember : TerraformResource
{
    public AwsGuarddutyMember(string name) : base("aws_guardduty_member", name)
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
    /// The detector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DetectorId is required")]
    [TerraformPropertyName("detector_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DetectorId { get; set; }

    /// <summary>
    /// The disable_email_notification attribute.
    /// </summary>
    [TerraformPropertyName("disable_email_notification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableEmailNotification { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    [TerraformPropertyName("invitation_message")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InvitationMessage { get; set; }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    [TerraformPropertyName("invite")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Invite { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsGuarddutyMemberTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    [TerraformPropertyName("relationship_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RelationshipStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "relationship_status");

}
