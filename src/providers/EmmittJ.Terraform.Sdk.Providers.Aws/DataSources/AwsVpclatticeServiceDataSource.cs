using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_service.
/// </summary>
public class AwsVpclatticeServiceDataSource : TerraformDataSource
{
    public AwsVpclatticeServiceDataSource(string name) : base("aws_vpclattice_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    [TerraformPropertyName("service_identifier")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ServiceIdentifier { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_identifier");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [TerraformPropertyName("auth_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AuthType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "auth_type");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformPropertyName("certificate_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CertificateArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "certificate_arn");

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_name");

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    [TerraformPropertyName("dns_entry")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DnsEntry => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dns_entry");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
