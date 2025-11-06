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
    public bool? AllowForwardedTraffic
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_forwarded_traffic")?.Value;
        set => this.WithProperty("allow_forwarded_traffic", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_gateway_transit attribute.
    /// </summary>
    public bool? AllowGatewayTransit
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_gateway_transit")?.Value;
        set => this.WithProperty("allow_gateway_transit", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allow_virtual_network_access attribute.
    /// </summary>
    public bool? AllowVirtualNetworkAccess
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allow_virtual_network_access")?.Value;
        set => this.WithProperty("allow_virtual_network_access", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The remote_address_space_prefixes attribute.
    /// </summary>
    public List<string>? RemoteAddressSpacePrefixes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("remote_address_space_prefixes")?.Value;
        set => this.WithProperty("remote_address_space_prefixes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The remote_virtual_network_id attribute.
    /// </summary>
    public string? RemoteVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_virtual_network_id")?.Value;
        set => this.WithProperty("remote_virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The use_remote_gateways attribute.
    /// </summary>
    public bool? UseRemoteGateways
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_remote_gateways")?.Value;
        set => this.WithProperty("use_remote_gateways", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
