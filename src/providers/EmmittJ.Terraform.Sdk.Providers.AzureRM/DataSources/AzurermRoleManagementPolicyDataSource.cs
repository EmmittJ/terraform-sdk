using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyDataSourceTimeoutsBlock : TerraformBlock
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
        this.WithOutput("activation_rules");
        this.WithOutput("active_assignment_rules");
        this.WithOutput("description");
        this.WithOutput("eligible_assignment_rules");
        this.WithOutput("name");
        this.WithOutput("notification_rules");
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
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_definition_id");
        set => this.WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformProperty<string> Scope
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermRoleManagementPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermRoleManagementPolicyDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
