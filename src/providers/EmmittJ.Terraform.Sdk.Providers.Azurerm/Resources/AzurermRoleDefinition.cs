using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for permissions in AzurermRoleDefinition.
/// Nesting mode: list
/// </summary>
public class AzurermRoleDefinitionPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    public TerraformList<string>? Actions
    {
        get => GetArgument<TerraformList<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    public TerraformSet<string>? DataActions
    {
        get => GetArgument<TerraformSet<string>>("data_actions");
        set => SetArgument("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public TerraformList<string>? NotActions
    {
        get => GetArgument<TerraformList<string>>("not_actions");
        set => SetArgument("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    public TerraformSet<string>? NotDataActions
    {
        get => GetArgument<TerraformSet<string>>("not_data_actions");
        set => SetArgument("not_data_actions", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermRoleDefinition.
/// Nesting mode: single
/// </summary>
public class AzurermRoleDefinitionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_role_definition Terraform resource.
/// Manages a azurerm_role_definition resource.
/// </summary>
public partial class AzurermRoleDefinition(string name) : TerraformResource("azurerm_role_definition", name)
{
    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public TerraformList<string>? AssignableScopes
    {
        get => GetArgument<TerraformList<string>>("assignable_scopes");
        set => SetArgument("assignable_scopes", value);
    }

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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The role_definition_id attribute.
    /// </summary>
    public TerraformValue<string>? RoleDefinitionId
    {
        get => GetArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    public TerraformValue<string> RoleDefinitionResourceId
        => AsReference("role_definition_resource_id");

    /// <summary>
    /// Permissions block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermRoleDefinitionPermissionsBlock>? Permissions
    {
        get => GetArgument<TerraformList<AzurermRoleDefinitionPermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRoleDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRoleDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
