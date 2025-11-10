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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("address_prefix");
        this.WithOutput("address_prefixes");
        this.WithOutput("default_outbound_access_enabled");
        this.WithOutput("network_security_group_id");
        this.WithOutput("private_endpoint_network_policies");
        this.WithOutput("private_link_service_network_policies_enabled");
        this.WithOutput("route_table_id");
        this.WithOutput("service_endpoints");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The virtual_network_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkName is required")]
    public required TerraformProperty<string> VirtualNetworkName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("virtual_network_name");
        set => this.WithProperty("virtual_network_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSubnetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSubnetDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
