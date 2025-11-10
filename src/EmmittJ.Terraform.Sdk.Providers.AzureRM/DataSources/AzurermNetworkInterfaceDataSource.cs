using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_network_interface.
/// </summary>
public class AzurermNetworkInterfaceDataSource : TerraformDataSource
{
    public AzurermNetworkInterfaceDataSource(string name) : base("azurerm_network_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("accelerated_networking_enabled");
        this.DeclareOutput("applied_dns_servers");
        this.DeclareOutput("dns_servers");
        this.DeclareOutput("internal_dns_name_label");
        this.DeclareOutput("ip_configuration");
        this.DeclareOutput("ip_forwarding_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("mac_address");
        this.DeclareOutput("network_security_group_id");
        this.DeclareOutput("private_ip_address");
        this.DeclareOutput("private_ip_addresses");
        this.DeclareOutput("tags");
        this.DeclareOutput("virtual_machine_id");
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
    public AzurermNetworkInterfaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkInterfaceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The accelerated_networking_enabled attribute.
    /// </summary>
    public TerraformExpression AcceleratedNetworkingEnabled => this["accelerated_networking_enabled"];

    /// <summary>
    /// The applied_dns_servers attribute.
    /// </summary>
    public TerraformExpression AppliedDnsServers => this["applied_dns_servers"];

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformExpression DnsServers => this["dns_servers"];

    /// <summary>
    /// The internal_dns_name_label attribute.
    /// </summary>
    public TerraformExpression InternalDnsNameLabel => this["internal_dns_name_label"];

    /// <summary>
    /// The ip_configuration attribute.
    /// </summary>
    public TerraformExpression IpConfiguration => this["ip_configuration"];

    /// <summary>
    /// The ip_forwarding_enabled attribute.
    /// </summary>
    public TerraformExpression IpForwardingEnabled => this["ip_forwarding_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The mac_address attribute.
    /// </summary>
    public TerraformExpression MacAddress => this["mac_address"];

    /// <summary>
    /// The network_security_group_id attribute.
    /// </summary>
    public TerraformExpression NetworkSecurityGroupId => this["network_security_group_id"];

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddress => this["private_ip_address"];

    /// <summary>
    /// The private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PrivateIpAddresses => this["private_ip_addresses"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformExpression VirtualMachineId => this["virtual_machine_id"];

}
