using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_studio_lifecycle_config resource.
/// </summary>
public class AwsSagemakerStudioLifecycleConfig : TerraformResource
{
    public AwsSagemakerStudioLifecycleConfig(string name) : base("aws_sagemaker_studio_lifecycle_config", name)
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
    /// The studio_lifecycle_config_app_type attribute.
    /// </summary>
    public string? StudioLifecycleConfigAppType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("studio_lifecycle_config_app_type")?.Value;
        set => this.WithProperty("studio_lifecycle_config_app_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The studio_lifecycle_config_content attribute.
    /// </summary>
    public string? StudioLifecycleConfigContent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("studio_lifecycle_config_content")?.Value;
        set => this.WithProperty("studio_lifecycle_config_content", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The studio_lifecycle_config_name attribute.
    /// </summary>
    public string? StudioLifecycleConfigName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("studio_lifecycle_config_name")?.Value;
        set => this.WithProperty("studio_lifecycle_config_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
