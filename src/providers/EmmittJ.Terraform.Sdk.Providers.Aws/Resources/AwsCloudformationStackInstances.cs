using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackInstancesDeploymentTargetsBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    [TerraformProperty("account_filter_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccountFilterType { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Accounts { get; set; }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    [TerraformProperty("accounts_url")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AccountsUrl { get; set; }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? OrganizationalUnitIds { get; set; }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackInstancesOperationPreferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    [TerraformProperty("concurrency_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConcurrencyMode { get; set; }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformProperty("failure_tolerance_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformProperty("failure_tolerance_percentage")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_count")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConcurrentCount { get; set; }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_percentage")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxConcurrentPercentage { get; set; }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    [TerraformProperty("region_concurrency_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RegionConcurrencyType { get; set; }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    [TerraformProperty("region_order")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? RegionOrder { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudformationStackInstancesTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack_instances resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudformationStackInstances : TerraformResource
{
    public AwsCloudformationStackInstances(string name) : base("aws_cloudformation_stack_instances", name)
    {
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> Accounts { get; set; }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    [TerraformProperty("call_as")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CallAs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameter_overrides attribute.
    /// </summary>
    [TerraformProperty("parameter_overrides")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ParameterOverrides { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> Regions { get; set; }

    /// <summary>
    /// The retain_stacks attribute.
    /// </summary>
    [TerraformProperty("retain_stacks")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RetainStacks { get; set; }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    [TerraformProperty("stack_set_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StackSetName { get; set; }

    /// <summary>
    /// Block for deployment_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    [TerraformProperty("deployment_targets")]
    public TerraformList<TerraformBlock<AwsCloudformationStackInstancesDeploymentTargetsBlock>>? DeploymentTargets { get; set; }

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    [TerraformProperty("operation_preferences")]
    public TerraformList<TerraformBlock<AwsCloudformationStackInstancesOperationPreferencesBlock>>? OperationPreferences { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsCloudformationStackInstancesTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    [TerraformProperty("stack_instance_summaries")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StackInstanceSummaries { get; }

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    [TerraformProperty("stack_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> StackSetId { get; }

}
