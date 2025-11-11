using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ui_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerHumanTaskUiUiTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The content attribute.
    /// </summary>
    [TerraformProperty("content")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Content { get; set; }



}

/// <summary>
/// Manages a aws_sagemaker_human_task_ui resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerHumanTaskUi : TerraformResource
{
    public AwsSagemakerHumanTaskUi(string name) : base("aws_sagemaker_human_task_ui", name)
    {
    }

    /// <summary>
    /// The human_task_ui_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HumanTaskUiName is required")]
    [TerraformProperty("human_task_ui_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HumanTaskUiName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for ui_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UiTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 UiTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UiTemplate block(s) allowed")]
    [TerraformProperty("ui_template")]
    public TerraformList<TerraformBlock<AwsSagemakerHumanTaskUiUiTemplateBlock>>? UiTemplate { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
