using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkManagerAdminRuleCollection.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerAdminRuleCollectionTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_network_manager_admin_rule_collection Terraform resource.
/// Manages a azurerm_network_manager_admin_rule_collection resource.
/// </summary>
public partial class AzurermNetworkManagerAdminRuleCollection(string name) : TerraformResource("azurerm_network_manager_admin_rule_collection", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The network_group_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupIds is required")]
    public TerraformList<string>? NetworkGroupIds
    {
        get => GetArgument<TerraformList<string>>("network_group_ids");
        set => SetArgument("network_group_ids", value);
    }

    /// <summary>
    /// The security_admin_configuration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityAdminConfigurationId is required")]
    public required TerraformValue<string> SecurityAdminConfigurationId
    {
        get => GetRequiredArgument<TerraformValue<string>>("security_admin_configuration_id");
        set => SetArgument("security_admin_configuration_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkManagerAdminRuleCollectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkManagerAdminRuleCollectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
