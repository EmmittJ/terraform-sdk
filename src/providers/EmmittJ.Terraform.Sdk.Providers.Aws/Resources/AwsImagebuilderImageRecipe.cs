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
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

    /// <summary>
    /// The no_device attribute.
    /// </summary>
    public TerraformProperty<bool>? NoDevice
    {
        get => GetProperty<TerraformProperty<bool>>("no_device");
        set => WithProperty("no_device", value);
    }

    /// <summary>
    /// The virtual_name attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualName
    {
        get => GetProperty<TerraformProperty<string>>("virtual_name");
        set => WithProperty("virtual_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("component_arn");
        set => WithProperty("component_arn", value);
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
        get => GetRequiredProperty<TerraformProperty<bool>>("uninstall_after_build");
        set => WithProperty("uninstall_after_build", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("owner");
        this.DeclareOutput("platform");
    }

    /// <summary>
    /// The ami_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AmiTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("ami_tags");
        set => this.WithProperty("ami_tags", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? UserDataBase64
    {
        get => GetProperty<TerraformProperty<string>>("user_data_base64");
        set => this.WithProperty("user_data_base64", value);
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
    /// Block for block_device_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsImagebuilderImageRecipeBlockDeviceMappingBlock>? BlockDeviceMapping
    {
        get => GetProperty<HashSet<AwsImagebuilderImageRecipeBlockDeviceMappingBlock>>("block_device_mapping");
        set => this.WithProperty("block_device_mapping", value);
    }

    /// <summary>
    /// Block for component.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Component block(s) required")]
    public List<AwsImagebuilderImageRecipeComponentBlock>? Component
    {
        get => GetProperty<List<AwsImagebuilderImageRecipeComponentBlock>>("component");
        set => this.WithProperty("component", value);
    }

    /// <summary>
    /// Block for systems_manager_agent.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SystemsManagerAgent block(s) allowed")]
    public List<AwsImagebuilderImageRecipeSystemsManagerAgentBlock>? SystemsManagerAgent
    {
        get => GetProperty<List<AwsImagebuilderImageRecipeSystemsManagerAgentBlock>>("systems_manager_agent");
        set => this.WithProperty("systems_manager_agent", value);
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
