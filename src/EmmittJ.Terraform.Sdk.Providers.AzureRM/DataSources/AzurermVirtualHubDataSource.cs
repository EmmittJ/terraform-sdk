using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_virtual_hub.
/// </summary>
public class AzurermVirtualHubDataSource : TerraformDataSource
{
    public AzurermVirtualHubDataSource(string name) : base("azurerm_virtual_hub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address_prefix");
        this.DeclareOutput("default_route_table_id");
        this.DeclareOutput("location");
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_router_asn");
        this.DeclareOutput("virtual_router_ips");
        this.DeclareOutput("virtual_wan_id");
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
    /// The address_prefix attribute.
    /// </summary>
    public TerraformExpression AddressPrefix => this["address_prefix"];

    /// <summary>
    /// The default_route_table_id attribute.
    /// </summary>
    public TerraformExpression DefaultRouteTableId => this["default_route_table_id"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_router_asn attribute.
    /// </summary>
    public TerraformExpression VirtualRouterAsn => this["virtual_router_asn"];

    /// <summary>
    /// The virtual_router_ips attribute.
    /// </summary>
    public TerraformExpression VirtualRouterIps => this["virtual_router_ips"];

    /// <summary>
    /// The virtual_wan_id attribute.
    /// </summary>
    public TerraformExpression VirtualWanId => this["virtual_wan_id"];

}
