using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_network_interface_application_gateway_backend_address_pool_association Terraform resource.
/// Manages a azurerm_network_interface_application_gateway_backend_address_pool_association resource.
/// </summary>
public partial class AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociation(string name) : TerraformResource("azurerm_network_interface_application_gateway_backend_address_pool_association", name)
{
    /// <summary>
    /// The backend_address_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BackendAddressPoolId is required")]
    public required TerraformValue<string> BackendAddressPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("backend_address_pool_id");
        set => SetArgument("backend_address_pool_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ip_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpConfigurationName is required")]
    public required TerraformValue<string> IpConfigurationName
    {
        get => GetRequiredArgument<TerraformValue<string>>("ip_configuration_name");
        set => SetArgument("ip_configuration_name", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkInterfaceApplicationGatewayBackendAddressPoolAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
