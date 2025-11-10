using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMapsAccountDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_maps_account.
/// </summary>
public class AzurermMapsAccountDataSource : TerraformDataSource
{
    public AzurermMapsAccountDataSource(string name) : base("azurerm_maps_account", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMapsAccountDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("primary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrimaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "primary_access_key");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    [TerraformPropertyName("secondary_access_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecondaryAccessKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secondary_access_key");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The x_ms_client_id attribute.
    /// </summary>
    [TerraformPropertyName("x_ms_client_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> XMsClientId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "x_ms_client_id");

}
