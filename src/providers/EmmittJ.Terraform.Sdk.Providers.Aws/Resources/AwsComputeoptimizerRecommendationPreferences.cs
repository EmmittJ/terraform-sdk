using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_metrics_preference in .
/// Nesting mode: list
/// </summary>
public partial class AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Source { get; set; }

}

/// <summary>
/// Block type for preferred_resource in .
/// Nesting mode: list
/// </summary>
public partial class AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The exclude_list attribute.
    /// </summary>
    [TerraformProperty("exclude_list")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ExcludeList { get; set; }

    /// <summary>
    /// The include_list attribute.
    /// </summary>
    [TerraformProperty("include_list")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? IncludeList { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public partial class AwsComputeoptimizerRecommendationPreferencesScopeBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for utilization_preference in .
/// Nesting mode: list
/// </summary>
public partial class AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock : TerraformBlockBase
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    [TerraformProperty("metric_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MetricName { get; set; }

}

/// <summary>
/// Manages a aws_computeoptimizer_recommendation_preferences resource.
/// </summary>
public partial class AwsComputeoptimizerRecommendationPreferences : TerraformResource
{
    public AwsComputeoptimizerRecommendationPreferences(string name) : base("aws_computeoptimizer_recommendation_preferences", name)
    {
    }

    /// <summary>
    /// The enhanced_infrastructure_metrics attribute.
    /// </summary>
    [TerraformProperty("enhanced_infrastructure_metrics")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnhancedInfrastructureMetrics { get; set; }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    [TerraformProperty("inferred_workload_types")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InferredWorkloadTypes { get; set; }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    [TerraformProperty("look_back_period")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> LookBackPeriod { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    [TerraformProperty("resource_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    [TerraformProperty("savings_estimation_mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SavingsEstimationMode { get; set; }

    /// <summary>
    /// Block for external_metrics_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("external_metrics_preference")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>>? ExternalMetricsPreference { get; set; }

    /// <summary>
    /// Block for preferred_resource.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("preferred_resource")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>>? PreferredResource { get; set; }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("scope")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesScopeBlock>>? Scope { get; set; }

    /// <summary>
    /// Block for utilization_preference.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("utilization_preference")]
    public TerraformList<TerraformBlock<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>>? UtilizationPreference { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

}
