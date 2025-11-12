using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackSetInstanceDeploymentTargetsBlock() : TerraformBlock("deployment_targets")
{
    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    [TerraformProperty("account_filter_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountFilterType { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Accounts { get; set; }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    [TerraformProperty("accounts_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AccountsUrl { get; set; }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? OrganizationalUnitIds { get; set; }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackSetInstanceOperationPreferencesBlock() : TerraformBlock("operation_preferences")
{
    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    [TerraformProperty("concurrency_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConcurrencyMode { get; set; }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformProperty("failure_tolerance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformProperty("failure_tolerance_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrentCount { get; set; }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrentPercentage { get; set; }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    [TerraformProperty("region_concurrency_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegionConcurrencyType { get; set; }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    [TerraformProperty("region_order")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? RegionOrder { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudformationStackSetInstanceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack_set_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudformationStackSetInstance : TerraformResource
{
    public AwsCloudformationStackSetInstance(string name) : base("aws_cloudformation_stack_set_instance", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    [TerraformProperty("call_as")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CallAs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameter_overrides attribute.
    /// </summary>
    [TerraformProperty("parameter_overrides")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ParameterOverrides { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retain_stack attribute.
    /// </summary>
    [TerraformProperty("retain_stack")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetainStack { get; set; }

    /// <summary>
    /// The stack_set_instance_region attribute.
    /// </summary>
    [TerraformProperty("stack_set_instance_region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StackSetInstanceRegion { get; set; }

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    [TerraformProperty("stack_set_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StackSetName { get; set; }

    /// <summary>
    /// Block for deployment_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    [TerraformProperty("deployment_targets")]
    public TerraformList<AwsCloudformationStackSetInstanceDeploymentTargetsBlock> DeploymentTargets { get; set; } = new();

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    [TerraformProperty("operation_preferences")]
    public TerraformList<AwsCloudformationStackSetInstanceOperationPreferencesBlock> OperationPreferences { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCloudformationStackSetInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The organizational_unit_id attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OrganizationalUnitId { get; }

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    [TerraformProperty("stack_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StackId { get; }

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    [TerraformProperty("stack_instance_summaries")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StackInstanceSummaries { get; }

}
