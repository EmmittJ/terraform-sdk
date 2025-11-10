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
        SetOutput("id");
        SetOutput("name");
        SetOutput("private_dns_zone_name");
        SetOutput("registration_enabled");
        SetOutput("resolution_policy");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("virtual_network_id");
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
    /// The private_dns_zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateDnsZoneName is required")]
    public required TerraformProperty<string> PrivateDnsZoneName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_dns_zone_name");
        set => SetProperty("private_dns_zone_name", value);
    }

    /// <summary>
    /// The registration_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RegistrationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("registration_enabled");
        set => SetProperty("registration_enabled", value);
    }

    /// <summary>
    /// The resolution_policy attribute.
    /// </summary>
    public TerraformProperty<string> ResolutionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resolution_policy");
        set => SetProperty("resolution_policy", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualNetworkId is required")]
    public required TerraformProperty<string> VirtualNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("virtual_network_id");
        set => SetProperty("virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPrivateDnsZoneVirtualNetworkLinkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
