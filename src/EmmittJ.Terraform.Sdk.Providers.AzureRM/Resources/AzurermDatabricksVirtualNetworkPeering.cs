using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<bool>? AllowForwardedTraffic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_forwarded_traffic");
        set => this.WithProperty("allow_forwarded_traffic", value);
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowGatewayTransit
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_gateway_transit");
        set => this.WithProperty("allow_gateway_transit", value);
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowVirtualNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_virtual_network_access");
        set => this.WithProperty("allow_virtual_network_access", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The remote_address_space_prefixes attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? RemoteAddressSpacePrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("remote_address_space_prefixes");
        set => this.WithProperty("remote_address_space_prefixes", value);
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_virtual_network_id");
        set => this.WithProperty("remote_virtual_network_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The use_remote_gateways attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseRemoteGateways
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_remote_gateways");
        set => this.WithProperty("use_remote_gateways", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
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
