using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPolicyAssignmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("description");
        this.WithOutput("display_name");
        this.WithOutput("enforce");
        this.WithOutput("identity");
        this.WithOutput("location");
        this.WithOutput("metadata");
        this.WithOutput("non_compliance_message");
        this.WithOutput("not_scopes");
        this.WithOutput("parameters");
        this.WithOutput("policy_definition_id");
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The scope_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScopeId is required")]
    public required TerraformProperty<string> ScopeId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope_id");
        set => this.WithProperty("scope_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPolicyAssignmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPolicyAssignmentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
