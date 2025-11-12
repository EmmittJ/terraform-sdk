using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsMacie2MemberTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_macie2_member resource.
/// </summary>
public partial class AwsMacie2Member : TerraformResource
{
    public AwsMacie2Member(string name) : base("aws_macie2_member", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The invitation_disable_email_notification attribute.
    /// </summary>
    [TerraformProperty("invitation_disable_email_notification")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? InvitationDisableEmailNotification { get; set; }

    /// <summary>
    /// The invitation_message attribute.
    /// </summary>
    [TerraformProperty("invitation_message")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InvitationMessage { get; set; }

    /// <summary>
    /// The invite attribute.
    /// </summary>
    [TerraformProperty("invite")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Invite { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Status { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsMacie2MemberTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The administrator_account_id attribute.
    /// </summary>
    [TerraformProperty("administrator_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdministratorAccountId { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The invited_at attribute.
    /// </summary>
    [TerraformProperty("invited_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InvitedAt { get; }

    /// <summary>
    /// The master_account_id attribute.
    /// </summary>
    [TerraformProperty("master_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MasterAccountId { get; }

    /// <summary>
    /// The relationship_status attribute.
    /// </summary>
    [TerraformProperty("relationship_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RelationshipStatus { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
