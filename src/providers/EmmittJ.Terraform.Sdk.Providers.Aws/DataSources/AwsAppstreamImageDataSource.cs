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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Arn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The most_recent attribute.
    /// </summary>
    [TerraformPropertyName("most_recent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? MostRecent { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    [TerraformPropertyName("name_regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NameRegex { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The applications attribute.
    /// </summary>
    [TerraformPropertyName("applications")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Applications => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "applications");

    /// <summary>
    /// The appstream_agent_version attribute.
    /// </summary>
    [TerraformPropertyName("appstream_agent_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AppstreamAgentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "appstream_agent_version");

    /// <summary>
    /// The base_image_arn attribute.
    /// </summary>
    [TerraformPropertyName("base_image_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BaseImageArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "base_image_arn");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The image_builder_name attribute.
    /// </summary>
    [TerraformPropertyName("image_builder_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ImageBuilderName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "image_builder_name");

    /// <summary>
    /// The image_builder_supported attribute.
    /// </summary>
    [TerraformPropertyName("image_builder_supported")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ImageBuilderSupported => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "image_builder_supported");

    /// <summary>
    /// The image_permissions attribute.
    /// </summary>
    [TerraformPropertyName("image_permissions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ImagePermissions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "image_permissions");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Platform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform");

    /// <summary>
    /// The public_base_image_released_date attribute.
    /// </summary>
    [TerraformPropertyName("public_base_image_released_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicBaseImageReleasedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_base_image_released_date");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The state_change_reason attribute.
    /// </summary>
    [TerraformPropertyName("state_change_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StateChangeReason => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "state_change_reason");

}
