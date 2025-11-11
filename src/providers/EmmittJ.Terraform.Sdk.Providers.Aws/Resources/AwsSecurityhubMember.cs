using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securityhub_member resource.
/// </summary>
public class AwsSecurityhubMember : TerraformResource
{
    public AwsSecurityhubMember(string name) : base("aws_securityhub_member", name)
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
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The invite attribute.
    /// </summary>
    [TerraformPropertyName("invite")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Invite { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The master_id attribute.
    /// </summary>
    [TerraformPropertyName("master_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MasterId => new TerraformReference(this, "master_id");

    /// <summary>
    /// The member_status attribute.
    /// </summary>
    [TerraformPropertyName("member_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MemberStatus => new TerraformReference(this, "member_status");

}
