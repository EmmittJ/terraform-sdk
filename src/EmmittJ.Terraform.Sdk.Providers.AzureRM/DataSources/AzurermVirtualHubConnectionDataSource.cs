using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualHubConnectionDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_virtual_hub_connection.
/// </summary>
public class AzurermVirtualHubConnectionDataSource : TerraformDataSource
{
    public AzurermVirtualHubConnectionDataSource(string name) : base("azurerm_virtual_hub_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("internet_security_enabled");
        this.DeclareOutput("remote_virtual_network_id");
        this.DeclareOutput("routing");
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
    public AzurermVirtualHubConnectionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualHubConnectionDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The internet_security_enabled attribute.
    /// </summary>
    public TerraformExpression InternetSecurityEnabled => this["internet_security_enabled"];

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformExpression RemoteVirtualNetworkId => this["remote_virtual_network_id"];

    /// <summary>
    /// The routing attribute.
    /// </summary>
    public TerraformExpression Routing => this["routing"];

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public TerraformExpression VirtualHubId => this["virtual_hub_id"];

}
