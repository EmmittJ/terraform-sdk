using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("billing_type");
        this.DeclareOutput("data_residency_location");
        this.DeclareOutput("effective_start_date");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
        this.DeclareOutput("tenant_id");
    }

    /// <summary>
    /// Domain name of the B2C tenant, including onmicrosoft.com suffix.
    /// </summary>
    public TerraformProperty<string>? DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
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
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
