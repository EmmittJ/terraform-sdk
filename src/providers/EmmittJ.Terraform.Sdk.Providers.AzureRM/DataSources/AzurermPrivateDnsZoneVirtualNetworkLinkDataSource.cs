using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_private_dns_zone_virtual_network_link.
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSource(string name) : base("azurerm_private_dns_zone_virtual_network_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("registration_enabled");
        this.WithOutput("resolution_policy");
        this.WithOutput("tags");
        this.WithOutput("virtual_network_id");
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
    /// The private_dns_zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneName is required")]
    public required TerraformProperty<string> PrivateDnsZoneName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_dns_zone_name");
        set => this.WithProperty("private_dns_zone_name", value);
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
    public AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPrivateDnsZoneVirtualNetworkLinkDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The registration_enabled attribute.
    /// </summary>
    public TerraformExpression RegistrationEnabled => this["registration_enabled"];

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public TerraformExpression ResolutionPolicy => this["resolution_policy"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    public TerraformExpression VirtualNetworkId => this["virtual_network_id"];

}
