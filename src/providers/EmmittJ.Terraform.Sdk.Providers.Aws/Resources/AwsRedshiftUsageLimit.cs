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
        get => GetArgument<TerraformValue<double>>("amount");
        set => SetArgument("amount", value);
    }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    public TerraformValue<string>? BreachAction
    {
        get => GetArgument<TerraformValue<string>>("breach_action");
        set => SetArgument("breach_action", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformValue<string> ClusterIdentifier
    {
        get => GetArgument<TerraformValue<string>>("cluster_identifier");
        set => SetArgument("cluster_identifier", value);
    }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureType is required")]
    public required TerraformValue<string> FeatureType
    {
        get => GetArgument<TerraformValue<string>>("feature_type");
        set => SetArgument("feature_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The limit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitType is required")]
    public required TerraformValue<string> LimitType
    {
        get => GetArgument<TerraformValue<string>>("limit_type");
        set => SetArgument("limit_type", value);
    }

    /// <summary>
    /// The period attribute.
    /// </summary>
    public TerraformValue<string>? Period
    {
        get => GetArgument<TerraformValue<string>>("period");
        set => SetArgument("period", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
