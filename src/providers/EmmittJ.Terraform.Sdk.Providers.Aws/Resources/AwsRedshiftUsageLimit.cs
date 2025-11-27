using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_redshift_usage_limit Terraform resource.
/// Manages a aws_redshift_usage_limit resource.
/// </summary>
public partial class AwsRedshiftUsageLimit(string name) : TerraformResource("aws_redshift_usage_limit", name)
{
    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    public required TerraformValue<double> Amount
    {
        get => new TerraformReference<double>(this, "amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformValue<string>? BreachAction
    {
        get => new TerraformReference<string>(this, "breach_action");
        set => SetArgument("breach_action", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => new TerraformReference<string>(this, "cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureType is required")]
    public required TerraformValue<string> FeatureType
    {
        get => new TerraformReference<string>(this, "feature_type");
        set => SetArgument("feature_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The limit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitType is required")]
    public required TerraformValue<string> LimitType
    {
        get => new TerraformReference<string>(this, "limit_type");
        set => SetArgument("limit_type", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<string>? Period
    {
        get => new TerraformReference<string>(this, "period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
