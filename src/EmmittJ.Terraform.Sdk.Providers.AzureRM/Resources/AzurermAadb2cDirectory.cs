using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_aadb2c_directory resource.
/// </summary>
public class AzurermAadb2cDirectory : TerraformResource
{
    public AzurermAadb2cDirectory(string name) : base("azurerm_aadb2c_directory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("billing_type");
        this.DeclareOutput("effective_start_date");
        this.DeclareOutput("tenant_id");
    }

    /// <summary>
    /// Country code of the B2C tenant. See https://aka.ms/B2CDataResidency for valid country codes.
    /// </summary>
    public TerraformProperty<string>? CountryCode
    {
        get => GetProperty<TerraformProperty<string>>("country_code");
        set => this.WithProperty("country_code", value);
    }

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides. See https://aka.ms/B2CDataResidency for more information.
    /// </summary>
    public TerraformProperty<string>? DataResidencyLocation
    {
        get => GetProperty<TerraformProperty<string>>("data_residency_location");
        set => this.WithProperty("data_residency_location", value);
    }

    /// <summary>
    /// The initial display name of the B2C tenant.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Billing SKU for the B2C tenant. See https://aka.ms/b2cBilling for more information.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type of billing for the B2C tenant. Possible values include: `MAU` or `Auths`.
    /// </summary>
    public TerraformExpression BillingType => this["billing_type"];

    /// <summary>
    /// The date from which the billing type took effect. May not be populated until after the first billing cycle.
    /// </summary>
    public TerraformExpression EffectiveStartDate => this["effective_start_date"];

    /// <summary>
    /// The Tenant ID for the B2C tenant.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
