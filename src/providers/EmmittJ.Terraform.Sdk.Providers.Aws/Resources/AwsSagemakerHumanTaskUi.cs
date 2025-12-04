using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ui_template in AwsSagemakerHumanTaskUi.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerHumanTaskUiUiTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ui_template";

    /// <summary>
    /// The content attribute.
    /// </summary>
    public TerraformValue<string>? Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The content_sha256 attribute.
    /// </summary>
    public TerraformValue<string> ContentSha256
        => AsReference("content_sha256");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

}


/// <summary>
/// Represents a aws_sagemaker_human_task_ui Terraform resource.
/// Manages a aws_sagemaker_human_task_ui resource.
/// </summary>
public partial class AwsSagemakerHumanTaskUi(string name) : TerraformResource("aws_sagemaker_human_task_ui", name)
{
    /// <summary>
    /// The human_task_ui_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiName is required")]
    public required TerraformValue<string> HumanTaskUiName
    {
        get => GetArgument<TerraformValue<string>>("human_task_ui_name");
        set => SetArgument("human_task_ui_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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

    /// <summary>
    /// UiTemplate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UiTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UiTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UiTemplate block(s) allowed")]
    public required TerraformList<AwsSagemakerHumanTaskUiUiTemplateBlock> UiTemplate
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerHumanTaskUiUiTemplateBlock>>("ui_template");
        set => SetArgument("ui_template", value);
    }

}
