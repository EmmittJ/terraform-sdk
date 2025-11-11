using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_aggregate_authorization resource.
/// </summary>
public partial class AwsConfigAggregateAuthorization : TerraformResource
{
    public AwsConfigAggregateAuthorization(string name) : base("aws_config_aggregate_authorization", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The authorized_aws_region attribute.
    /// </summary>
    [TerraformProperty("authorized_aws_region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AuthorizedAwsRegion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Region { get; set; }

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
