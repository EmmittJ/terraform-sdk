using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_service_versions.
/// </summary>
public partial class AzurermKubernetesServiceVersionsDataSource : TerraformDataSource
{
    public AzurermKubernetesServiceVersionsDataSource(string name) : base("azurerm_kubernetes_service_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    [TerraformProperty("include_preview")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IncludePreview { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformProperty("version_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VersionPrefix { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformProperty("default_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultVersion { get; }

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformProperty("latest_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestVersion { get; }

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformProperty("versions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Versions { get; }

}
