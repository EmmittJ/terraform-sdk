using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_usage_limit resource.
/// </summary>
public class AwsRedshiftUsageLimit : TerraformResource
{
    public AwsRedshiftUsageLimit(string name) : base("aws_redshift_usage_limit", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    public TerraformProperty<double>? Amount
    {
        get => GetProperty<TerraformProperty<double>>("amount");
        set => this.WithProperty("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformProperty<string>? BreachAction
    {
        get => GetProperty<TerraformProperty<string>>("breach_action");
        set => this.WithProperty("breach_action", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    public TerraformProperty<string>? FeatureType
    {
        get => GetProperty<TerraformProperty<string>>("feature_type");
        set => this.WithProperty("feature_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The limit_type attribute.
    /// </summary>
    public TerraformProperty<string>? LimitType
    {
        get => GetProperty<TerraformProperty<string>>("limit_type");
        set => this.WithProperty("limit_type", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<string>? Period
    {
        get => GetProperty<TerraformProperty<string>>("period");
        set => this.WithProperty("period", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
