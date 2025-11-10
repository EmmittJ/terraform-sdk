using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ui_template in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerHumanTaskUiUiTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformProperty<string>? Content
    {
        get => GetProperty<TerraformProperty<string>>("content");
        set => WithProperty("content", value);
    }

    /// <summary>
    /// The content_sha256 attribute.
    /// </summary>
    public TerraformProperty<string>? ContentSha256
    {
        get => GetProperty<TerraformProperty<string>>("content_sha256");
        set => WithProperty("content_sha256", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_human_task_ui resource.
/// </summary>
public class AwsSagemakerHumanTaskUi : TerraformResource
{
    public AwsSagemakerHumanTaskUi(string name) : base("aws_sagemaker_human_task_ui", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The human_task_ui_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiName is required")]
    public required TerraformProperty<string> HumanTaskUiName
    {
        get => GetProperty<TerraformProperty<string>>("human_task_ui_name");
        set => this.WithProperty("human_task_ui_name", value);
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
    /// Block for ui_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UiTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UiTemplate block(s) allowed")]
    public List<AwsSagemakerHumanTaskUiUiTemplateBlock>? UiTemplate
    {
        get => GetProperty<List<AwsSagemakerHumanTaskUiUiTemplateBlock>>("ui_template");
        set => this.WithProperty("ui_template", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
