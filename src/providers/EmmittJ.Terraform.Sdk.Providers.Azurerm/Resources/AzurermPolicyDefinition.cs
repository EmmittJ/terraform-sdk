using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPolicyDefinition.
/// Nesting mode: single
/// </summary>
public class AzurermPolicyDefinitionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_policy_definition Terraform resource.
/// Manages a azurerm_policy_definition resource.
/// </summary>
public partial class AzurermPolicyDefinition(string name) : TerraformResource("azurerm_policy_definition", name)
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The management_group_id attribute.
    /// </summary>
    public TerraformValue<string>? ManagementGroupId
    {
        get => GetArgument<TerraformValue<string>>("management_group_id");
        set => SetArgument("management_group_id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformValue<string>? Metadata
    {
        get => GetArgument<TerraformValue<string>>("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformValue<string>? Parameters
    {
        get => GetArgument<TerraformValue<string>>("parameters");
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    public TerraformValue<string>? PolicyRule
    {
        get => GetArgument<TerraformValue<string>>("policy_rule");
        set => SetArgument("policy_rule", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyType is required")]
    public required TerraformValue<string> PolicyType
    {
        get => GetArgument<TerraformValue<string>>("policy_type");
        set => SetArgument("policy_type", value);
    }

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    public TerraformList<string> RoleDefinitionIds
        => AsReference("role_definition_ids");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPolicyDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPolicyDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
