using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_imagebuilder_container_recipe Terraform data source.
/// Retrieves information about a aws_imagebuilder_container_recipe.
/// </summary>
public partial class AwsImagebuilderContainerRecipeDataSource(string name) : TerraformDataSource("aws_imagebuilder_container_recipe", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => GetRequiredArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The component attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Component
        => CreateReference("component");

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerType
        => CreateReference("container_type");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => CreateReference("date_created");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformValue<string> DockerfileTemplateData
        => CreateReference("dockerfile_template_data");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => CreateReference("encrypted");

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceConfiguration
        => CreateReference("instance_configuration");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => CreateReference("kms_key_id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => CreateReference("owner");

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    public TerraformValue<string> ParentImage
        => CreateReference("parent_image");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
        => CreateReference("platform");

    /// <summary>
    /// The target_repository attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetRepository
        => CreateReference("target_repository");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => CreateReference("version");

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string> WorkingDirectory
        => CreateReference("working_directory");

}
