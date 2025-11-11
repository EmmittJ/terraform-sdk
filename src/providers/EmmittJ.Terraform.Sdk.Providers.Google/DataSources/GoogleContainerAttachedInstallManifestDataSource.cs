using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_container_attached_install_manifest.
/// </summary>
public partial class GoogleContainerAttachedInstallManifestDataSource : TerraformDataSource
{
    public GoogleContainerAttachedInstallManifestDataSource(string name) : base("google_container_attached_install_manifest", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The platform_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformVersion is required")]
    [TerraformProperty("platform_version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PlatformVersion { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Project is required")]
    [TerraformProperty("project")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The manifest attribute.
    /// </summary>
    [TerraformProperty("manifest")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Manifest { get; }

}
