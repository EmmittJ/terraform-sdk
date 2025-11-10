using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_metrics_preference in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetRequiredProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

}

/// <summary>
/// Block type for preferred_resource in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock : TerraformBlock
{
    /// <summary>
    /// The exclude_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExcludeList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("exclude_list");
        set => WithProperty("exclude_list", value);
    }

    /// <summary>
    /// The include_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludeList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("include_list");
        set => WithProperty("include_list", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Block type for scope in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesScopeBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetRequiredProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for utilization_preference in .
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformProperty<string> MetricName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("metric_name");
        set => WithProperty("metric_name", value);
    }

}

/// <summary>
/// Manages a aws_computeoptimizer_recommendation_preferences resource.
/// </summary>
public class AwsComputeoptimizerRecommendationPreferences : TerraformResource
{
    public AwsComputeoptimizerRecommendationPreferences(string name) : base("aws_computeoptimizer_recommendation_preferences", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputd");
    }

    /// <summary>
    /// The enhanced_infrastructure_metrics attribute.
    /// </summary>
    public TerraformProperty<string>? EnhancedInfrastructureMetrics
    {
        get => GetProperty<TerraformProperty<string>>("enhanced_infrastructure_metrics");
        set => this.WithProperty("enhanced_infrastructure_metrics", value);
    }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    public TerraformProperty<string>? InferredWorkloadTypes
    {
        get => GetProperty<TerraformProperty<string>>("inferred_workload_types");
        set => this.WithProperty("inferred_workload_types", value);
    }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    public TerraformProperty<string>? LookBackPeriod
    {
        get => GetProperty<TerraformProperty<string>>("look_back_period");
        set => this.WithProperty("look_back_period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public TerraformProperty<string>? SavingsEstimationMode
    {
        get => GetProperty<TerraformProperty<string>>("savings_estimation_mode");
        set => this.WithProperty("savings_estimation_mode", value);
    }

    /// <summary>
    /// Block for external_metrics_preference.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>? ExternalMetricsPreference
    {
        get => GetProperty<List<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>>("external_metrics_preference");
        set => this.WithProperty("external_metrics_preference", value);
    }

    /// <summary>
    /// Block for preferred_resource.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>? PreferredResource
    {
        get => GetProperty<List<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>>("preferred_resource");
        set => this.WithProperty("preferred_resource", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesScopeBlock>? Scope
    {
        get => GetProperty<List<AwsComputeoptimizerRecommendationPreferencesScopeBlock>>("scope");
        set => this.WithProperty("scope", value);
    }

    /// <summary>
    /// Block for utilization_preference.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>? UtilizationPreference
    {
        get => GetProperty<List<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>>("utilization_preference");
        set => this.WithProperty("utilization_preference", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
