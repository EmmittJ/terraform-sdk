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
    /// The resource_policy attribute.
    /// </summary>
    public string? ResourcePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_policy")?.Value;
        set => this.WithProperty("resource_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
