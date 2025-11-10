using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetInstanceDeploymentTargetsBlock : TerraformBlock
{
    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    public TerraformProperty<string>? AccountFilterType
    {
        get => GetProperty<TerraformProperty<string>>("account_filter_type");
        set => WithProperty("account_filter_type", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Accounts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("accounts");
        set => WithProperty("accounts", value);
    }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    public TerraformProperty<string>? AccountsUrl
    {
        get => GetProperty<TerraformProperty<string>>("accounts_url");
        set => WithProperty("accounts_url", value);
    }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OrganizationalUnitIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("organizational_unit_ids");
        set => WithProperty("organizational_unit_ids", value);
    }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetInstanceOperationPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConcurrencyMode
    {
        get => GetProperty<TerraformProperty<string>>("concurrency_mode");
        set => WithProperty("concurrency_mode", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformProperty<double>? FailureToleranceCount
    {
        get => GetProperty<TerraformProperty<double>>("failure_tolerance_count");
        set => WithProperty("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FailureTolerancePercentage
    {
        get => GetProperty<TerraformProperty<double>>("failure_tolerance_percentage");
        set => WithProperty("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentCount
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrent_count");
        set => WithProperty("max_concurrent_count", value);
    }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentPercentage
    {
        get => GetProperty<TerraformProperty<double>>("max_concurrent_percentage");
        set => WithProperty("max_concurrent_percentage", value);
    }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    public TerraformProperty<string>? RegionConcurrencyType
    {
        get => GetProperty<TerraformProperty<string>>("region_concurrency_type");
        set => WithProperty("region_concurrency_type", value);
    }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    public List<TerraformProperty<string>>? RegionOrder
    {
        get => GetProperty<List<TerraformProperty<string>>>("region_order");
        set => WithProperty("region_order", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackSetInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_cloudformation_stack_set_instance resource.
/// </summary>
public class AwsCloudformationStackSetInstance : TerraformResource
{
    public AwsCloudformationStackSetInstance(string name) : base("aws_cloudformation_stack_set_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("organizational_unit_id");
        this.DeclareOutput("stack_id");
        this.DeclareOutput("stack_instance_summaries");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformProperty<string>? CallAs
    {
        get => GetProperty<TerraformProperty<string>>("call_as");
        set => this.WithProperty("call_as", value);
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
    /// The parameter_overrides attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ParameterOverrides
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameter_overrides");
        set => this.WithProperty("parameter_overrides", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The retain_stack attribute.
    /// </summary>
    public TerraformProperty<bool>? RetainStack
    {
        get => GetProperty<TerraformProperty<bool>>("retain_stack");
        set => this.WithProperty("retain_stack", value);
    }

    /// <summary>
    /// The stack_set_instance_region attribute.
    /// </summary>
    public TerraformProperty<string>? StackSetInstanceRegion
    {
        get => GetProperty<TerraformProperty<string>>("stack_set_instance_region");
        set => this.WithProperty("stack_set_instance_region", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    public required TerraformProperty<string> StackSetName
    {
        get => GetProperty<TerraformProperty<string>>("stack_set_name");
        set => this.WithProperty("stack_set_name", value);
    }

    /// <summary>
    /// Block for deployment_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    public List<AwsCloudformationStackSetInstanceDeploymentTargetsBlock>? DeploymentTargets
    {
        get => GetProperty<List<AwsCloudformationStackSetInstanceDeploymentTargetsBlock>>("deployment_targets");
        set => this.WithProperty("deployment_targets", value);
    }

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    public List<AwsCloudformationStackSetInstanceOperationPreferencesBlock>? OperationPreferences
    {
        get => GetProperty<List<AwsCloudformationStackSetInstanceOperationPreferencesBlock>>("operation_preferences");
        set => this.WithProperty("operation_preferences", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudformationStackSetInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCloudformationStackSetInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The organizational_unit_id attribute.
    /// </summary>
    public TerraformExpression OrganizationalUnitId => this["organizational_unit_id"];

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    public TerraformExpression StackId => this["stack_id"];

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformExpression StackInstanceSummaries => this["stack_instance_summaries"];

}
