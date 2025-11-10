using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for deployment_targets in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetInstanceDeploymentTargetsBlock : ITerraformBlock
{
    /// <summary>
    /// The account_filter_type attribute.
    /// </summary>
    [TerraformPropertyName("account_filter_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountFilterType { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Accounts { get; set; }

    /// <summary>
    /// The accounts_url attribute.
    /// </summary>
    [TerraformPropertyName("accounts_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AccountsUrl { get; set; }

    /// <summary>
    /// The organizational_unit_ids attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? OrganizationalUnitIds { get; set; }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetInstanceOperationPreferencesBlock : ITerraformBlock
{
    /// <summary>
    /// The concurrency_mode attribute.
    /// </summary>
    [TerraformPropertyName("concurrency_mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConcurrencyMode { get; set; }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrentCount { get; set; }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrentPercentage { get; set; }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    [TerraformPropertyName("region_concurrency_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RegionConcurrencyType { get; set; }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    [TerraformPropertyName("region_order")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? RegionOrder { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackSetInstanceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack_set_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationStackSetInstance : TerraformResource
{
    public AwsCloudformationStackSetInstance(string name) : base("aws_cloudformation_stack_set_instance", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    [TerraformPropertyName("call_as")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CallAs { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The parameter_overrides attribute.
    /// </summary>
    [TerraformPropertyName("parameter_overrides")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ParameterOverrides { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The retain_stack attribute.
    /// </summary>
    [TerraformPropertyName("retain_stack")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RetainStack { get; set; }

    /// <summary>
    /// The stack_set_instance_region attribute.
    /// </summary>
    [TerraformPropertyName("stack_set_instance_region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> StackSetInstanceRegion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stack_set_instance_region");

    /// <summary>
    /// The stack_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackSetName is required")]
    [TerraformPropertyName("stack_set_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> StackSetName { get; set; }

    /// <summary>
    /// Block for deployment_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeploymentTargets block(s) allowed")]
    [TerraformPropertyName("deployment_targets")]
    public TerraformList<TerraformBlock<AwsCloudformationStackSetInstanceDeploymentTargetsBlock>>? DeploymentTargets { get; set; } = new();

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    [TerraformPropertyName("operation_preferences")]
    public TerraformList<TerraformBlock<AwsCloudformationStackSetInstanceOperationPreferencesBlock>>? OperationPreferences { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudformationStackSetInstanceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The organizational_unit_id attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrganizationalUnitId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "organizational_unit_id");

    /// <summary>
    /// The stack_id attribute.
    /// </summary>
    [TerraformPropertyName("stack_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StackId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stack_id");

    /// <summary>
    /// List of stack instances created from an organizational unit deployment target. This will only be populated when `deployment_targets` is set.
    /// </summary>
    [TerraformPropertyName("stack_instance_summaries")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StackInstanceSummaries => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "stack_instance_summaries");

}
