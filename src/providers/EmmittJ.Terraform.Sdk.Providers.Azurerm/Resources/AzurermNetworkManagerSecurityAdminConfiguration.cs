using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerSecurityAdminConfiguration.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerSecurityAdminConfigurationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_network_manager_security_admin_configuration Terraform resource.
/// Manages a azurerm_network_manager_security_admin_configuration resource.
/// </summary>
public partial class AzurermNetworkManagerSecurityAdminConfiguration(string name) : TerraformResource("azurerm_network_manager_security_admin_configuration", name)
{
    /// <summary>
    /// The apply_on_network_intent_policy_based_services attribute.
    /// </summary>
    public TerraformList<string>? ApplyOnNetworkIntentPolicyBasedServices
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "apply_on_network_intent_policy_based_services").ResolveNodes(ctx));
        set => SetArgument("apply_on_network_intent_policy_based_services", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformValue<string> NetworkManagerId
    {
        get => new TerraformReference<string>(this, "network_manager_id");
        set => SetArgument("network_manager_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerSecurityAdminConfigurationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerSecurityAdminConfigurationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
