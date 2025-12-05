using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagementGroupPolicyRemediation.
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupPolicyRemediationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_management_group_policy_remediation Terraform resource.
/// Manages a azurerm_management_group_policy_remediation resource.
/// </summary>
public partial class AzurermManagementGroupPolicyRemediation(string name) : TerraformResource("azurerm_management_group_policy_remediation", name)
{
    /// <summary>
    /// The failure_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FailurePercentage
    {
        get => GetArgument<TerraformValue<double>>("failure_percentage");
        set => SetArgument("failure_percentage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location_filters attribute.
    /// </summary>
    public TerraformList<string>? LocationFilters
    {
        get => GetArgument<TerraformList<string>>("location_filters");
        set => SetArgument("location_filters", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("management_group_id");
        set => SetArgument("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    public TerraformValue<double>? ParallelDeployments
    {
        get => GetArgument<TerraformValue<double>>("parallel_deployments");
        set => SetArgument("parallel_deployments", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformValue<string> PolicyAssignmentId
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_assignment_id");
        set => SetArgument("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformValue<string>? PolicyDefinitionReferenceId
    {
        get => GetArgument<TerraformValue<string>>("policy_definition_reference_id");
        set => SetArgument("policy_definition_reference_id", value);
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformValue<double>? ResourceCount
    {
        get => GetArgument<TerraformValue<double>>("resource_count");
        set => SetArgument("resource_count", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupPolicyRemediationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupPolicyRemediationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
