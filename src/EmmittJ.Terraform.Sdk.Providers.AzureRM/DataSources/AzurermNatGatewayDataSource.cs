using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_nat_gateway.
/// </summary>
public class AzurermNatGatewayDataSource : TerraformDataSource
{
    public AzurermNatGatewayDataSource(string name) : base("azurerm_nat_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("idle_timeout_in_minutes");
        this.DeclareOutput("location");
        this.DeclareOutput("resource_guid");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
        this.DeclareOutput("zones");
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
    /// The public_ip_address_ids attribute.
    /// </summary>
    public List<string>? PublicIpAddressIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("public_ip_address_ids")?.Value;
        set => this.WithProperty("public_ip_address_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The public_ip_prefix_ids attribute.
    /// </summary>
    public List<string>? PublicIpPrefixIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("public_ip_prefix_ids")?.Value;
        set => this.WithProperty("public_ip_prefix_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformExpression IdleTimeoutInMinutes => this["idle_timeout_in_minutes"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The resource_guid attribute.
    /// </summary>
    public TerraformExpression ResourceGuid => this["resource_guid"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformExpression Zones => this["zones"];

}
