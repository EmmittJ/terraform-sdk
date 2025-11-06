using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_resiliencehub_resiliency_policy resource.
/// </summary>
public class AwsResiliencehubResiliencyPolicy : TerraformResource
{
    public AwsResiliencehubResiliencyPolicy(string name) : base("aws_resiliencehub_resiliency_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("estimated_cost_tier");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// Specifies a high-level geographical location constraint for where resilience policy data can be stored.
    /// </summary>
    public string? DataLocationConstraint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_location_constraint")?.Value;
        set => this.WithProperty("data_location_constraint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description for the policy.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the policy.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tier for the resiliency policy, ranging from the highest severity (MissionCritical) to lowest (NonCritical).
    /// </summary>
    public string? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier")?.Value;
        set => this.WithProperty("tier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// Specifies the estimated cost tier of the resiliency policy.
    /// </summary>
    public TerraformExpression EstimatedCostTier => this["estimated_cost_tier"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
