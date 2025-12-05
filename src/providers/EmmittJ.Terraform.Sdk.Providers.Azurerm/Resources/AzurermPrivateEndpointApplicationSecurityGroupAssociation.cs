using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateEndpointApplicationSecurityGroupAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateEndpointApplicationSecurityGroupAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_private_endpoint_application_security_group_association Terraform resource.
/// Manages a azurerm_private_endpoint_application_security_group_association resource.
/// </summary>
public partial class AzurermPrivateEndpointApplicationSecurityGroupAssociation(string name) : TerraformResource("azurerm_private_endpoint_application_security_group_association", name)
{
    /// <summary>
    /// The application_security_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationSecurityGroupId is required")]
    public required TerraformValue<string> ApplicationSecurityGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("application_security_group_id");
        set => SetArgument("application_security_group_id", value);
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
    /// The private_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateEndpointId is required")]
    public required TerraformValue<string> PrivateEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("private_endpoint_id");
        set => SetArgument("private_endpoint_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateEndpointApplicationSecurityGroupAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateEndpointApplicationSecurityGroupAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
