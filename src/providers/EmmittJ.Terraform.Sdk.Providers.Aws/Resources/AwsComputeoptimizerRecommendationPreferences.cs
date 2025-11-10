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
        set => SetProperty("source", value);
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
        set => SetProperty("exclude_list", value);
    }

    /// <summary>
    /// The include_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IncludeList
    {
        set => SetProperty("include_list", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("metric_name", value);
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
        SetOutput("id");
        SetOutput("enhanced_infrastructure_metrics");
        SetOutput("inferred_workload_types");
        SetOutput("look_back_period");
        SetOutput("region");
        SetOutput("resource_type");
        SetOutput("savings_estimation_mode");
    }

    /// <summary>
    /// The enhanced_infrastructure_metrics attribute.
    /// </summary>
    public TerraformProperty<string> EnhancedInfrastructureMetrics
    {
        get => GetRequiredOutput<TerraformProperty<string>>("enhanced_infrastructure_metrics");
        set => SetProperty("enhanced_infrastructure_metrics", value);
    }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    public TerraformProperty<string> InferredWorkloadTypes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("inferred_workload_types");
        set => SetProperty("inferred_workload_types", value);
    }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    public TerraformProperty<string> LookBackPeriod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("look_back_period");
        set => SetProperty("look_back_period", value);
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
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public TerraformProperty<string> SavingsEstimationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("savings_estimation_mode");
        set => SetProperty("savings_estimation_mode", value);
    }

    /// <summary>
    /// Block for external_metrics_preference.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>? ExternalMetricsPreference
    {
        set => SetProperty("external_metrics_preference", value);
    }

    /// <summary>
    /// Block for preferred_resource.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>? PreferredResource
    {
        set => SetProperty("preferred_resource", value);
    }

    /// <summary>
    /// Block for scope.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesScopeBlock>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// Block for utilization_preference.
    /// Nesting mode: list
    /// </summary>
    public List<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>? UtilizationPreference
    {
        set => SetProperty("utilization_preference", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
