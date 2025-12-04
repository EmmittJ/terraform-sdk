using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_model_package_group Terraform resource.
/// Manages a aws_sagemaker_model_package_group resource.
/// </summary>
public partial class AwsSagemakerModelPackageGroup(string name) : TerraformResource("aws_sagemaker_model_package_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The model_package_group_description attribute.
    /// </summary>
    public TerraformValue<string>? ModelPackageGroupDescription
    {
        get => GetArgument<TerraformValue<string>>("model_package_group_description");
        set => SetArgument("model_package_group_description", value);
    }

    /// <summary>
    /// The model_package_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelPackageGroupName is required")]
    public required TerraformValue<string> ModelPackageGroupName
    {
        get => GetArgument<TerraformValue<string>>("model_package_group_name");
        set => SetArgument("model_package_group_name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
