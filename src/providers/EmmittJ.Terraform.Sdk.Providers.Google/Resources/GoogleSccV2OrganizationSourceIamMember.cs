using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class GoogleSccV2OrganizationSourceIamMemberConditionBlock() : TerraformBlock("condition")
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
/// Manages a google_scc_v2_organization_source_iam_member resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleSccV2OrganizationSourceIamMember : TerraformResource
{
    public GoogleSccV2OrganizationSourceIamMember(string name) : base("google_scc_v2_organization_source_iam_member", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The member attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Member is required")]
    [TerraformProperty("member")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Member { get; set; }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformProperty("organization")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Organization { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [TerraformProperty("source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Source { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformProperty("condition")]
    public TerraformList<GoogleSccV2OrganizationSourceIamMemberConditionBlock> Condition { get; set; } = new();

    /// <summary>
    /// The etag attribute.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

}
