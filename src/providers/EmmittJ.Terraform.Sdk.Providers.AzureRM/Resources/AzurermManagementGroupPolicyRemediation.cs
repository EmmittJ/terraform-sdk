using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<double>(this, "failure_percentage");
        set => SetArgument("failure_percentage", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location_filters attribute.
    /// </summary>
    public TerraformList<string>? LocationFilters
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "location_filters").ResolveNodes(ctx));
        set => SetArgument("location_filters", value);
    }

    /// <summary>
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => new TerraformReference<string>(this, "management_group_id");
        set => SetArgument("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parallel_deployments attribute.
    /// </summary>
    public TerraformValue<double>? ParallelDeployments
    {
        get => new TerraformReference<double>(this, "parallel_deployments");
        set => SetArgument("parallel_deployments", value);
    }

    /// <summary>
    /// The policy_assignment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyAssignmentId is required")]
    public required TerraformValue<string> PolicyAssignmentId
    {
        get => new TerraformReference<string>(this, "policy_assignment_id");
        set => SetArgument("policy_assignment_id", value);
    }

    /// <summary>
    /// The policy_definition_reference_id attribute.
    /// </summary>
    public TerraformValue<string>? PolicyDefinitionReferenceId
    {
        get => new TerraformReference<string>(this, "policy_definition_reference_id");
        set => SetArgument("policy_definition_reference_id", value);
    }

    /// <summary>
    /// The resource_count attribute.
    /// </summary>
    public TerraformValue<double>? ResourceCount
    {
        get => new TerraformReference<double>(this, "resource_count");
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
