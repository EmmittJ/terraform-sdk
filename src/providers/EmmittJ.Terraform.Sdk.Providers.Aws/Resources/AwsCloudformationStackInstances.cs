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
        get => new TerraformReference<string>(this, "account_filter_type");
        set => SetArgument("account_filter_type", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformSet<string>? Accounts
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accounts").ResolveNodes(ctx));
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    public TerraformValue<string>? AccountsUrl
    {
        get => new TerraformReference<string>(this, "accounts_url");
        set => SetArgument("accounts_url", value);
    }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    public TerraformSet<string>? OrganizationalUnitIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "organizational_unit_ids").ResolveNodes(ctx));
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
        get => new TerraformReference<string>(this, "concurrency_mode");
        set => SetArgument("concurrency_mode", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformValue<double>? FailureToleranceCount
    {
        get => new TerraformReference<double>(this, "failure_tolerance_count");
        set => SetArgument("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformValue<double>? FailureTolerancePercentage
    {
        get => new TerraformReference<double>(this, "failure_tolerance_percentage");
        set => SetArgument("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentCount
    {
        get => new TerraformReference<double>(this, "max_concurrent_count");
        set => SetArgument("max_concurrent_count", value);
    }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrentPercentage
    {
        get => new TerraformReference<double>(this, "max_concurrent_percentage");
        set => SetArgument("max_concurrent_percentage", value);
    }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    public TerraformValue<string>? RegionConcurrencyType
    {
        get => new TerraformReference<string>(this, "region_concurrency_type");
        set => SetArgument("region_concurrency_type", value);
    }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    public TerraformList<string>? RegionOrder
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "region_order").ResolveNodes(ctx));
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accounts").ResolveNodes(ctx));
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformValue<string>? CallAs
    {
        get => new TerraformReference<string>(this, "call_as");
        set => SetArgument("call_as", value);
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
    /// The parameter_overrides attribute.
    /// </summary>
    public TerraformMap<string>? ParameterOverrides
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameter_overrides").ResolveNodes(ctx));
        set => SetArgument("parameter_overrides", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string> Regions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The retain_stacks attribute.
    /// </summary>
    public TerraformValue<bool>? RetainStacks
    {
        get => new TerraformReference<bool>(this, "retain_stacks");
        set => SetArgument("retain_stacks", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    public required TerraformValue<string> StackSetName
    {
        get => new TerraformReference<string>(this, "stack_set_name");
        set => SetArgument("stack_set_name", value);
    }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformList<TerraformMap<object>> StackInstanceSummaries
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "stack_instance_summaries").ResolveNodes(ctx));
    }

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformValue<string> StackSetId
    {
        get => new TerraformReference<string>(this, "stack_set_id");
    }

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
