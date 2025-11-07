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
    public TerraformProperty<string>? DataLocationConstraint
    {
        get => GetProperty<TerraformProperty<string>>("data_location_constraint");
        set => this.WithProperty("data_location_constraint", value);
    }

    /// <summary>
    /// The description for the policy.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name of the policy.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tier for the resiliency policy, ranging from the highest severity (MissionCritical) to lowest (NonCritical).
    /// </summary>
    public TerraformProperty<string>? Tier
    {
        get => GetProperty<TerraformProperty<string>>("tier");
        set => this.WithProperty("tier", value);
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
