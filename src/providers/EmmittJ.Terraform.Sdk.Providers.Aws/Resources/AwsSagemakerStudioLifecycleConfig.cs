using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_studio_lifecycle_config Terraform resource.
/// Manages a aws_sagemaker_studio_lifecycle_config resource.
/// </summary>
public partial class AwsSagemakerStudioLifecycleConfig(string name) : TerraformResource("aws_sagemaker_studio_lifecycle_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The studio_lifecycle_config_app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigAppType is required")]
    public required TerraformValue<string> StudioLifecycleConfigAppType
    {
        get => GetRequiredArgument<TerraformValue<string>>("studio_lifecycle_config_app_type");
        set => SetArgument("studio_lifecycle_config_app_type", value);
    }

    /// <summary>
    /// The studio_lifecycle_config_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigContent is required")]
    public required TerraformValue<string> StudioLifecycleConfigContent
    {
        get => GetRequiredArgument<TerraformValue<string>>("studio_lifecycle_config_content");
        set => SetArgument("studio_lifecycle_config_content", value);
    }

    /// <summary>
    /// The studio_lifecycle_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigName is required")]
    public required TerraformValue<string> StudioLifecycleConfigName
    {
        get => GetRequiredArgument<TerraformValue<string>>("studio_lifecycle_config_name");
        set => SetArgument("studio_lifecycle_config_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
