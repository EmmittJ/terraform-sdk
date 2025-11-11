using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_aws_versions.
/// </summary>
public partial class GoogleContainerAwsVersionsDataSource : TerraformDataSource
{
    public GoogleContainerAwsVersionsDataSource(string name) : base("google_container_aws_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The supported_regions attribute.
    /// </summary>
    [TerraformProperty("supported_regions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> SupportedRegions { get; }

    /// <summary>
    /// The valid_versions attribute.
    /// </summary>
    [TerraformProperty("valid_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> ValidVersions { get; }

}
