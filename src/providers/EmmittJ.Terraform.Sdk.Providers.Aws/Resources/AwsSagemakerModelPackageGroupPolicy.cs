using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_model_package_group_policy Terraform resource.
/// Manages a aws_sagemaker_model_package_group_policy resource.
/// </summary>
public partial class AwsSagemakerModelPackageGroupPolicy(string name) : TerraformResource("aws_sagemaker_model_package_group_policy", name)
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
    /// The model_package_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelPackageGroupName is required")]
    public required TerraformValue<string> ModelPackageGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("model_package_group_name");
        set => SetArgument("model_package_group_name", value);
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
    /// The resource_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourcePolicy is required")]
    public required TerraformValue<string> ResourcePolicy
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_policy");
        set => SetArgument("resource_policy", value);
    }

}
