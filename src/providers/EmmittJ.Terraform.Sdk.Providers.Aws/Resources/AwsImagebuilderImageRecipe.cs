using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for block_device_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsImagebuilderImageRecipeBlockDeviceMappingBlock : TerraformBlock
{
    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceName
    {
        set => SetProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<bool>? NoDevice
    {
        set => SetProperty("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualName
    {
        set => SetProperty("virtual_name", value);
    }

}

/// <summary>
/// Block type for component in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeComponentBlock : TerraformBlock
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
/// Block type for systems_manager_agent in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderImageRecipeSystemsManagerAgentBlock : TerraformBlock
{
    /// <summary>
    /// The uninstall_after_build attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UninstallAfterBuild is required")]
    public required TerraformProperty<bool> UninstallAfterBuild
    {
        set => SetProperty("uninstall_after_build", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_image_recipe resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderImageRecipe : TerraformResource
{
    public AwsImagebuilderImageRecipe(string name) : base("aws_imagebuilder_image_recipe", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("date_created");
        SetOutput("owner");
        SetOutput("platform");
        SetOutput("ami_tags");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("parent_image");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_data_base64");
        SetOutput("version");
        SetOutput("working_directory");
    }

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> AmiTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("ami_tags");
        set => SetProperty("ami_tags", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string> UserDataBase64
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_data_base64");
        set => SetProperty("user_data_base64", value);
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
    /// Block for block_device_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsImagebuilderImageRecipeBlockDeviceMappingBlock>? BlockDeviceMapping
    {
        set => SetProperty("block_device_mapping", value);
    }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Component is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    public List<AwsImagebuilderImageRecipeComponentBlock>? Component
    {
        set => SetProperty("component", value);
    }

    /// <summary>
    /// Block for systems_manager_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemsManagerAgent block(s) allowed")]
    public List<AwsImagebuilderImageRecipeSystemsManagerAgentBlock>? SystemsManagerAgent
    {
        set => SetProperty("systems_manager_agent", value);
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
    /// The owner attribute.
    /// </summary>
    public TerraformExpression Owner => this["owner"];

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformExpression Platform => this["platform"];

}
