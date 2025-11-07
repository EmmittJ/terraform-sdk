using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_pim_eligible_role_assignment resource.
/// </summary>
public class AzurermPimEligibleRoleAssignment : TerraformResource
{
    public AzurermPimEligibleRoleAssignment(string name) : base("azurerm_pim_eligible_role_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("principal_type");
    }

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        get => GetProperty<TerraformProperty<string>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// The condition_version attribute.
    /// </summary>
    public TerraformProperty<string>? ConditionVersion
    {
        get => GetProperty<TerraformProperty<string>>("condition_version");
        set => this.WithProperty("condition_version", value);
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
    /// The justification for this eligible role assignment
    /// </summary>
    public TerraformProperty<string>? Justification
    {
        get => GetProperty<TerraformProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// Object ID of the principal for this eligible role assignment
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => this.WithProperty("principal_id", value);
    }

    /// <summary>
    /// Role definition ID for this eligible role assignment
    /// </summary>
    public TerraformProperty<string>? RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// Scope for this eligible role assignment, should be a valid resource ID
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Type of principal to which the role will be assigned
    /// </summary>
    public TerraformExpression PrincipalType => this["principal_type"];

}
