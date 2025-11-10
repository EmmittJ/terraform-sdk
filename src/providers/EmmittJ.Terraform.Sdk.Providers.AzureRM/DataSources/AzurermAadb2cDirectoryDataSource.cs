using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAadb2cDirectoryDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_aadb2c_directory.
/// </summary>
public class AzurermAadb2cDirectoryDataSource : TerraformDataSource
{
    public AzurermAadb2cDirectoryDataSource(string name) : base("azurerm_aadb2c_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("billing_type");
        this.WithOutput("data_residency_location");
        this.WithOutput("effective_start_date");
        this.WithOutput("sku_name");
        this.WithOutput("tags");
        this.WithOutput("tenant_id");
    }

    /// <summary>
    /// Domain name of the B2C tenant, including onmicrosoft.com suffix.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAadb2cDirectoryDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAadb2cDirectoryDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    public TerraformExpression BillingType => this["billing_type"];

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides.
    /// </summary>
    public TerraformExpression DataResidencyLocation => this["data_residency_location"];

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    public TerraformExpression EffectiveStartDate => this["effective_start_date"];

    /// <summary>
    /// Billing SKU for the B2C tenant.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
