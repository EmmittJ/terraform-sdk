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
    public TerraformLiteralProperty<string>? EnhancedInfrastructureMetrics
    {
        get => GetProperty<TerraformLiteralProperty<string>>("enhanced_infrastructure_metrics");
        set => this.WithProperty("enhanced_infrastructure_metrics", value);
    }

    /// <summary>
    /// The inferred_workload_types attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InferredWorkloadTypes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("inferred_workload_types");
        set => this.WithProperty("inferred_workload_types", value);
    }

    /// <summary>
    /// The look_back_period attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LookBackPeriod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("look_back_period");
        set => this.WithProperty("look_back_period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The savings_estimation_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SavingsEstimationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("savings_estimation_mode");
        set => this.WithProperty("savings_estimation_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
