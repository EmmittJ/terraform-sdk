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
        SetOutput("backend_address_pool_id");
        SetOutput("id");
        SetOutput("ip_configuration_name");
        SetOutput("network_interface_id");
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    public required TerraformProperty<string> BackendAddressPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend_address_pool_id");
        set => SetProperty("backend_address_pool_id", value);
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
    /// The ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurationName is required")]
    public required TerraformProperty<string> IpConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_configuration_name");
        set => SetProperty("ip_configuration_name", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformProperty<string> NetworkInterfaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface_id");
        set => SetProperty("network_interface_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkInterfaceBackendAddressPoolAssociationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
