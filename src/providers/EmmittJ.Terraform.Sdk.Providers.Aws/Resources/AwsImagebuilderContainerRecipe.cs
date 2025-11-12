using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for component in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderContainerRecipeComponentBlock() : TerraformBlock("component")
{
    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    [TerraformProperty("component_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ComponentArn { get; set; }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderContainerRecipeInstanceConfigurationBlock() : TerraformBlock("instance_configuration")
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformProperty("image")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Image { get; set; }

}

/// <summary>
/// Block type for target_repository in .
/// Nesting mode: list
/// </summary>
public partial class AwsImagebuilderContainerRecipeTargetRepositoryBlock() : TerraformBlock("target_repository")
{
    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_container_recipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsImagebuilderContainerRecipe : TerraformResource
{
    public AwsImagebuilderContainerRecipe(string name) : base("aws_imagebuilder_container_recipe", name)
    {
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerType is required")]
    [TerraformProperty("container_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ContainerType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    [TerraformProperty("dockerfile_template_data")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DockerfileTemplateData { get; set; }

    /// <summary>
    /// The dockerfile_template_uri attribute.
    /// </summary>
    [TerraformProperty("dockerfile_template_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DockerfileTemplateUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    [TerraformProperty("parent_image")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParentImage { get; set; }

    /// <summary>
    /// The platform_override attribute.
    /// </summary>
    [TerraformProperty("platform_override")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlatformOverride { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformProperty("working_directory")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkingDirectory { get; set; }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    [TerraformProperty("component")]
    public required TerraformList<AwsImagebuilderContainerRecipeComponentBlock> Component { get; set; } = new();

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    [TerraformProperty("instance_configuration")]
    public TerraformList<AwsImagebuilderContainerRecipeInstanceConfigurationBlock> InstanceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for target_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetRepository block(s) allowed")]
    [TerraformProperty("target_repository")]
    public required TerraformList<AwsImagebuilderContainerRecipeTargetRepositoryBlock> TargetRepository { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformProperty("date_created")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DateCreated { get; }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformProperty("encrypted")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> Encrypted { get; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Owner { get; }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformProperty("platform")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Platform { get; }

}
