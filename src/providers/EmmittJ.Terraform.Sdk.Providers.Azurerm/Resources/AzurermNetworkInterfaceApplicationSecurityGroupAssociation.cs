using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkInterfaceApplicationSecurityGroupAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkInterfaceApplicationSecurityGroupAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_network_interface_application_security_group_association Terraform resource.
/// Manages a azurerm_network_interface_application_security_group_association resource.
/// </summary>
public partial class AzurermNetworkInterfaceApplicationSecurityGroupAssociation(string name) : TerraformResource("azurerm_network_interface_application_security_group_association", name)
{
    /// <summary>
    /// The application_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSecurityGroupId is required")]
    public required TerraformValue<string> ApplicationSecurityGroupId
    {
        get => GetArgument<TerraformValue<string>>("application_security_group_id");
        set => SetArgument("application_security_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkInterfaceId is required")]
    public required TerraformValue<string> NetworkInterfaceId
    {
        get => GetArgument<TerraformValue<string>>("network_interface_id");
        set => SetArgument("network_interface_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkInterfaceApplicationSecurityGroupAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkInterfaceApplicationSecurityGroupAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
