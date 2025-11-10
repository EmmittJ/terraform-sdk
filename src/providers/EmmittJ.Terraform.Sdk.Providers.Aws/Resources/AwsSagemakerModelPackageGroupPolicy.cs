using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_model_package_group_policy resource.
/// </summary>
public class AwsSagemakerModelPackageGroupPolicy : TerraformResource
{
    public AwsSagemakerModelPackageGroupPolicy(string name) : base("aws_sagemaker_model_package_group_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("model_package_group_name");
        SetOutput("region");
        SetOutput("resource_policy");
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
    /// The model_package_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelPackageGroupName is required")]
    public required TerraformProperty<string> ModelPackageGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_package_group_name");
        set => SetProperty("model_package_group_name", value);
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
    /// The resource_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourcePolicy is required")]
    public required TerraformProperty<string> ResourcePolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_policy");
        set => SetProperty("resource_policy", value);
    }

}
