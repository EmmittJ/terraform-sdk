using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualNetworkDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_virtual_network.
/// </summary>
public class AzurermVirtualNetworkDataSource : TerraformDataSource
{
    public AzurermVirtualNetworkDataSource(string name) : base("azurerm_virtual_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("address_space");
        this.WithOutput("dns_servers");
        this.WithOutput("guid");
        this.WithOutput("location");
        this.WithOutput("subnets");
        this.WithOutput("tags");
        this.WithOutput("vnet_peerings");
        this.WithOutput("vnet_peerings_addresses");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualNetworkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVirtualNetworkDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The address_space attribute.
    /// </summary>
    public TerraformExpression AddressSpace => this["address_space"];

    /// <summary>
    /// The dns_servers attribute.
    /// </summary>
    public TerraformExpression DnsServers => this["dns_servers"];

    /// <summary>
    /// The guid attribute.
    /// </summary>
    public TerraformExpression Guid => this["guid"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformExpression Subnets => this["subnets"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The vnet_peerings attribute.
    /// </summary>
    public TerraformExpression VnetPeerings => this["vnet_peerings"];

    /// <summary>
    /// The vnet_peerings_addresses attribute.
    /// </summary>
    public TerraformExpression VnetPeeringsAddresses => this["vnet_peerings_addresses"];

}
