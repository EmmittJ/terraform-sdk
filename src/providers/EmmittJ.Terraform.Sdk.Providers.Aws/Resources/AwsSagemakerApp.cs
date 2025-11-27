using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resource_spec in AwsSagemakerApp.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerAppResourceSpecBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_spec";

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string>? InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The lifecycle_config_arn attribute.
    /// </summary>
    public TerraformValue<string>? LifecycleConfigArn
    {
        get => new TerraformReference<string>(this, "lifecycle_config_arn");
        set => SetArgument("lifecycle_config_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_arn attribute.
    /// </summary>
    public TerraformValue<string> SagemakerImageArn
    {
        get => new TerraformReference<string>(this, "sagemaker_image_arn");
        set => SetArgument("sagemaker_image_arn", value);
    }

    /// <summary>
    /// The sagemaker_image_version_alias attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionAlias
    {
        get => new TerraformReference<string>(this, "sagemaker_image_version_alias");
        set => SetArgument("sagemaker_image_version_alias", value);
    }

    /// <summary>
    /// The sagemaker_image_version_arn attribute.
    /// </summary>
    public TerraformValue<string>? SagemakerImageVersionArn
    {
        get => new TerraformReference<string>(this, "sagemaker_image_version_arn");
        set => SetArgument("sagemaker_image_version_arn", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_app Terraform resource.
/// Manages a aws_sagemaker_app resource.
/// </summary>
public partial class AwsSagemakerApp(string name) : TerraformResource("aws_sagemaker_app", name)
{
    /// <summary>
    /// The app_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppName is required")]
    public required TerraformValue<string> AppName
    {
        get => new TerraformReference<string>(this, "app_name");
        set => SetArgument("app_name", value);
    }

    /// <summary>
    /// The app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppType is required")]
    public required TerraformValue<string> AppType
    {
        get => new TerraformReference<string>(this, "app_type");
        set => SetArgument("app_type", value);
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainId is required")]
    public required TerraformValue<string> DomainId
    {
        get => new TerraformReference<string>(this, "domain_id");
        set => SetArgument("domain_id", value);
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
    /// The space_name attribute.
    /// </summary>
    public TerraformValue<string>? SpaceName
    {
        get => new TerraformReference<string>(this, "space_name");
        set => SetArgument("space_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? UserProfileName
    {
        get => new TerraformReference<string>(this, "user_profile_name");
        set => SetArgument("user_profile_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// ResourceSpec block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourceSpec block(s) allowed")]
    public TerraformList<AwsSagemakerAppResourceSpecBlock>? ResourceSpec
    {
        get => GetArgument<TerraformList<AwsSagemakerAppResourceSpecBlock>>("resource_spec");
        set => SetArgument("resource_spec", value);
    }

}
