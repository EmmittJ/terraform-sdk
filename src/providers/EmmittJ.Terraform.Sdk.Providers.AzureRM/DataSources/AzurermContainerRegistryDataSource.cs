using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_registry.
/// </summary>
public class AzurermContainerRegistryDataSource : TerraformDataSource
{
    public AzurermContainerRegistryDataSource(string name) : base("azurerm_container_registry", name)
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
    public TerraformBlock<AzurermContainerRegistryDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The admin_enabled attribute.
    /// </summary>
    [TerraformPropertyName("admin_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AdminEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "admin_enabled");

    /// <summary>
    /// The admin_password attribute.
    /// </summary>
    [TerraformPropertyName("admin_password")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdminPassword => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_password");

    /// <summary>
    /// The admin_username attribute.
    /// </summary>
    [TerraformPropertyName("admin_username")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdminUsername => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "admin_username");

    /// <summary>
    /// The data_endpoint_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_endpoint_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DataEndpointEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "data_endpoint_enabled");

    /// <summary>
    /// The data_endpoint_host_names attribute.
    /// </summary>
    [TerraformPropertyName("data_endpoint_host_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> DataEndpointHostNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "data_endpoint_host_names");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The login_server attribute.
    /// </summary>
    [TerraformPropertyName("login_server")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LoginServer => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "login_server");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
