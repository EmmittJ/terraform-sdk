using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAadb2cDirectoryDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_aadb2c_directory.
/// </summary>
public partial class AzurermAadb2cDirectoryDataSource : TerraformDataSource
{
    public AzurermAadb2cDirectoryDataSource(string name) : base("azurerm_aadb2c_directory", name)
    {
    }

    /// <summary>
    /// Domain name of the B2C tenant, including onmicrosoft.com suffix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAadb2cDirectoryDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    [TerraformProperty("billing_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BillingType { get; }

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides.
    /// </summary>
    [TerraformProperty("data_residency_location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DataResidencyLocation { get; }

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    [TerraformProperty("effective_start_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveStartDate { get; }

    /// <summary>
    /// Billing SKU for the B2C tenant.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
