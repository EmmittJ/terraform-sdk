using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_grant resource.
/// </summary>
public partial class AwsLicensemanagerGrant : TerraformResource
{
    public AwsLicensemanagerGrant(string name) : base("aws_licensemanager_grant", name)
    {
    }

    /// <summary>
    /// Allowed operations for the grant. This is a subset of the allowed operations on the license.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedOperations is required")]
    [TerraformProperty("allowed_operations")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AllowedOperations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// License ARN.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LicenseArn is required")]
    [TerraformProperty("license_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LicenseArn { get; set; }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The grantee principal ARN. The target account for the grant in the form of the ARN for an account principal of the root user.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    [TerraformProperty("home_region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HomeRegion { get; }

    /// <summary>
    /// Parent ARN.
    /// </summary>
    [TerraformProperty("parent_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParentArn { get; }

    /// <summary>
    /// Grant status.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// Grant version.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

}
