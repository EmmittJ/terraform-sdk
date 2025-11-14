using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAadb2cDirectoryDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

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
    [TerraformArgument("domain_name")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAadb2cDirectoryDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    [TerraformArgument("billing_type")]
    public TerraformValue<string> BillingType
    {
        get => new TerraformReference<string>(this, "billing_type");
    }

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides.
    /// </summary>
    [TerraformArgument("data_residency_location")]
    public TerraformValue<string> DataResidencyLocation
    {
        get => new TerraformReference<string>(this, "data_residency_location");
    }

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    [TerraformArgument("effective_start_date")]
    public TerraformValue<string> EffectiveStartDate
    {
        get => new TerraformReference<string>(this, "effective_start_date");
    }

    /// <summary>
    /// Billing SKU for the B2C tenant.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

}
