using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in AwsCloudformationStackInstances.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackInstancesDeploymentTargetsBlock : TerraformBlock
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
/// Block type for operation_preferences in AwsCloudformationStackInstances.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackInstancesOperationPreferencesBlock : TerraformBlock
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
/// Block type for timeouts in AwsCloudformationStackInstances.
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackInstancesTimeoutsBlock : TerraformBlock
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
/// Represents a aws_cloudformation_stack_instances Terraform resource.
/// Manages a aws_cloudformation_stack_instances resource.
/// </summary>
public partial class AwsCloudformationStackInstances(string name) : TerraformResource("aws_cloudformation_stack_instances", name)
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformSet<string> Accounts
    {
        get => GetArgument<TerraformSet<string>>("accounts") ?? AsReference("accounts");
        set => SetArgument("accounts", value);
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string> Regions
    {
        get => GetArgument<TerraformSet<string>>("regions") ?? AsReference("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The retain_stacks attribute.
    /// </summary>
    public TerraformValue<bool>? RetainStacks
    {
        get => GetArgument<TerraformValue<bool>>("retain_stacks");
        set => SetArgument("retain_stacks", value);
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
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformList<TerraformMap<object>> StackInstanceSummaries
        => AsReference("stack_instance_summaries");

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformValue<string> StackSetId
        => AsReference("stack_set_id");

    /// <summary>
    /// DeploymentTargets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    public TerraformList<AwsCloudformationStackInstancesDeploymentTargetsBlock>? DeploymentTargets
    {
        get => GetArgument<TerraformList<AwsCloudformationStackInstancesDeploymentTargetsBlock>>("deployment_targets");
        set => SetArgument("deployment_targets", value);
    }

    /// <summary>
    /// OperationPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    public TerraformList<AwsCloudformationStackInstancesOperationPreferencesBlock>? OperationPreferences
    {
        get => GetArgument<TerraformList<AwsCloudformationStackInstancesOperationPreferencesBlock>>("operation_preferences");
        set => SetArgument("operation_preferences", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCloudformationStackInstancesTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCloudformationStackInstancesTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
