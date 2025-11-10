using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_databricks_virtual_network_peering resource.
/// </summary>
public class AzurermDatabricksVirtualNetworkPeering : TerraformResource
{
    public AzurermDatabricksVirtualNetworkPeering(string name) : base("azurerm_databricks_virtual_network_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address_space_prefixes");
        this.DeclareOutput("virtual_network_id");
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowForwardedTraffic
    {
        get => GetProperty<TerraformProperty<bool>>("allow_forwarded_traffic");
        set => this.WithProperty("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowGatewayTransit
    {
        get => GetProperty<TerraformProperty<bool>>("allow_gateway_transit");
        set => this.WithProperty("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowVirtualNetworkAccess
    {
        get => GetProperty<TerraformProperty<bool>>("allow_virtual_network_access");
        set => this.WithProperty("allow_virtual_network_access", value);
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
    /// The remote_address_space_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressSpacePrefixes is required")]
    public List<TerraformProperty<string>>? RemoteAddressSpacePrefixes
    {
        get => GetProperty<List<TerraformProperty<string>>>("remote_address_space_prefixes");
        set => this.WithProperty("remote_address_space_prefixes", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformProperty<string> RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("remote_virtual_network_id");
        set => this.WithProperty("remote_virtual_network_id", value);
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
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformProperty<bool>? UseRemoteGateways
    {
        get => GetProperty<TerraformProperty<bool>>("use_remote_gateways");
        set => this.WithProperty("use_remote_gateways", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The address_space_prefixes attribute.
    /// </summary>
    public TerraformExpression AddressSpacePrefixes => this["address_space_prefixes"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

}
