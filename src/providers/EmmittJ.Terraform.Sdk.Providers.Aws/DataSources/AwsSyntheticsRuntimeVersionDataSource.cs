using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_synthetics_runtime_version.
/// </summary>
public partial class AwsSyntheticsRuntimeVersionDataSource : TerraformDataSource
{
    public AwsSyntheticsRuntimeVersionDataSource(string name) : base("aws_synthetics_runtime_version", name)
    {
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    [TerraformProperty("latest")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Latest { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Prefix is required")]
    [TerraformProperty("prefix")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Prefix { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// The deprecation_date attribute.
    /// </summary>
    [TerraformProperty("deprecation_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeprecationDate { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The release_date attribute.
    /// </summary>
    [TerraformProperty("release_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ReleaseDate { get; }

    /// <summary>
    /// The version_name attribute.
    /// </summary>
    [TerraformProperty("version_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionName { get; }

}
