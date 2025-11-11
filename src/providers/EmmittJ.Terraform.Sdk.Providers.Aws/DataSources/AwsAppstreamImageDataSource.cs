using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_appstream_image.
/// </summary>
public partial class AwsAppstreamImageDataSource : TerraformDataSource
{
    public AwsAppstreamImageDataSource(string name) : base("aws_appstream_image", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformProperty("most_recent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformProperty("name_regex")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [TerraformProperty("applications")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Applications { get; }

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    [TerraformProperty("appstream_agent_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AppstreamAgentVersion { get; }

    /// <summary>
    /// The base_image_arn attribute.
    /// </summary>
    [TerraformProperty("base_image_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> BaseImageArn { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The image_builder_name attribute.
    /// </summary>
    [TerraformProperty("image_builder_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ImageBuilderName { get; }

    /// <summary>
    /// The image_builder_supported attribute.
    /// </summary>
    [TerraformProperty("image_builder_supported")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> ImageBuilderSupported { get; }

    /// <summary>
    /// The image_permissions attribute.
    /// </summary>
    [TerraformProperty("image_permissions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ImagePermissions { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Platform { get; }

    /// <summary>
    /// The public_base_image_released_date attribute.
    /// </summary>
    [TerraformProperty("public_base_image_released_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicBaseImageReleasedDate { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The state_change_reason attribute.
    /// </summary>
    [TerraformProperty("state_change_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StateChangeReason { get; }

}
