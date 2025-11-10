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
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// The data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DataActions
    {
        set => SetProperty("data_actions", value);
    }

    /// <summary>
    /// The not_actions attribute.
    /// </summary>
    public List<TerraformProperty<string>>? NotActions
    {
        set => SetProperty("not_actions", value);
    }

    /// <summary>
    /// The not_data_actions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotDataActions
    {
        set => SetProperty("not_data_actions", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("role_definition_resource_id");
        SetOutput("assignable_scopes");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("role_definition_id");
        SetOutput("scope");
    }

    /// <summary>
    /// The assignable_scopes attribute.
    /// </summary>
    public List<TerraformProperty<string>> AssignableScopes
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("assignable_scopes");
        set => SetProperty("assignable_scopes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    public TerraformProperty<string> RoleDefinitionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_definition_id");
        set => SetProperty("role_definition_id", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scope");
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermRoleDefinitionPermissionsBlock>? Permissions
    {
        set => SetProperty("permissions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRoleDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    public TerraformExpression RoleDefinitionResourceId => this["role_definition_resource_id"];

}
