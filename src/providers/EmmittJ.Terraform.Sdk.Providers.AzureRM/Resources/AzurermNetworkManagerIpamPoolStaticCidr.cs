using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerIpamPoolStaticCidrTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_network_manager_ipam_pool_static_cidr resource.
/// </summary>
public class AzurermNetworkManagerIpamPoolStaticCidr : TerraformResource
{
    public AzurermNetworkManagerIpamPoolStaticCidr(string name) : base("azurerm_network_manager_ipam_pool_static_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("address_prefixes");
        SetOutput("id");
        SetOutput("ipam_pool_id");
        SetOutput("name");
        SetOutput("number_of_ip_addresses_to_allocate");
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public List<TerraformProperty<string>> AddressPrefixes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("address_prefixes");
        set => SetProperty("address_prefixes", value);
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
    /// The ipam_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpamPoolId is required")]
    public required TerraformProperty<string> IpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipam_pool_id");
        set => SetProperty("ipam_pool_id", value);
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
    /// The number_of_ip_addresses_to_allocate attribute.
    /// </summary>
    public TerraformProperty<string> NumberOfIpAddressesToAllocate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("number_of_ip_addresses_to_allocate");
        set => SetProperty("number_of_ip_addresses_to_allocate", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerIpamPoolStaticCidrTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
