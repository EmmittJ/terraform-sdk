using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_vpn_gateway.
/// </summary>
public class AzurermVpnGatewayDataSource : TerraformDataSource
{
    public AzurermVpnGatewayDataSource(string name) : base("azurerm_vpn_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bgp_settings");
        this.DeclareOutput("ip_configuration");
        this.DeclareOutput("location");
        this.DeclareOutput("scale_unit");
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_hub_id");
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
    /// The bgp_settings attribute.
    /// </summary>
    public TerraformExpression BgpSettings => this["bgp_settings"];

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The scale_unit attribute.
    /// </summary>
    public TerraformExpression ScaleUnit => this["scale_unit"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformExpression VirtualHubId => this["virtual_hub_id"];

}
