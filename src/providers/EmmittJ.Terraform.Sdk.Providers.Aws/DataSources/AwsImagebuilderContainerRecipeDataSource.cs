using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_container_recipe.
/// </summary>
public class AwsImagebuilderContainerRecipeDataSource : TerraformDataSource
{
    public AwsImagebuilderContainerRecipeDataSource(string name) : base("aws_imagebuilder_container_recipe", name)
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
    /// The component attribute.
    /// </summary>
    [TerraformPropertyName("component")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Component => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "component");

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [TerraformPropertyName("container_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_type");

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
    /// The dockerfile_template_data attribute.
    /// </summary>
    [TerraformPropertyName("dockerfile_template_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DockerfileTemplateData => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dockerfile_template_data");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    [TerraformPropertyName("instance_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> InstanceConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "instance_configuration");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KmsKeyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kms_key_id");

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
    /// The target_repository attribute.
    /// </summary>
    [TerraformPropertyName("target_repository")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TargetRepository => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "target_repository");

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
