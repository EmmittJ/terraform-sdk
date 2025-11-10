using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: list
/// </summary>
public class AzurermRoleDefinitionPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// The actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Actions
    {
        get => GetProperty<List<TerraformProperty<string>>>("actions");
        set => WithProperty("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("data_actions");
        set => WithProperty("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NotActions
    {
        get => GetProperty<List<TerraformProperty<string>>>("not_actions");
        set => WithProperty("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotDataActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("not_data_actions");
        set => WithProperty("not_data_actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_role_definition resource.
/// </summary>
public class AzurermRoleDefinition : TerraformResource
{
    public AzurermRoleDefinition(string name) : base("azurerm_role_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("role_definition_resource_id");
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AssignableScopes
    {
        get => GetProperty<List<TerraformProperty<string>>>("assignable_scopes");
        set => this.WithProperty("assignable_scopes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    public TerraformProperty<string>? RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermRoleDefinitionPermissionsBlock>? Permissions
    {
        get => GetProperty<List<AzurermRoleDefinitionPermissionsBlock>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRoleDefinitionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRoleDefinitionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    public TerraformExpression RoleDefinitionResourceId => this["role_definition_resource_id"];

}
