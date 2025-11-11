using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_usage_limit resource.
/// </summary>
public partial class AwsRedshiftUsageLimit : TerraformResource
{
    public AwsRedshiftUsageLimit(string name) : base("aws_redshift_usage_limit", name)
    {
    }

    /// <summary>
    /// The amount attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Amount is required")]
    [TerraformProperty("amount")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Amount { get; set; }

    /// <summary>
    /// The breach_action attribute.
    /// </summary>
    [TerraformProperty("breach_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BreachAction { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The feature_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeatureType is required")]
    [TerraformProperty("feature_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FeatureType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The limit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitType is required")]
    [TerraformProperty("limit_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LimitType { get; set; }

    /// <summary>
    /// The period attribute.
    /// </summary>
    [TerraformProperty("period")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Period { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
