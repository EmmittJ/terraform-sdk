using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_policy_definition_built_in.
/// </summary>
public class AzurermPolicyDefinitionBuiltInDataSource : TerraformDataSource
{
    public AzurermPolicyDefinitionBuiltInDataSource(string name) : base("azurerm_policy_definition_built_in", name)
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
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The management_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagementGroupName
    {
        get => GetProperty<TerraformProperty<string>>("management_group_name");
        set => this.WithProperty("management_group_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
