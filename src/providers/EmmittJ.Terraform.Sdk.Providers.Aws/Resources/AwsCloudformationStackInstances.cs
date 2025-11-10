using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackInstancesDeploymentTargetsBlock : TerraformBlock
{
    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    public TerraformProperty<string>? AccountFilterType
    {
        set => SetProperty("account_filter_type", value);
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Accounts
    {
        set => SetProperty("accounts", value);
    }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    public TerraformProperty<string>? AccountsUrl
    {
        set => SetProperty("accounts_url", value);
    }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OrganizationalUnitIds
    {
        set => SetProperty("organizational_unit_ids", value);
    }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackInstancesOperationPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    public TerraformProperty<string>? ConcurrencyMode
    {
        set => SetProperty("concurrency_mode", value);
    }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    public TerraformProperty<double>? FailureToleranceCount
    {
        set => SetProperty("failure_tolerance_count", value);
    }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? FailureTolerancePercentage
    {
        set => SetProperty("failure_tolerance_percentage", value);
    }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentCount
    {
        set => SetProperty("max_concurrent_count", value);
    }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConcurrentPercentage
    {
        set => SetProperty("max_concurrent_percentage", value);
    }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    public TerraformProperty<string>? RegionConcurrencyType
    {
        set => SetProperty("region_concurrency_type", value);
    }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    public List<TerraformProperty<string>>? RegionOrder
    {
        set => SetProperty("region_order", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackInstancesTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_cloudformation_stack_instances resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationStackInstances : TerraformResource
{
    public AwsCloudformationStackInstances(string name) : base("aws_cloudformation_stack_instances", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("stack_instance_summaries");
        SetOutput("stack_set_id");
        SetOutput("accounts");
        SetOutput("call_as");
        SetOutput("id");
        SetOutput("parameter_overrides");
        SetOutput("region");
        SetOutput("regions");
        SetOutput("retain_stacks");
        SetOutput("stack_set_name");
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Accounts
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("accounts");
        set => SetProperty("accounts", value);
    }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    public TerraformProperty<string> CallAs
    {
        get => GetRequiredOutput<TerraformProperty<string>>("call_as");
        set => SetProperty("call_as", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parameter_overrides attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ParameterOverrides
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameter_overrides");
        set => SetProperty("parameter_overrides", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Regions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("regions");
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The retain_stacks attribute.
    /// </summary>
    public TerraformProperty<bool> RetainStacks
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("retain_stacks");
        set => SetProperty("retain_stacks", value);
    }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    public required TerraformProperty<string> StackSetName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stack_set_name");
        set => SetProperty("stack_set_name", value);
    }

    /// <summary>
    /// Block for deployment_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    public List<AwsCloudformationStackInstancesDeploymentTargetsBlock>? DeploymentTargets
    {
        set => SetProperty("deployment_targets", value);
    }

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    public List<AwsCloudformationStackInstancesOperationPreferencesBlock>? OperationPreferences
    {
        set => SetProperty("operation_preferences", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCloudformationStackInstancesTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    public TerraformExpression StackInstanceSummaries => this["stack_instance_summaries"];

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    public TerraformExpression StackSetId => this["stack_set_id"];

}
