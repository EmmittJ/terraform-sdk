using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_licensemanager_grant_accepter resource.
/// </summary>
public partial class AwsLicensemanagerGrantAccepter : TerraformResource
{
    public AwsLicensemanagerGrantAccepter(string name) : base("aws_licensemanager_grant_accepter", name)
    {
    }

    /// <summary>
    /// Amazon Resource Name (ARN) of the grant.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrantArn is required")]
    [TerraformProperty("grant_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GrantArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Allowed operations for the grant.
    /// </summary>
    [TerraformProperty("allowed_operations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> AllowedOperations { get; }

    /// <summary>
    /// Home Region of the grant.
    /// </summary>
    [TerraformProperty("home_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> HomeRegion { get; }

    /// <summary>
    /// License ARN.
    /// </summary>
    [TerraformProperty("license_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LicenseArn { get; }

    /// <summary>
    /// Name of the grant.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Parent ARN.
    /// </summary>
    [TerraformProperty("parent_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ParentArn { get; }

    /// <summary>
    /// The grantee principal ARN.
    /// </summary>
    [TerraformProperty("principal")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Principal { get; }

    /// <summary>
    /// GrantAccepter status.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// GrantAccepter version.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

}
