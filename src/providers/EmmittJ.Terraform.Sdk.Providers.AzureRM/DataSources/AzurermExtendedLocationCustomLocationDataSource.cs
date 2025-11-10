using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_extended_location_custom_location.
/// </summary>
public class AzurermExtendedLocationCustomLocationDataSource : TerraformDataSource
{
    public AzurermExtendedLocationCustomLocationDataSource(string name) : base("azurerm_extended_location_custom_location", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [TerraformPropertyName("authentication")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Authentication => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "authentication");

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    [TerraformPropertyName("cluster_extension_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ClusterExtensionIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "cluster_extension_ids");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The host_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("host_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_resource_id");

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    [TerraformPropertyName("host_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HostType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "host_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Namespace => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "namespace");

}
