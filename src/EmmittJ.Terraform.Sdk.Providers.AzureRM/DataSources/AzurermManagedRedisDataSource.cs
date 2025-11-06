using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_managed_redis.
/// </summary>
public class AzurermManagedRedisDataSource : TerraformDataSource
{
    public AzurermManagedRedisDataSource(string name) : base("azurerm_managed_redis", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("customer_managed_key");
        this.DeclareOutput("default_database");
        this.DeclareOutput("high_availability_enabled");
        this.DeclareOutput("hostname");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The customer_managed_key attribute.
    /// </summary>
    public TerraformExpression CustomerManagedKey => this["customer_managed_key"];

    /// <summary>
    /// The default_database attribute.
    /// </summary>
    public TerraformExpression DefaultDatabase => this["default_database"];

    /// <summary>
    /// The high_availability_enabled attribute.
    /// </summary>
    public TerraformExpression HighAvailabilityEnabled => this["high_availability_enabled"];

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformExpression Hostname => this["hostname"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
