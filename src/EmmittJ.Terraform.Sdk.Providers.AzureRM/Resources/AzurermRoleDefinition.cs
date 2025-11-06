using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public List<string>? AssignableScopes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("assignable_scopes")?.Value;
        set => this.WithProperty("assignable_scopes", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    public string? RoleDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_definition_id")?.Value;
        set => this.WithProperty("role_definition_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_definition_resource_id attribute.
    /// </summary>
    public TerraformExpression RoleDefinitionResourceId => this["role_definition_resource_id"];

}
