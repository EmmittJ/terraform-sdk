using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_certificate resource.
/// </summary>
public class AwsTransferCertificate : TerraformResource
{
    public AwsTransferCertificate(string name) : base("aws_transfer_certificate", name)
    {
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Certificate is required")]
    [TerraformPropertyName("certificate")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Certificate { get; set; }

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CertificateChain { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformPropertyName("private_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

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
    /// The usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Usage is required")]
    [TerraformPropertyName("usage")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Usage { get; set; }

    /// <summary>
    /// The active_date attribute.
    /// </summary>
    [TerraformPropertyName("active_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ActiveDate => new TerraformReference(this, "active_date");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CertificateId => new TerraformReference(this, "certificate_id");

    /// <summary>
    /// The inactive_date attribute.
    /// </summary>
    [TerraformPropertyName("inactive_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InactiveDate => new TerraformReference(this, "inactive_date");

}
