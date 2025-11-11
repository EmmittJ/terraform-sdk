using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_metrics_preference in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformPropertyName("source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for preferred_resource in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock
{
    /// <summary>
    /// The exclude_list attribute.
    /// </summary>
    [TerraformPropertyName("exclude_list")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ExcludeList { get; set; }

    /// <summary>
    /// The include_list attribute.
    /// </summary>
    [TerraformPropertyName("include_list")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IncludeList { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesScopeBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for utilization_preference in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformPropertyName("metric_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> MetricName { get; set; }

}

/// <summary>
/// Manages a aws_computeoptimizer_recommendation_preferences resource.
/// </summary>
public class AwsComputeoptimizerRecommendationPreferences : TerraformResource
{
    public AwsComputeoptimizerRecommendationPreferences(string name) : base("aws_computeoptimizer_recommendation_preferences", name)
    {
    }

    /// <summary>
    /// The enhanced_infrastructure_metrics attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_infrastructure_metrics")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EnhancedInfrastructureMetrics { get; set; }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    [TerraformPropertyName("inferred_workload_types")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? InferredWorkloadTypes { get; set; }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    [TerraformPropertyName("look_back_period")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> LookBackPeriod { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformPropertyName("resource_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    [TerraformPropertyName("savings_estimation_mode")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SavingsEstimationMode { get; set; }

    /// <summary>
    /// Block for external_metrics_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("external_metrics_preference")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>>? ExternalMetricsPreference { get; set; }

    /// <summary>
    /// Block for preferred_resource.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("preferred_resource")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>>? PreferredResource { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("scope")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesScopeBlock>>? Scope { get; set; }

    /// <summary>
    /// Block for utilization_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("utilization_preference")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>>? UtilizationPreference { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
