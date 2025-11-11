using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_license_configuration resource.
/// </summary>
public partial class AwsLicensemanagerLicenseConfiguration : TerraformResource
{
    public AwsLicensemanagerLicenseConfiguration(string name) : base("aws_licensemanager_license_configuration", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The license_count attribute.
    /// </summary>
    [TerraformProperty("license_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? LicenseCount { get; set; }

    /// <summary>
    /// The license_count_hard_limit attribute.
    /// </summary>
    [TerraformProperty("license_count_hard_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? LicenseCountHardLimit { get; set; }

    /// <summary>
    /// The license_counting_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseCountingType is required")]
    [TerraformProperty("license_counting_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseCountingType { get; set; }

    /// <summary>
    /// The license_rules attribute.
    /// </summary>
    [TerraformProperty("license_rules")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? LicenseRules { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OwnerAccountId { get; }

}
