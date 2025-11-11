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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The license_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    [TerraformPropertyName("license_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> LicenseArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The beneficiary attribute.
    /// </summary>
    [TerraformPropertyName("beneficiary")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Beneficiary => new TerraformReference(this, "beneficiary");

    /// <summary>
    /// The consumption_configuration attribute.
    /// </summary>
    [TerraformPropertyName("consumption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ConsumptionConfiguration => new TerraformReference(this, "consumption_configuration");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The entitlements attribute.
    /// </summary>
    [TerraformPropertyName("entitlements")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Entitlements => new TerraformReference(this, "entitlements");

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    [TerraformPropertyName("home_region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HomeRegion => new TerraformReference(this, "home_region");

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Issuer => new TerraformReference(this, "issuer");

    /// <summary>
    /// The license_metadata attribute.
    /// </summary>
    [TerraformPropertyName("license_metadata")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> LicenseMetadata => new TerraformReference(this, "license_metadata");

    /// <summary>
    /// The license_name attribute.
    /// </summary>
    [TerraformPropertyName("license_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LicenseName => new TerraformReference(this, "license_name");

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    [TerraformPropertyName("product_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProductName => new TerraformReference(this, "product_name");

    /// <summary>
    /// The product_sku attribute.
    /// </summary>
    [TerraformPropertyName("product_sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProductSku => new TerraformReference(this, "product_sku");

    /// <summary>
    /// The received_metadata attribute.
    /// </summary>
    [TerraformPropertyName("received_metadata")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReceivedMetadata => new TerraformReference(this, "received_metadata");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The validity attribute.
    /// </summary>
    [TerraformPropertyName("validity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Validity => new TerraformReference(this, "validity");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

}
