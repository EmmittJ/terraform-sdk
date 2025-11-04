using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_model_package_group resource.
/// </summary>
public class AwsSagemakerModelPackageGroup : TerraformResource
{
    public AwsSagemakerModelPackageGroup(string name) : base("aws_sagemaker_model_package_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The model_package_group_description attribute.
    /// </summary>
    public string? ModelPackageGroupDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_package_group_description")?.Value;
        set => this.WithProperty("model_package_group_description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
