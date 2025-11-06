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
    public string? CountryCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("country_code")?.Value;
        set => this.WithProperty("country_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Location in which the B2C tenant is hosted and data resides. See https://aka.ms/B2CDataResidency for more information.
    /// </summary>
    public string? DataResidencyLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_residency_location")?.Value;
        set => this.WithProperty("data_residency_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The initial display name of the B2C tenant.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Domain name of the B2C tenant, including onmicrosoft.com suffix.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Billing SKU for the B2C tenant. See https://aka.ms/b2cBilling for more information.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
