using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_licensemanager_received_license.
/// </summary>
public class AwsLicensemanagerReceivedLicenseDataSource : TerraformDataSource
{
    public AwsLicensemanagerReceivedLicenseDataSource(string name) : base("aws_licensemanager_received_license", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The license_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    [TerraformPropertyName("license_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LicenseArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The beneficiary attribute.
    /// </summary>
    [TerraformPropertyName("beneficiary")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Beneficiary => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "beneficiary");

    /// <summary>
    /// The consumption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("consumption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ConsumptionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "consumption_configuration");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The entitlements attribute.
    /// </summary>
    [TerraformPropertyName("entitlements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Entitlements => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "entitlements");

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    [TerraformPropertyName("home_region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HomeRegion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "home_region");

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Issuer => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "issuer");

    /// <summary>
    /// The license_metadata attribute.
    /// </summary>
    [TerraformPropertyName("license_metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> LicenseMetadata => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "license_metadata");

    /// <summary>
    /// The license_name attribute.
    /// </summary>
    [TerraformPropertyName("license_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LicenseName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "license_name");

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    [TerraformPropertyName("product_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProductName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_name");

    /// <summary>
    /// The product_sku attribute.
    /// </summary>
    [TerraformPropertyName("product_sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProductSku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_sku");

    /// <summary>
    /// The received_metadata attribute.
    /// </summary>
    [TerraformPropertyName("received_metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReceivedMetadata => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "received_metadata");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The validity attribute.
    /// </summary>
    [TerraformPropertyName("validity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Validity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "validity");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}
