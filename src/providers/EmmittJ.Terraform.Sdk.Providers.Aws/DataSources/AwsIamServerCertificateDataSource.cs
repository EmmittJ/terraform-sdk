using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_server_certificate.
/// </summary>
public class AwsIamServerCertificateDataSource : TerraformDataSource
{
    public AwsIamServerCertificateDataSource(string name) : base("aws_iam_server_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformPropertyName("latest")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Latest { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NamePrefix { get; set; }

    /// <summary>
    /// The path_prefix attribute.
    /// </summary>
    [TerraformPropertyName("path_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PathPrefix { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_body attribute.
    /// </summary>
    [TerraformPropertyName("certificate_body")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateBody => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_body");

    /// <summary>
    /// The certificate_chain attribute.
    /// </summary>
    [TerraformPropertyName("certificate_chain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateChain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_chain");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformPropertyName("expiration_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ExpirationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "expiration_date");

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformPropertyName("path")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Path => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path");

    /// <summary>
    /// The upload_date attribute.
    /// </summary>
    [TerraformPropertyName("upload_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UploadDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "upload_date");

}
