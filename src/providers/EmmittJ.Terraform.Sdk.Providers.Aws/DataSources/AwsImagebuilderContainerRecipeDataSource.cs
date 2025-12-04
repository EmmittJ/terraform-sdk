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
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The component attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Component
        => AsReference("component");

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerType
        => AsReference("container_type");

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
        => AsReference("date_created");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformValue<string> DockerfileTemplateData
        => AsReference("dockerfile_template_data");

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
        => AsReference("encrypted");

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceConfiguration
        => AsReference("instance_configuration");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    public TerraformValue<string> ParentImage
        => AsReference("parent_image");

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
        => AsReference("platform");

    /// <summary>
    /// The target_repository attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetRepository
        => AsReference("target_repository");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string> WorkingDirectory
        => AsReference("working_directory");

}
