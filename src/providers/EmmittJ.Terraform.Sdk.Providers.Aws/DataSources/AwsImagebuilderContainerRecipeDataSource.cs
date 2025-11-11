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
    /// The component attribute.
    /// </summary>
    [TerraformPropertyName("component")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Component => new TerraformReference(this, "component");

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [TerraformPropertyName("container_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerType => new TerraformReference(this, "container_type");

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
    /// The dockerfile_template_data attribute.
    /// </summary>
    [TerraformPropertyName("dockerfile_template_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DockerfileTemplateData => new TerraformReference(this, "dockerfile_template_data");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Encrypted => new TerraformReference(this, "encrypted");

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    [TerraformPropertyName("instance_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceConfiguration => new TerraformReference(this, "instance_configuration");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KmsKeyId => new TerraformReference(this, "kms_key_id");

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
    /// The target_repository attribute.
    /// </summary>
    [TerraformPropertyName("target_repository")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TargetRepository => new TerraformReference(this, "target_repository");

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
