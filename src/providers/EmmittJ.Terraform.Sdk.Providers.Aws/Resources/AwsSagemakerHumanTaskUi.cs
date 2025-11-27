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
        get => new TerraformReference<string>(this, "content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The content_sha256 attribute.
    /// </summary>
    public TerraformValue<string> ContentSha256
    {
        get => new TerraformReference<string>(this, "content_sha256");
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

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
        get => new TerraformReference<string>(this, "human_task_ui_name");
        set => SetArgument("human_task_ui_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

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
