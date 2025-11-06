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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The model_package_group_name attribute.
    /// </summary>
    public string? ModelPackageGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_package_group_name")?.Value;
        set => this.WithProperty("model_package_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_policy attribute.
    /// </summary>
    public string? ResourcePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_policy")?.Value;
        set => this.WithProperty("resource_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
