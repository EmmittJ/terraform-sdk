using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_imagebuilder_image_recipe Terraform data source.
/// Retrieves information about a aws_imagebuilder_image_recipe.
/// </summary>
public partial class AwsImagebuilderImageRecipeDataSource(string name) : TerraformDataSource("aws_imagebuilder_image_recipe", name)
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
    /// The ami_tags attribute.
    /// </summary>
    public TerraformMap<string> AmiTags
        => CreateReference("ami_tags");

    /// <summary>
    /// The block_device_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> BlockDeviceMapping
        => CreateReference("block_device_mapping");

    /// <summary>
    /// The component attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Component
        => CreateReference("component");

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
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformValue<string> UserDataBase64
        => CreateReference("user_data_base64");

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
