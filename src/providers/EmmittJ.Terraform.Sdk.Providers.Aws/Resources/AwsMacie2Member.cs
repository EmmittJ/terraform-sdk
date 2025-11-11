using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2MemberTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_macie2_member resource.
/// </summary>
public class AwsMacie2Member : TerraformResource
{
    public AwsMacie2Member(string name) : base("aws_macie2_member", name)
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
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The invitation_disable_email_notification attribute.
    /// </summary>
    [TerraformPropertyName("invitation_disable_email_notification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? InvitationDisableEmailNotification { get; set; }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    [TerraformPropertyName("invitation_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InvitationMessage { get; set; }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    [TerraformPropertyName("invite")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> Invite { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMacie2MemberTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    [TerraformPropertyName("administrator_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AdministratorAccountId => new TerraformReference(this, "administrator_account_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The invited_at attribute.
    /// </summary>
    [TerraformPropertyName("invited_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InvitedAt => new TerraformReference(this, "invited_at");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformPropertyName("master_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterAccountId => new TerraformReference(this, "master_account_id");

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    [TerraformPropertyName("relationship_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RelationshipStatus => new TerraformReference(this, "relationship_status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdatedAt => new TerraformReference(this, "updated_at");

}
