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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The studio_lifecycle_config_app_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigAppType is required")]
    public required TerraformProperty<string> StudioLifecycleConfigAppType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("studio_lifecycle_config_app_type");
        set => this.WithProperty("studio_lifecycle_config_app_type", value);
    }

    /// <summary>
    /// The studio_lifecycle_config_content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigContent is required")]
    public required TerraformProperty<string> StudioLifecycleConfigContent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("studio_lifecycle_config_content");
        set => this.WithProperty("studio_lifecycle_config_content", value);
    }

    /// <summary>
    /// The studio_lifecycle_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StudioLifecycleConfigName is required")]
    public required TerraformProperty<string> StudioLifecycleConfigName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("studio_lifecycle_config_name");
        set => this.WithProperty("studio_lifecycle_config_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
