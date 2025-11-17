using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAadb2cDirectoryDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_aadb2c_directory Terraform data source.
/// Retrieves information about a azurerm_aadb2c_directory.
/// </summary>
public partial class AzurermAadb2cDirectoryDataSource(string name) : TerraformDataSource("azurerm_aadb2c_directory", name)
{
    /// <summary>
    /// Domain name of the B2C tenant, including onmicrosoft.com suffix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    public TerraformValue<string> BillingType
    {
        get => new TerraformReference<string>(this, "billing_type");
    }

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides.
    /// </summary>
    public TerraformValue<string> DataResidencyLocation
    {
        get => new TerraformReference<string>(this, "data_residency_location");
    }

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    public TerraformValue<string> EffectiveStartDate
    {
        get => new TerraformReference<string>(this, "effective_start_date");
    }

    /// <summary>
    /// Billing SKU for the B2C tenant.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAadb2cDirectoryDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAadb2cDirectoryDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
