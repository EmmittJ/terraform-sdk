using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The include_preview attribute.
    /// </summary>
    [TerraformPropertyName("include_preview")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IncludePreview { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The version_prefix attribute.
    /// </summary>
    [TerraformPropertyName("version_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VersionPrefix { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermKubernetesServiceVersionsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    [TerraformPropertyName("default_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_version");

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    [TerraformPropertyName("latest_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_version");

    /// <summary>
    /// The versions attribute.
    /// </summary>
    [TerraformPropertyName("versions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> Versions => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "versions");

}
