using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_licensemanager_received_license.
/// </summary>
public partial class AwsLicensemanagerReceivedLicenseDataSource : TerraformDataSource
{
    public AwsLicensemanagerReceivedLicenseDataSource(string name) : base("aws_licensemanager_received_license", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    [TerraformProperty("license_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The beneficiary attribute.
    /// </summary>
    [TerraformProperty("beneficiary")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Beneficiary { get; }

    /// <summary>
    /// The consumption_configuration attribute.
    /// </summary>
    [TerraformProperty("consumption_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ConsumptionConfiguration { get; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The entitlements attribute.
    /// </summary>
    [TerraformProperty("entitlements")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> Entitlements { get; }

    /// <summary>
    /// The home_region attribute.
    /// </summary>
    [TerraformProperty("home_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HomeRegion { get; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformProperty("issuer")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Issuer { get; }

    /// <summary>
    /// The license_metadata attribute.
    /// </summary>
    [TerraformProperty("license_metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> LicenseMetadata { get; }

    /// <summary>
    /// The license_name attribute.
    /// </summary>
    [TerraformProperty("license_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LicenseName { get; }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    [TerraformProperty("product_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProductName { get; }

    /// <summary>
    /// The product_sku attribute.
    /// </summary>
    [TerraformProperty("product_sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProductSku { get; }

    /// <summary>
    /// The received_metadata attribute.
    /// </summary>
    [TerraformProperty("received_metadata")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReceivedMetadata { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The validity attribute.
    /// </summary>
    [TerraformProperty("validity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Validity { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
