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
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Email { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    /// The master_id attribute.
    /// </summary>
    [TerraformPropertyName("master_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MasterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "master_id");

    /// <summary>
    /// The member_status attribute.
    /// </summary>
    [TerraformPropertyName("member_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MemberStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "member_status");

}
