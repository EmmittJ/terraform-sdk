using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubRouteTableDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_virtual_hub_route_table.
/// </summary>
public class AzurermVirtualHubRouteTableDataSource : TerraformDataSource
{
    public AzurermVirtualHubRouteTableDataSource(string name) : base("azurerm_virtual_hub_route_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("labels");
        this.DeclareOutput("route");
        this.DeclareOutput("virtual_hub_id");
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
    /// The virtual_hub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualHubName is required")]
    public required TerraformProperty<string> VirtualHubName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_hub_name");
        set => this.WithProperty("virtual_hub_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualHubRouteTableDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualHubRouteTableDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The labels attribute.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The route attribute.
    /// </summary>
    public TerraformExpression Route => this["route"];

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformExpression VirtualHubId => this["virtual_hub_id"];

}
