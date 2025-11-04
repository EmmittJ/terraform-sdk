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
    public double? Amount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("amount")?.Value;
        set => this.WithProperty("amount", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public string? BreachAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("breach_action")?.Value;
        set => this.WithProperty("breach_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    public string? FeatureType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feature_type")?.Value;
        set => this.WithProperty("feature_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The limit_type attribute.
    /// </summary>
    public string? LimitType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("limit_type")?.Value;
        set => this.WithProperty("limit_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public string? Period
    {
        get => GetProperty<TerraformLiteralProperty<string>>("period")?.Value;
        set => this.WithProperty("period", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
