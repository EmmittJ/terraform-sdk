using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for permissions in .
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
    [TerraformArgument("actions")]
    public TerraformList<string>? Actions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "actions").ResolveNodes(ctx));
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    [TerraformArgument("data_actions")]
    public TerraformSet<string>? DataActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "data_actions").ResolveNodes(ctx));
        set => SetArgument("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    [TerraformArgument("not_actions")]
    public TerraformList<string>? NotActions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "not_actions").ResolveNodes(ctx));
        set => SetArgument("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    [TerraformArgument("not_data_actions")]
    public TerraformSet<string>? NotDataActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "not_data_actions").ResolveNodes(ctx));
        set => SetArgument("not_data_actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_role_definition resource.
/// </summary>
public class AzurermRoleDefinition : TerraformResource
{
    public AzurermRoleDefinition(string name) : base("azurerm_role_definition", name)
    {
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    [TerraformArgument("assignable_scopes")]
    public TerraformList<string> AssignableScopes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "assignable_scopes").ResolveNodes(ctx));
        set => SetArgument("assignable_scopes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [TerraformArgument("role_definition_id")]
    public TerraformValue<string> RoleDefinitionId
    {
        get => new TerraformReference<string>(this, "role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    [TerraformArgument("scope")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("permissions")]
    public TerraformList<AzurermRoleDefinitionPermissionsBlock> Permissions { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermRoleDefinitionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    [TerraformArgument("role_definition_resource_id")]
    public TerraformValue<string> RoleDefinitionResourceId
    {
        get => new TerraformReference<string>(this, "role_definition_resource_id");
    }

}
