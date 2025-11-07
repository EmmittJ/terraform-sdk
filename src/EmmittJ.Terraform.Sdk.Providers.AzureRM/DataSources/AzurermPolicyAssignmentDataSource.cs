using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_policy_assignment.
/// </summary>
public class AzurermPolicyAssignmentDataSource : TerraformDataSource
{
    public AzurermPolicyAssignmentDataSource(string name) : base("azurerm_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("display_name");
        this.DeclareOutput("enforce");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("metadata");
        this.DeclareOutput("non_compliance_message");
        this.DeclareOutput("not_scopes");
        this.DeclareOutput("parameters");
        this.DeclareOutput("policy_definition_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The scope_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScopeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope_id");
        set => this.WithProperty("scope_id", value);
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
    /// The enforce attribute.
    /// </summary>
    public TerraformExpression Enforce => this["enforce"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The non_compliance_message attribute.
    /// </summary>
    public TerraformExpression NonComplianceMessage => this["non_compliance_message"];

    /// <summary>
    /// The not_scopes attribute.
    /// </summary>
    public TerraformExpression NotScopes => this["not_scopes"];

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformExpression Parameters => this["parameters"];

    /// <summary>
    /// The policy_definition_id attribute.
    /// </summary>
    public TerraformExpression PolicyDefinitionId => this["policy_definition_id"];

}
