using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for component in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeComponentBlock : ITerraformBlock
{
    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    [TerraformPropertyName("component_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComponentArn { get; set; }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeInstanceConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    [TerraformPropertyName("image")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Image { get; set; }

}

/// <summary>
/// Block type for target_repository in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeTargetRepositoryBlock : ITerraformBlock
{
    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

}

/// <summary>
/// Manages a aws_imagebuilder_container_recipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderContainerRecipe : TerraformResource
{
    public AwsImagebuilderContainerRecipe(string name) : base("aws_imagebuilder_container_recipe", name)
    {
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerType is required")]
    [TerraformPropertyName("container_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ContainerType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    [TerraformPropertyName("dockerfile_template_data")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DockerfileTemplateData { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dockerfile_template_data");

    /// <summary>
    /// The dockerfile_template_uri attribute.
    /// </summary>
    [TerraformPropertyName("dockerfile_template_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DockerfileTemplateUri { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    [TerraformPropertyName("parent_image")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParentImage { get; set; }

    /// <summary>
    /// The platform_override attribute.
    /// </summary>
    [TerraformPropertyName("platform_override")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PlatformOverride { get; set; }

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
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformPropertyName("version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Version { get; set; }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    [TerraformPropertyName("working_directory")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkingDirectory { get; set; }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    [TerraformPropertyName("component")]
    public TerraformList<TerraformBlock<AwsImagebuilderContainerRecipeComponentBlock>>? Component { get; set; } = new();

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    [TerraformPropertyName("instance_configuration")]
    public TerraformList<TerraformBlock<AwsImagebuilderContainerRecipeInstanceConfigurationBlock>>? InstanceConfiguration { get; set; } = new();

    /// <summary>
    /// Block for target_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetRepository block(s) allowed")]
    [TerraformPropertyName("target_repository")]
    public TerraformList<TerraformBlock<AwsImagebuilderContainerRecipeTargetRepositoryBlock>>? TargetRepository { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    [TerraformPropertyName("date_created")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DateCreated => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "date_created");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    [TerraformPropertyName("encrypted")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Encrypted => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "encrypted");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Owner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Platform => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "platform");

}
