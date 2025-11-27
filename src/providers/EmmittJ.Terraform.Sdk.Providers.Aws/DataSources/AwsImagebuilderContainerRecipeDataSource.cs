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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The component attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Component
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "component").ResolveNodes(ctx));
    }

    /// <summary>
    /// The container_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerType
    {
        get => new TerraformReference<string>(this, "container_type");
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformValue<string> DateCreated
    {
        get => new TerraformReference<string>(this, "date_created");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The dockerfile_template_data attribute.
    /// </summary>
    public TerraformValue<string> DockerfileTemplateData
    {
        get => new TerraformReference<string>(this, "dockerfile_template_data");
    }

    /// <summary>
    /// The encrypted attribute.
    /// </summary>
    public TerraformValue<bool> Encrypted
    {
        get => new TerraformReference<bool>(this, "encrypted");
    }

    /// <summary>
    /// The instance_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
    {
        get => new TerraformReference<string>(this, "owner");
    }

    /// <summary>
    /// The parent_image attribute.
    /// </summary>
    public TerraformValue<string> ParentImage
    {
        get => new TerraformReference<string>(this, "parent_image");
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string> Platform
    {
        get => new TerraformReference<string>(this, "platform");
    }

    /// <summary>
    /// The target_repository attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TargetRepository
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "target_repository").ResolveNodes(ctx));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The working_directory attribute.
    /// </summary>
    public TerraformValue<string> WorkingDirectory
    {
        get => new TerraformReference<string>(this, "working_directory");
    }

}
