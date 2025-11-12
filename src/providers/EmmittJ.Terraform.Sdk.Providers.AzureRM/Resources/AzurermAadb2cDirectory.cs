using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermAadb2cDirectoryTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_aadb2c_directory resource.
/// </summary>
public partial class AzurermAadb2cDirectory : TerraformResource
{
    public AzurermAadb2cDirectory(string name) : base("azurerm_aadb2c_directory", name)
    {
    }

    /// <summary>
    /// Country code of the B2C tenant. See https://aka.ms/B2CDataResidency for valid country codes.
    /// </summary>
    [TerraformProperty("country_code")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CountryCode { get; set; }

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides. See https://aka.ms/B2CDataResidency for more information.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataResidencyLocation is required")]
    [TerraformProperty("data_residency_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataResidencyLocation { get; set; }

    /// <summary>
    /// The initial display name of the B2C tenant.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DisplayName { get; set; }

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
    /// Billing SKU for the B2C tenant. See https://aka.ms/b2cBilling for more information.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermAadb2cDirectoryTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    [TerraformProperty("billing_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BillingType { get; }

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    [TerraformProperty("effective_start_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EffectiveStartDate { get; }

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TenantId { get; }

}
