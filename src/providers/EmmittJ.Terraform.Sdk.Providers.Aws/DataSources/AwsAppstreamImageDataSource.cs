using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_appstream_image.
/// </summary>
public class AwsAppstreamImageDataSource : TerraformDataSource
{
    public AwsAppstreamImageDataSource(string name) : base("aws_appstream_image", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Arn { get; set; } = default!;

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MostRecent { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Name { get; set; } = default!;

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NameRegex { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [TerraformPropertyName("applications")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Applications => new TerraformReference(this, "applications");

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    [TerraformPropertyName("appstream_agent_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AppstreamAgentVersion => new TerraformReference(this, "appstream_agent_version");

    /// <summary>
    /// The base_image_arn attribute.
    /// </summary>
    [TerraformPropertyName("base_image_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BaseImageArn => new TerraformReference(this, "base_image_arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The image_builder_name attribute.
    /// </summary>
    [TerraformPropertyName("image_builder_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ImageBuilderName => new TerraformReference(this, "image_builder_name");

    /// <summary>
    /// The image_builder_supported attribute.
    /// </summary>
    [TerraformPropertyName("image_builder_supported")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ImageBuilderSupported => new TerraformReference(this, "image_builder_supported");

    /// <summary>
    /// The image_permissions attribute.
    /// </summary>
    [TerraformPropertyName("image_permissions")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ImagePermissions => new TerraformReference(this, "image_permissions");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

    /// <summary>
    /// The public_base_image_released_date attribute.
    /// </summary>
    [TerraformPropertyName("public_base_image_released_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicBaseImageReleasedDate => new TerraformReference(this, "public_base_image_released_date");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The state_change_reason attribute.
    /// </summary>
    [TerraformPropertyName("state_change_reason")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StateChangeReason => new TerraformReference(this, "state_change_reason");

}
