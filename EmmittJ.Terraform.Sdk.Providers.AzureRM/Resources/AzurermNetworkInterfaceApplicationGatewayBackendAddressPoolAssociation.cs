using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_interface_application_gateway_backend_address_pool_association resource.
/// </summary>
public class AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociation : TerraformResource
{
    public AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociation(string name) : base("azurerm_network_interface_application_gateway_backend_address_pool_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    public string? BackendAddressPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backend_address_pool_id")?.Value;
        set => this.WithProperty("backend_address_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_configuration_name attribute.
    /// </summary>
    public string? IpConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_configuration_name")?.Value;
        set => this.WithProperty("ip_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public string? NetworkInterfaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_interface_id")?.Value;
        set => this.WithProperty("network_interface_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
