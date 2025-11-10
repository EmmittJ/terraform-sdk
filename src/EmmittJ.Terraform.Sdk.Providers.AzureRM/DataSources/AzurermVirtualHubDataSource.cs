using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubDataSourceTimeoutsBlock : TerraformBlock
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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualHubDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
