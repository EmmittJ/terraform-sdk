using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_metrics_preference in AwsComputeoptimizerRecommendationPreferences.
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_metrics_preference";

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for preferred_resource in AwsComputeoptimizerRecommendationPreferences.
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "preferred_resource";

    /// <summary>
    /// The exclude_list attribute.
    /// </summary>
    public TerraformSet<string>? ExcludeList
    {
        get => GetArgument<TerraformSet<string>>("exclude_list");
        set => SetArgument("exclude_list", value);
    }

    /// <summary>
    /// The include_list attribute.
    /// </summary>
    public TerraformSet<string>? IncludeList
    {
        get => GetArgument<TerraformSet<string>>("include_list");
        set => SetArgument("include_list", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for scope in AwsComputeoptimizerRecommendationPreferences.
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesScopeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scope";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for utilization_preference in AwsComputeoptimizerRecommendationPreferences.
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "utilization_preference";

    /// <summary>
    /// The metric_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MetricName is required")]
    public required TerraformValue<string> MetricName
    {
        get => GetRequiredArgument<TerraformValue<string>>("metric_name");
        set => SetArgument("metric_name", value);
    }

    /// <summary>
    /// MetricParameters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlockMetricParametersBlock>? MetricParameters
    {
        get => GetArgument<TerraformList<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlockMetricParametersBlock>>("metric_parameters");
        set => SetArgument("metric_parameters", value);
    }

}

/// <summary>
/// Block type for metric_parameters in AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlockMetricParametersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metric_parameters";

    /// <summary>
    /// The headroom attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Headroom is required")]
    public required TerraformValue<string> Headroom
    {
        get => GetRequiredArgument<TerraformValue<string>>("headroom");
        set => SetArgument("headroom", value);
    }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    public TerraformValue<string>? Threshold
    {
        get => GetArgument<TerraformValue<string>>("threshold");
        set => SetArgument("threshold", value);
    }

}


/// <summary>
/// Represents a aws_computeoptimizer_recommendation_preferences Terraform resource.
/// Manages a aws_computeoptimizer_recommendation_preferences resource.
/// </summary>
public partial class AwsComputeoptimizerRecommendationPreferences(string name) : TerraformResource("aws_computeoptimizer_recommendation_preferences", name)
{
    /// <summary>
    /// The enhanced_infrastructure_metrics attribute.
    /// </summary>
    public TerraformValue<string>? EnhancedInfrastructureMetrics
    {
        get => GetArgument<TerraformValue<string>>("enhanced_infrastructure_metrics");
        set => SetArgument("enhanced_infrastructure_metrics", value);
    }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    public TerraformValue<string>? InferredWorkloadTypes
    {
        get => GetArgument<TerraformValue<string>>("inferred_workload_types");
        set => SetArgument("inferred_workload_types", value);
    }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    public TerraformValue<string> LookBackPeriod
    {
        get => GetArgument<TerraformValue<string>>("look_back_period") ?? CreateReference("look_back_period");
        set => SetArgument("look_back_period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceTypeAttribute is required")]
    public required TerraformValue<string> ResourceTypeAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public TerraformValue<string>? SavingsEstimationMode
    {
        get => GetArgument<TerraformValue<string>>("savings_estimation_mode");
        set => SetArgument("savings_estimation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// ExternalMetricsPreference block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>? ExternalMetricsPreference
    {
        get => GetArgument<TerraformList<AwsComputeoptimizerRecommendationPreferencesExternalMetricsPreferenceBlock>>("external_metrics_preference");
        set => SetArgument("external_metrics_preference", value);
    }

    /// <summary>
    /// PreferredResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>? PreferredResource
    {
        get => GetArgument<TerraformList<AwsComputeoptimizerRecommendationPreferencesPreferredResourceBlock>>("preferred_resource");
        set => SetArgument("preferred_resource", value);
    }

    /// <summary>
    /// Scope block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsComputeoptimizerRecommendationPreferencesScopeBlock>? Scope
    {
        get => GetArgument<TerraformList<AwsComputeoptimizerRecommendationPreferencesScopeBlock>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// UtilizationPreference block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>? UtilizationPreference
    {
        get => GetArgument<TerraformList<AwsComputeoptimizerRecommendationPreferencesUtilizationPreferenceBlock>>("utilization_preference");
        set => SetArgument("utilization_preference", value);
    }

}
