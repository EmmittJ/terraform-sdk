using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexAspectTypeIamBindingConditionBlock() : TerraformBlock("condition")
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
/// Manages a google_dataplex_aspect_type_iam_binding resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataplexAspectTypeIamBinding : TerraformResource
{
    public GoogleDataplexAspectTypeIamBinding(string name) : base("google_dataplex_aspect_type_iam_binding", name)
    {
    }

    /// <summary>
    /// The aspect_type_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AspectTypeId is required")]
    [TerraformProperty("aspect_type_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AspectTypeId { get; set; }

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
    /// The members attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Members is required")]
    [TerraformProperty("members")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Members { get; set; }

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
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformProperty("condition")]
    public TerraformList<GoogleDataplexAspectTypeIamBindingConditionBlock> Condition { get; set; } = new();

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

}
