using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetappPoolDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermNetappPoolDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The cool_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cool_access_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> CoolAccessEnabled => new TerraformReference(this, "cool_access_enabled");

    /// <summary>
    /// The custom_throughput_mibps attribute.
    /// </summary>
    [TerraformPropertyName("custom_throughput_mibps")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CustomThroughputMibps => new TerraformReference(this, "custom_throughput_mibps");

    /// <summary>
    /// The encryption_type attribute.
    /// </summary>
    [TerraformPropertyName("encryption_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EncryptionType => new TerraformReference(this, "encryption_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The service_level attribute.
    /// </summary>
    [TerraformPropertyName("service_level")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceLevel => new TerraformReference(this, "service_level");

    /// <summary>
    /// The size_in_tb attribute.
    /// </summary>
    [TerraformPropertyName("size_in_tb")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> SizeInTb => new TerraformReference(this, "size_in_tb");

}
