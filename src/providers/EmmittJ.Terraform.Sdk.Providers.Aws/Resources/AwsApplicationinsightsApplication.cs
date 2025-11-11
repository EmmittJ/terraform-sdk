using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_applicationinsights_application resource.
/// </summary>
public class AwsApplicationinsightsApplication : TerraformResource
{
    public AwsApplicationinsightsApplication(string name) : base("aws_applicationinsights_application", name)
    {
    }

    /// <summary>
    /// The auto_config_enabled attribute.
    /// </summary>
    [TerraformPropertyName("auto_config_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoConfigEnabled { get; set; }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    [TerraformPropertyName("auto_create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AutoCreate { get; set; }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    [TerraformPropertyName("cwe_monitor_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CweMonitorEnabled { get; set; }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    [TerraformPropertyName("grouping_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GroupingType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ops_center_enabled attribute.
    /// </summary>
    [TerraformPropertyName("ops_center_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? OpsCenterEnabled { get; set; }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    [TerraformPropertyName("ops_item_sns_topic_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OpsItemSnsTopicArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}
