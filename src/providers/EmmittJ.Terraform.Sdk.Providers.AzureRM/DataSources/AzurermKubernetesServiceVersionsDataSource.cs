using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_kubernetes_service_versions.
/// </summary>
public class AzurermKubernetesServiceVersionsDataSource : TerraformDataSource
{
    public AzurermKubernetesServiceVersionsDataSource(string name) : base("azurerm_kubernetes_service_versions", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    [TerraformPropertyName("include_preview")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludePreview { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformPropertyName("version_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VersionPrefix { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultVersion => new TerraformReference(this, "default_version");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestVersion => new TerraformReference(this, "latest_version");

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformPropertyName("versions")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Versions => new TerraformReference(this, "versions");

}
