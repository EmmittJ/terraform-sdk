using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackInstancesDeploymentTargetsBlock
{
    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    [TerraformPropertyName("account_filter_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountFilterType { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Accounts { get; set; }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    [TerraformPropertyName("accounts_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AccountsUrl { get; set; }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? OrganizationalUnitIds { get; set; }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackInstancesOperationPreferencesBlock
{
    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    [TerraformPropertyName("concurrency_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConcurrencyMode { get; set; }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrentCount { get; set; }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrentPercentage { get; set; }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    [TerraformPropertyName("region_concurrency_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RegionConcurrencyType { get; set; }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    [TerraformPropertyName("region_order")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? RegionOrder { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackInstancesTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack_instances resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationStackInstances : TerraformResource
{
    public AwsCloudformationStackInstances(string name) : base("aws_cloudformation_stack_instances", name)
    {
    }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Accounts { get; set; } = default!;

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    [TerraformPropertyName("call_as")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CallAs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The parameter_overrides attribute.
    /// </summary>
    [TerraformPropertyName("parameter_overrides")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ParameterOverrides { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Regions { get; set; } = default!;

    /// <summary>
    /// The retain_stacks attribute.
    /// </summary>
    [TerraformPropertyName("retain_stacks")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RetainStacks { get; set; }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    [TerraformPropertyName("stack_set_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StackSetName { get; set; }

    /// <summary>
    /// Block for deployment_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    [TerraformPropertyName("deployment_targets")]
    public TerraformList<TerraformBlock<AwsCloudformationStackInstancesDeploymentTargetsBlock>>? DeploymentTargets { get; set; }

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    [TerraformPropertyName("operation_preferences")]
    public TerraformList<TerraformBlock<AwsCloudformationStackInstancesOperationPreferencesBlock>>? OperationPreferences { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudformationStackInstancesTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    [TerraformPropertyName("stack_instance_summaries")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StackInstanceSummaries => new TerraformReference(this, "stack_instance_summaries");

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    [TerraformPropertyName("stack_set_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StackSetId => new TerraformReference(this, "stack_set_id");

}
