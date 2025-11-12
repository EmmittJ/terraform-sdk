using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class GoogleColabRuntimeTemplateIamMemberConditionBlock() : TerraformBlock("condition")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    [TerraformProperty("expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Expression { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformProperty("title")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Title { get; set; }

}

/// <summary>
/// Manages a google_colab_runtime_template_iam_member resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleColabRuntimeTemplateIamMember : TerraformResource
{
    public GoogleColabRuntimeTemplateIamMember(string name) : base("google_colab_runtime_template_iam_member", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The member attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Member is required")]
    [TerraformProperty("member")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Member { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The runtime_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeTemplate is required")]
    [TerraformProperty("runtime_template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuntimeTemplate { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformProperty("condition")]
    public TerraformList<GoogleColabRuntimeTemplateIamMemberConditionBlock> Condition { get; set; } = new();

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

}
