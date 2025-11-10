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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("address_space_prefixes");
        SetOutput("virtual_network_id");
        SetOutput("allow_forwarded_traffic");
        SetOutput("allow_gateway_transit");
        SetOutput("allow_virtual_network_access");
        SetOutput("id");
        SetOutput("name");
        SetOutput("remote_address_space_prefixes");
        SetOutput("remote_virtual_network_id");
        SetOutput("resource_group_name");
        SetOutput("use_remote_gateways");
        SetOutput("workspace_id");
    }

    /// <summary>
    /// The allow_forwarded_traffic attribute.
    /// </summary>
    public TerraformProperty<bool> AllowForwardedTraffic
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_forwarded_traffic");
        set => SetProperty("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformProperty<bool> AllowGatewayTransit
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_gateway_transit");
        set => SetProperty("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformProperty<bool> AllowVirtualNetworkAccess
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allow_virtual_network_access");
        set => SetProperty("allow_virtual_network_access", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The remote_address_space_prefixes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteAddressSpacePrefixes is required")]
    public List<TerraformProperty<string>> RemoteAddressSpacePrefixes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("remote_address_space_prefixes");
        set => SetProperty("remote_address_space_prefixes", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RemoteVirtualNetworkId is required")]
    public required TerraformProperty<string> RemoteVirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("remote_virtual_network_id");
        set => SetProperty("remote_virtual_network_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformProperty<bool> UseRemoteGateways
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_remote_gateways");
        set => SetProperty("use_remote_gateways", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workspace_id");
        set => SetProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDatabricksVirtualNetworkPeeringTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
