using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_policy_set_definition.
/// </summary>
public class AzurermPolicySetDefinitionDataSource : TerraformDataSource
{
    public AzurermPolicySetDefinitionDataSource(string name) : base("azurerm_policy_set_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("metadata");
        this.DeclareOutput("parameters");
        this.DeclareOutput("policy_definition_group");
        this.DeclareOutput("policy_definition_reference");
        this.DeclareOutput("policy_definitions");
        this.DeclareOutput("policy_type");
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
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The policy_definition_group attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitionGroup => this["policy_definition_group"];

    /// <summary>
    /// The policy_definition_reference attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitionReference => this["policy_definition_reference"];

    /// <summary>
    /// The policy_definitions attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitions => this["policy_definitions"];

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformExpression PolicyType => this["policy_type"];

}
