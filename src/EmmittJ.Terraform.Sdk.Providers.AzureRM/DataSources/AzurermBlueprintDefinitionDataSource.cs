using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_blueprint_definition.
/// </summary>
public class AzurermBlueprintDefinitionDataSource : TerraformDataSource
{
    public AzurermBlueprintDefinitionDataSource(string name) : base("azurerm_blueprint_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("last_modified");
        this.DeclareOutput("target_scope");
        this.DeclareOutput("time_created");
        this.DeclareOutput("versions");
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
    /// The scope_id attribute.
    /// </summary>
    public string? ScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope_id")?.Value;
        set => this.WithProperty("scope_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformExpression DisplayName => this["display_name"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

    /// <summary>
    /// The target_scope attribute.
    /// </summary>
    public TerraformExpression TargetScope => this["target_scope"];

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformExpression TimeCreated => this["time_created"];

    /// <summary>
    /// The versions attribute.
    /// </summary>
    public TerraformExpression Versions => this["versions"];

}
