using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_signer_signing_profile.
/// </summary>
public partial class AwsSignerSigningProfileDataSource : TerraformDataSource
{
    public AwsSignerSigningProfileDataSource(string name) : base("aws_signer_signing_profile", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The platform_display_name attribute.
    /// </summary>
    [TerraformProperty("platform_display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformDisplayName { get; }

    /// <summary>
    /// The platform_id attribute.
    /// </summary>
    [TerraformProperty("platform_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PlatformId { get; }

    /// <summary>
    /// The revocation_record attribute.
    /// </summary>
    [TerraformProperty("revocation_record")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RevocationRecord { get; }

    /// <summary>
    /// The signature_validity_period attribute.
    /// </summary>
    [TerraformProperty("signature_validity_period")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SignatureValidityPeriod { get; }

    /// <summary>
    /// The signing_material attribute.
    /// </summary>
    [TerraformProperty("signing_material")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SigningMaterial { get; }

    /// <summary>
    /// The signing_parameters attribute.
    /// </summary>
    [TerraformProperty("signing_parameters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> SigningParameters { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Version { get; }

    /// <summary>
    /// The version_arn attribute.
    /// </summary>
    [TerraformProperty("version_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionArn { get; }

}
