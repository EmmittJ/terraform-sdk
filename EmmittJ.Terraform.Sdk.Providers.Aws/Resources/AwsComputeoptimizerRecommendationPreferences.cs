using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The enhanced_infrastructure_metrics attribute.
    /// </summary>
    public string? EnhancedInfrastructureMetrics
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enhanced_infrastructure_metrics")?.Value;
        set => this.WithProperty("enhanced_infrastructure_metrics", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    public string? InferredWorkloadTypes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inferred_workload_types")?.Value;
        set => this.WithProperty("inferred_workload_types", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    public string? LookBackPeriod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("look_back_period")?.Value;
        set => this.WithProperty("look_back_period", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public string? SavingsEstimationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("savings_estimation_mode")?.Value;
        set => this.WithProperty("savings_estimation_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
