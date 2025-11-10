using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsMacie2MemberTimeoutsBlock : ITerraformBlock
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
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

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
    /// The invitation_disable_email_notification attribute.
    /// </summary>
    [TerraformPropertyName("invitation_disable_email_notification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? InvitationDisableEmailNotification { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> Invite { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "invite");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Status { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsMacie2MemberTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    [TerraformPropertyName("administrator_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdministratorAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "administrator_account_id");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The invited_at attribute.
    /// </summary>
    [TerraformPropertyName("invited_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvitedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invited_at");

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformPropertyName("master_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_account_id");

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    [TerraformPropertyName("relationship_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RelationshipStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "relationship_status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformPropertyName("updated_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "updated_at");

}
