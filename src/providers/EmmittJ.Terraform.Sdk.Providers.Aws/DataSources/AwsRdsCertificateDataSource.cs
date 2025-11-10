using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_rds_certificate.
/// </summary>
public class AwsRdsCertificateDataSource : TerraformDataSource
{
    public AwsRdsCertificateDataSource(string name) : base("aws_rds_certificate", name)
    {
    }

    /// <summary>
    /// The default_for_new_launches attribute.
    /// </summary>
    [TerraformPropertyName("default_for_new_launches")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DefaultForNewLaunches { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The latest_valid_till attribute.
    /// </summary>
    [TerraformPropertyName("latest_valid_till")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? LatestValidTill { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [TerraformPropertyName("certificate_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_type");

    /// <summary>
    /// The customer_override attribute.
    /// </summary>
    [TerraformPropertyName("customer_override")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CustomerOverride => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "customer_override");

    /// <summary>
    /// The customer_override_valid_till attribute.
    /// </summary>
    [TerraformPropertyName("customer_override_valid_till")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomerOverrideValidTill => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "customer_override_valid_till");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformPropertyName("thumbprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Thumbprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "thumbprint");

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    [TerraformPropertyName("valid_from")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidFrom => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_from");

    /// <summary>
    /// The valid_till attribute.
    /// </summary>
    [TerraformPropertyName("valid_till")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ValidTill => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "valid_till");

}
