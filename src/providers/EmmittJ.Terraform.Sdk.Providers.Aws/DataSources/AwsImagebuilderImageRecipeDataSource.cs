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
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    [TerraformPropertyName("ami_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> AmiTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "ami_tags");

    /// <summary>
    /// The block_device_mapping attribute.
    /// </summary>
    [TerraformPropertyName("block_device_mapping")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> BlockDeviceMapping => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "block_device_mapping");

    /// <summary>
    /// The component attribute.
    /// </summary>
    [TerraformPropertyName("component")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Component => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "component");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_created");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [TerraformPropertyName("parent_image")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentImage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_image");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Platform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform");

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    [TerraformPropertyName("user_data_base64")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserDataBase64 => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_data_base64");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformPropertyName("working_directory")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkingDirectory => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "working_directory");

}
