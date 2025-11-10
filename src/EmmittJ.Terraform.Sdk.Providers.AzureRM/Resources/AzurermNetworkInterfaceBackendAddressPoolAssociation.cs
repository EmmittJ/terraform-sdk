using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceBackendAddressPoolAssociationTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_network_interface_backend_address_pool_association resource.
/// </summary>
public class AzurermNetworkInterfaceBackendAddressPoolAssociation : TerraformResource
{
    public AzurermNetworkInterfaceBackendAddressPoolAssociation(string name) : base("azurerm_network_interface_backend_address_pool_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    public required TerraformProperty<string> BackendAddressPoolId
    {
        get => GetProperty<TerraformProperty<string>>("backend_address_pool_id");
        set => this.WithProperty("backend_address_pool_id", value);
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
    /// The ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurationName is required")]
    public required TerraformProperty<string> IpConfigurationName
    {
        get => GetProperty<TerraformProperty<string>>("ip_configuration_name");
        set => this.WithProperty("ip_configuration_name", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetProperty<TerraformProperty<string>>("network_interface_id");
        set => this.WithProperty("network_interface_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkInterfaceBackendAddressPoolAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkInterfaceBackendAddressPoolAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
