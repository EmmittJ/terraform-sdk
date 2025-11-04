using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_policy_definition.
/// </summary>
public class AzurermPolicyDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicyDefinitionDataSource(string name) : base("azurerm_policy_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("metadata");
        this.DeclareOutput("mode");
        this.DeclareOutput("parameters");
        this.DeclareOutput("policy_rule");
        this.DeclareOutput("policy_type");
        this.DeclareOutput("role_definition_ids");
        this.DeclareOutput("type");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The management_group_name attribute.
    /// </summary>
    public string? ManagementGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("management_group_name")?.Value;
        set => this.WithProperty("management_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformExpression Mode => this["mode"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The policy_rule attribute.
    /// </summary>
    public TerraformExpression PolicyRule => this["policy_rule"];

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformExpression PolicyType => this["policy_type"];

    /// <summary>
    /// The role_definition_ids attribute.
    /// </summary>
    public TerraformExpression RoleDefinitionIds => this["role_definition_ids"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

}
