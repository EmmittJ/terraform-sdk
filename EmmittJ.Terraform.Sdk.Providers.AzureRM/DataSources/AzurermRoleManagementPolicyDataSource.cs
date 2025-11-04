using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_role_management_policy.
/// </summary>
public class AzurermRoleManagementPolicyDataSource : TerraformDataSource
{
    public AzurermRoleManagementPolicyDataSource(string name) : base("azurerm_role_management_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("activation_rules");
        this.DeclareOutput("active_assignment_rules");
        this.DeclareOutput("description");
        this.DeclareOutput("eligible_assignment_rules");
        this.DeclareOutput("name");
        this.DeclareOutput("notification_rules");
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
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    public string? RoleDefinitionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_definition_id")?.Value;
        set => this.WithProperty("role_definition_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    public string? Scope
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scope")?.Value;
        set => this.WithProperty("scope", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The activation rules of the policy
    /// </summary>
    public TerraformExpression ActivationRules => this["activation_rules"];

    /// <summary>
    /// The rules for active assignment of the policy
    /// </summary>
    public TerraformExpression ActiveAssignmentRules => this["active_assignment_rules"];

    /// <summary>
    /// The Description of the policy
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The rules for eligible assignment of the policy
    /// </summary>
    public TerraformExpression EligibleAssignmentRules => this["eligible_assignment_rules"];

    /// <summary>
    /// The name of the policy
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The notification rules of the policy
    /// </summary>
    public TerraformExpression NotificationRules => this["notification_rules"];

}
