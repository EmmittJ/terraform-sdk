using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRoleManagementPolicyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermRoleManagementPolicyDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_role_management_policy Terraform data source.
/// Retrieves information about a azurerm_role_management_policy.
/// </summary>
public partial class AzurermRoleManagementPolicyDataSource(string name) : TerraformDataSource("azurerm_role_management_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the Azure Role to which this policy is assigned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The scope of the role to which this policy will apply
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The activation rules of the policy
    /// </summary>
    public TerraformList<TerraformMap<object>> ActivationRules
        => AsReference("activation_rules");

    /// <summary>
    /// The rules for active assignment of the policy
    /// </summary>
    public TerraformList<TerraformMap<object>> ActiveAssignmentRules
        => AsReference("active_assignment_rules");

    /// <summary>
    /// The Description of the policy
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The rules for eligible assignment of the policy
    /// </summary>
    public TerraformList<TerraformMap<object>> EligibleAssignmentRules
        => AsReference("eligible_assignment_rules");

    /// <summary>
    /// The name of the policy
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The notification rules of the policy
    /// </summary>
    public TerraformList<TerraformMap<object>> NotificationRules
        => AsReference("notification_rules");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRoleManagementPolicyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRoleManagementPolicyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
