using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRoleDefinitionDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermRoleDefinitionDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a azurerm_role_definition Terraform data source.
/// Retrieves information about a azurerm_role_definition.
/// </summary>
public partial class AzurermRoleDefinitionDataSource(string name) : TerraformDataSource("azurerm_role_definition", name)
{
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
    public TerraformValue<string>? Name
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
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public TerraformList<string> AssignableScopes
        => AsReference("assignable_scopes");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Permissions
        => AsReference("permissions");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRoleDefinitionDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRoleDefinitionDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
