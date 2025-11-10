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
        get => GetRequiredProperty<TerraformProperty<string>>("component_arn");
        set => WithProperty("component_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("image");
        set => WithProperty("image", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service");
        set => WithProperty("service", value);
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
        this.WithOutput("arn");
        this.WithOutput("date_created");
        this.WithOutput("encrypted");
        this.WithOutput("owner");
        this.WithOutput("platform");
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerType is required")]
    public required TerraformProperty<string> ContainerType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("container_type");
        set => this.WithProperty("container_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformProperty<string>? DockerfileTemplateData
    {
        get => GetProperty<TerraformProperty<string>>("dockerfile_template_data");
        set => this.WithProperty("dockerfile_template_data", value);
    }

    /// <summary>
    /// The dockerfile_template_uri attribute.
    /// </summary>
    public TerraformProperty<string>? DockerfileTemplateUri
    {
        get => GetProperty<TerraformProperty<string>>("dockerfile_template_uri");
        set => this.WithProperty("dockerfile_template_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => this.WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParentImage is required")]
    public required TerraformProperty<string> ParentImage
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent_image");
        set => this.WithProperty("parent_image", value);
    }

    /// <summary>
    /// The platform_override attribute.
    /// </summary>
    public TerraformProperty<string>? PlatformOverride
    {
        get => GetProperty<TerraformProperty<string>>("platform_override");
        set => this.WithProperty("platform_override", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformProperty<string>? WorkingDirectory
    {
        get => GetProperty<TerraformProperty<string>>("working_directory");
        set => this.WithProperty("working_directory", value);
    }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    public List<AwsImagebuilderContainerRecipeComponentBlock>? Component
    {
        get => GetProperty<List<AwsImagebuilderContainerRecipeComponentBlock>>("component");
        set => this.WithProperty("component", value);
    }

    /// <summary>
    /// Block for instance_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceConfiguration block(s) allowed")]
    public List<AwsImagebuilderContainerRecipeInstanceConfigurationBlock>? InstanceConfiguration
    {
        get => GetProperty<List<AwsImagebuilderContainerRecipeInstanceConfigurationBlock>>("instance_configuration");
        set => this.WithProperty("instance_configuration", value);
    }

    /// <summary>
    /// Block for target_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TargetRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetRepository block(s) allowed")]
    public List<AwsImagebuilderContainerRecipeTargetRepositoryBlock>? TargetRepository
    {
        get => GetProperty<List<AwsImagebuilderContainerRecipeTargetRepositoryBlock>>("target_repository");
        set => this.WithProperty("target_repository", value);
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
