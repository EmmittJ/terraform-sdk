using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_private_dns_zone_virtual_network_link resource.
/// </summary>
public class AzurermPrivateDnsZoneVirtualNetworkLink : TerraformResource
{
    public AzurermPrivateDnsZoneVirtualNetworkLink(string name) : base("azurerm_private_dns_zone_virtual_network_link", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The private_dns_zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneName is required")]
    public required TerraformProperty<string> PrivateDnsZoneName
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_zone_name");
        set => this.WithProperty("private_dns_zone_name", value);
    }

    /// <summary>
    /// The registration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RegistrationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("registration_enabled");
        set => this.WithProperty("registration_enabled", value);
    }

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ResolutionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("resolution_policy");
        set => this.WithProperty("resolution_policy", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformProperty<string> VirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_id");
        set => this.WithProperty("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
