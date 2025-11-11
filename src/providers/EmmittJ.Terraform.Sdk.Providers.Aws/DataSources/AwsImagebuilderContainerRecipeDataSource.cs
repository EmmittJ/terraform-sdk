using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_container_recipe.
/// </summary>
public partial class AwsImagebuilderContainerRecipeDataSource : TerraformDataSource
{
    public AwsImagebuilderContainerRecipeDataSource(string name) : base("aws_imagebuilder_container_recipe", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The component attribute.
    /// </summary>
    [TerraformProperty("component")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Component { get; }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [TerraformProperty("container_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContainerType { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    [TerraformProperty("dockerfile_template_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DockerfileTemplateData { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Encrypted { get; }

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    [TerraformProperty("instance_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InstanceConfiguration { get; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KmsKeyId { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Owner { get; }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [TerraformProperty("parent_image")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ParentImage { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Platform { get; }

    /// <summary>
    /// The target_repository attribute.
    /// </summary>
    [TerraformProperty("target_repository")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TargetRepository { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Version { get; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformProperty("working_directory")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkingDirectory { get; }

}
