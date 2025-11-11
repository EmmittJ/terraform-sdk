using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_image_recipe.
/// </summary>
public class AwsImagebuilderImageRecipeDataSource : TerraformDataSource
{
    public AwsImagebuilderImageRecipeDataSource(string name) : base("aws_imagebuilder_image_recipe", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    [TerraformPropertyName("ami_tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> AmiTags => new TerraformReference(this, "ami_tags");

    /// <summary>
    /// The block_device_mapping attribute.
    /// </summary>
    [TerraformPropertyName("block_device_mapping")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> BlockDeviceMapping => new TerraformReference(this, "block_device_mapping");

    /// <summary>
    /// The component attribute.
    /// </summary>
    [TerraformPropertyName("component")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Component => new TerraformReference(this, "component");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DateCreated => new TerraformReference(this, "date_created");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Owner => new TerraformReference(this, "owner");

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [TerraformPropertyName("parent_image")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentImage => new TerraformReference(this, "parent_image");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Platform => new TerraformReference(this, "platform");

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserDataBase64 => new TerraformReference(this, "user_data_base64");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Version => new TerraformReference(this, "version");

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformPropertyName("working_directory")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkingDirectory => new TerraformReference(this, "working_directory");

}
