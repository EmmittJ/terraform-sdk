using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAadb2cDirectoryDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_aadb2c_directory.
/// </summary>
public class AzurermAadb2cDirectoryDataSource : TerraformDataSource
{
    public AzurermAadb2cDirectoryDataSource(string name) : base("azurerm_aadb2c_directory", name)
    {
    }

    /// <summary>
    /// Domain name of the B2C tenant, including onmicrosoft.com suffix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformPropertyName("domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    public TerraformBlock<AzurermAadb2cDirectoryDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    [TerraformPropertyName("billing_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BillingType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "billing_type");

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides.
    /// </summary>
    [TerraformPropertyName("data_residency_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DataResidencyLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "data_residency_location");

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    [TerraformPropertyName("effective_start_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EffectiveStartDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "effective_start_date");

    /// <summary>
    /// Billing SKU for the B2C tenant.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_id");

}
