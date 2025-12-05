using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in AwsCloudformationStackSetInstance.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetInstanceDeploymentTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deployment_targets";

    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    public TerraformValue<string>? AccountFilterType
    {
        get => GetArgument<TerraformValue<string>>("account_filter_type");
        set => SetArgument("account_filter_type", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformSet<string>? Accounts
    {
        get => GetArgument<TerraformSet<string>>("accounts");
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    public TerraformValue<string>? AccountsUrl
    {
        get => GetArgument<TerraformValue<string>>("accounts_url");
        set => SetArgument("accounts_url", value);
    }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    public TerraformSet<string>? OrganizationalUnitIds
    {
        get => GetArgument<TerraformSet<string>>("organizational_unit_ids");
        set => SetArgument("organizational_unit_ids", value);
    }

}


/// <summary>
/// Block type for operation_preferences in AwsCloudformationStackSetInstance.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetInstanceOperationPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "operation_preferences";

    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    public TerraformValue<string>? ConcurrencyMode
    {
        get => GetArgument<TerraformValue<string>>("concurrency_mode");
        set => SetArgument("concurrency_mode", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformValue<double>? FailureToleranceCount
    {
        get => GetArgument<TerraformValue<double>>("failure_tolerance_count");
        set => SetArgument("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FailureTolerancePercentage
    {
        get => GetArgument<TerraformValue<double>>("failure_tolerance_percentage");
        set => SetArgument("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentCount
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_count");
        set => SetArgument("max_concurrent_count", value);
    }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentPercentage
    {
        get => GetArgument<TerraformValue<double>>("max_concurrent_percentage");
        set => SetArgument("max_concurrent_percentage", value);
    }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    public TerraformValue<string>? RegionConcurrencyType
    {
        get => GetArgument<TerraformValue<string>>("region_concurrency_type");
        set => SetArgument("region_concurrency_type", value);
    }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    public TerraformList<string>? RegionOrder
    {
        get => GetArgument<TerraformList<string>>("region_order");
        set => SetArgument("region_order", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCloudformationStackSetInstance.
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackSetInstanceTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_cloudformation_stack_set_instance Terraform resource.
/// Manages a aws_cloudformation_stack_set_instance resource.
/// </summary>
public partial class AwsCloudformationStackSetInstance(string name) : TerraformResource("aws_cloudformation_stack_set_instance", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? CreateReference("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformValue<string>? CallAs
    {
        get => GetArgument<TerraformValue<string>>("call_as");
        set => SetArgument("call_as", value);
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
    /// The parameter_overrides attribute.
    /// </summary>
    public TerraformMap<string>? ParameterOverrides
    {
        get => GetArgument<TerraformMap<string>>("parameter_overrides");
        set => SetArgument("parameter_overrides", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The retain_stack attribute.
    /// </summary>
    public TerraformValue<bool>? RetainStack
    {
        get => GetArgument<TerraformValue<bool>>("retain_stack");
        set => SetArgument("retain_stack", value);
    }

    /// <summary>
    /// The stack_set_instance_region attribute.
    /// </summary>
    public TerraformValue<string> StackSetInstanceRegion
    {
        get => GetArgument<TerraformValue<string>>("stack_set_instance_region") ?? CreateReference("stack_set_instance_region");
        set => SetArgument("stack_set_instance_region", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    public required TerraformValue<string> StackSetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stack_set_name");
        set => SetArgument("stack_set_name", value);
    }

    /// <summary>
    /// The organizational_unit_id attribute.
    /// </summary>
    public TerraformValue<string> OrganizationalUnitId
        => CreateReference("organizational_unit_id");

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public TerraformValue<string> StackId
        => CreateReference("stack_id");

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformList<TerraformMap<object>> StackInstanceSummaries
        => CreateReference("stack_instance_summaries");

    /// <summary>
    /// DeploymentTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    public TerraformList<AwsCloudformationStackSetInstanceDeploymentTargetsBlock>? DeploymentTargets
    {
        get => GetArgument<TerraformList<AwsCloudformationStackSetInstanceDeploymentTargetsBlock>>("deployment_targets");
        set => SetArgument("deployment_targets", value);
    }

    /// <summary>
    /// OperationPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    public TerraformList<AwsCloudformationStackSetInstanceOperationPreferencesBlock>? OperationPreferences
    {
        get => GetArgument<TerraformList<AwsCloudformationStackSetInstanceOperationPreferencesBlock>>("operation_preferences");
        set => SetArgument("operation_preferences", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudformationStackSetInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudformationStackSetInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
