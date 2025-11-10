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
        SetOutput("arn");
        SetOutput("amount");
        SetOutput("breach_action");
        SetOutput("cluster_identifier");
        SetOutput("feature_type");
        SetOutput("id");
        SetOutput("limit_type");
        SetOutput("period");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformProperty<double> Amount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("amount");
        set => SetProperty("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformProperty<string> BreachAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("breach_action");
        set => SetProperty("breach_action", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureType is required")]
    public required TerraformProperty<string> FeatureType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("feature_type");
        set => SetProperty("feature_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The limit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitType is required")]
    public required TerraformProperty<string> LimitType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("limit_type");
        set => SetProperty("limit_type", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformProperty<string> Period
    {
        get => GetRequiredOutput<TerraformProperty<string>>("period");
        set => SetProperty("period", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
