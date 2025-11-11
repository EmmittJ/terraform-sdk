using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_applicationinsights_application resource.
/// </summary>
public partial class AwsApplicationinsightsApplication : TerraformResource
{
    public AwsApplicationinsightsApplication(string name) : base("aws_applicationinsights_application", name)
    {
    }

    /// <summary>
    /// The auto_config_enabled attribute.
    /// </summary>
    [TerraformProperty("auto_config_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoConfigEnabled { get; set; }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    [TerraformProperty("auto_create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoCreate { get; set; }

    /// <summary>
    /// The cwe_monitor_enabled attribute.
    /// </summary>
    [TerraformProperty("cwe_monitor_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? CweMonitorEnabled { get; set; }

    /// <summary>
    /// The grouping_type attribute.
    /// </summary>
    [TerraformProperty("grouping_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? GroupingType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ops_center_enabled attribute.
    /// </summary>
    [TerraformProperty("ops_center_enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? OpsCenterEnabled { get; set; }

    /// <summary>
    /// The ops_item_sns_topic_arn attribute.
    /// </summary>
    [TerraformProperty("ops_item_sns_topic_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? OpsItemSnsTopicArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

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
