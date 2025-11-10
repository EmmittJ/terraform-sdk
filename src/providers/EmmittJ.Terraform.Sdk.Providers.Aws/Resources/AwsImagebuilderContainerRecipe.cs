using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for component in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeComponentBlock : TerraformBlock
{
    /// <summary>
    /// The component_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComponentArn is required")]
    public required TerraformProperty<string> ComponentArn
    {
        set => SetProperty("component_arn", value);
    }

}

/// <summary>
/// Block type for instance_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeInstanceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The image attribute.
    /// </summary>
    public TerraformProperty<string>? Image
    {
        set => SetProperty("image", value);
    }

}

/// <summary>
/// Block type for target_repository in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderContainerRecipeTargetRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        set => SetProperty("repository_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        set => SetProperty("service", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_container_recipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderContainerRecipe : TerraformResource
{
    public AwsImagebuilderContainerRecipe(string name) : base("aws_imagebuilder_container_recipe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("date_created");
        SetOutput("encrypted");
        SetOutput("owner");
        SetOutput("platform");
        SetOutput("container_type");
        SetOutput("description");
        SetOutput("dockerfile_template_data");
        SetOutput("dockerfile_template_uri");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("name");
        SetOutput("parent_image");
        SetOutput("platform_override");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("version");
        SetOutput("working_directory");
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerType is required")]
    public required TerraformProperty<string> ContainerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_type");
        set => SetProperty("container_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformProperty<string> DockerfileTemplateData
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dockerfile_template_data");
        set => SetProperty("dockerfile_template_data", value);
    }

    /// <summary>
    /// The dockerfile_template_uri attribute.
    /// </summary>
    public TerraformProperty<string> DockerfileTemplateUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dockerfile_template_uri");
        set => SetProperty("dockerfile_template_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    public required TerraformProperty<string> ParentImage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_image");
        set => SetProperty("parent_image", value);
    }

    /// <summary>
    /// The platform_override attribute.
    /// </summary>
    public TerraformProperty<string> PlatformOverride
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_override");
        set => SetProperty("platform_override", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformProperty<string> WorkingDirectory
    {
        get => GetRequiredOutput<TerraformProperty<string>>("working_directory");
        set => SetProperty("working_directory", value);
    }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    public List<AwsImagebuilderContainerRecipeComponentBlock>? Component
    {
        set => SetProperty("component", value);
    }

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    public List<AwsImagebuilderContainerRecipeInstanceConfigurationBlock>? InstanceConfiguration
    {
        set => SetProperty("instance_configuration", value);
    }

    /// <summary>
    /// Block for target_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetRepository block(s) allowed")]
    public List<AwsImagebuilderContainerRecipeTargetRepositoryBlock>? TargetRepository
    {
        set => SetProperty("target_repository", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformExpression Encrypted => this["encrypted"];

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

}
