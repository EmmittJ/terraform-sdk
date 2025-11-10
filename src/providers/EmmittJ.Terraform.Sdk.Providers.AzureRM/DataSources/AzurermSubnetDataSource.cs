using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSubnetDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_subnet.
/// </summary>
public class AzurermSubnetDataSource : TerraformDataSource
{
    public AzurermSubnetDataSource(string name) : base("azurerm_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_prefix");
        SetOutput("address_prefixes");
        SetOutput("default_outbound_access_enabled");
        SetOutput("network_security_group_id");
        SetOutput("private_endpoint_network_policies");
        SetOutput("private_link_service_network_policies_enabled");
        SetOutput("route_table_id");
        SetOutput("service_endpoints");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("virtual_network_name");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformProperty<string> VirtualNetworkName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_name");
        set => SetProperty("virtual_network_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubnetDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public TerraformExpression AddressPrefix => this["address_prefix"];

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformExpression AddressPrefixes => this["address_prefixes"];

    /// <summary>
    /// The default_outbound_access_enabled attribute.
    /// </summary>
    public TerraformExpression DefaultOutboundAccessEnabled => this["default_outbound_access_enabled"];

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformExpression NetworkSecurityGroupId => this["network_security_group_id"];

    /// <summary>
    /// The private_endpoint_network_policies attribute.
    /// </summary>
    public TerraformExpression PrivateEndpointNetworkPolicies => this["private_endpoint_network_policies"];

    /// <summary>
    /// The private_link_service_network_policies_enabled attribute.
    /// </summary>
    public TerraformExpression PrivateLinkServiceNetworkPoliciesEnabled => this["private_link_service_network_policies_enabled"];

    /// <summary>
    /// The route_table_id attribute.
    /// </summary>
    public TerraformExpression RouteTableId => this["route_table_id"];

    /// <summary>
    /// The service_endpoints attribute.
    /// </summary>
    public TerraformExpression ServiceEndpoints => this["service_endpoints"];

}
