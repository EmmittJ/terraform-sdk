using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappPoolDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_netapp_pool.
/// </summary>
public class AzurermNetappPoolDataSource : TerraformDataSource
{
    public AzurermNetappPoolDataSource(string name) : base("azurerm_netapp_pool", name)
    {
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountName { get; set; }

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
    public TerraformBlock<AzurermNetappPoolDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cool_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> CoolAccessEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "cool_access_enabled");

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    [TerraformPropertyName("custom_throughput_mibps")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CustomThroughputMibps => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "custom_throughput_mibps");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EncryptionType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "encryption_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformPropertyName("service_level")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceLevel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_level");

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> SizeInTb => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "size_in_tb");

}
