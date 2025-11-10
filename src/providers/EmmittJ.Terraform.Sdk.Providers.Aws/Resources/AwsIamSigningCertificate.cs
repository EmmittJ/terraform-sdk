using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_signing_certificate resource.
/// </summary>
public class AwsIamSigningCertificate : TerraformResource
{
    public AwsIamSigningCertificate(string name) : base("aws_iam_signing_certificate", name)
    {
    }

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateBody is required")]
    [TerraformPropertyName("certificate_body")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CertificateBody { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserName { get; set; }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [TerraformPropertyName("certificate_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_id");

}
