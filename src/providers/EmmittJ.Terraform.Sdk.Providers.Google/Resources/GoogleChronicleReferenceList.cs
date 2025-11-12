using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entries in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleReferenceListEntriesBlock() : TerraformBlock("entries")
{
    /// <summary>
    /// Required. The value of the entry. Maximum length is 512 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for scope_info in .
/// Nesting mode: list
/// </summary>
public partial class GoogleChronicleReferenceListScopeInfoBlock() : TerraformBlock("scope_info")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleChronicleReferenceListTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_chronicle_reference_list resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleChronicleReferenceList : TerraformResource
{
    public GoogleChronicleReferenceList(string name) : base("google_chronicle_reference_list", name)
    {
    }

    /// <summary>
    /// Required. A user-provided description of the reference list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The unique identifier for the Chronicle instance, which is the same as the customer ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The location of the resource. This is the geographical region where the Chronicle instance resides, such as &amp;quot;us&amp;quot; or &amp;quot;europe-west2&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Required. The ID to use for the reference list. This is also the display name for
    /// the reference list. It must satisfy the following requirements:
    /// - Starts with letter.
    /// - Contains only letters, numbers and underscore.
    /// - Has length &amp;lt; 256.
    /// - Must be unique.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceListId is required")]
    [TerraformProperty("reference_list_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReferenceListId { get; set; }

    /// <summary>
    /// Possible values:
    /// REFERENCE_LIST_SYNTAX_TYPE_PLAIN_TEXT_STRING
    /// REFERENCE_LIST_SYNTAX_TYPE_REGEX
    /// REFERENCE_LIST_SYNTAX_TYPE_CIDR
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SyntaxType is required")]
    [TerraformProperty("syntax_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SyntaxType { get; set; }

    /// <summary>
    /// Block for entries.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Entries is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Entries block(s) required")]
    [TerraformProperty("entries")]
    public required TerraformList<GoogleChronicleReferenceListEntriesBlock> Entries { get; set; } = new();

    /// <summary>
    /// Block for scope_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScopeInfo block(s) allowed")]
    [TerraformProperty("scope_info")]
    public TerraformList<GoogleChronicleReferenceListScopeInfoBlock> ScopeInfo { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleChronicleReferenceListTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The unique display name of the reference list.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// Output only. The resource name of the reference list.
    /// Format:
    /// projects/{project}/locations/{location}/instances/{instance}/referenceLists/{reference_list}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The timestamp when the reference list was last updated.
    /// </summary>
    [TerraformProperty("revision_create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionCreateTime { get; }

    /// <summary>
    /// Output only. The count of self-authored rules using the reference list.
    /// </summary>
    [TerraformProperty("rule_associations_count")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> RuleAssociationsCount { get; }

    /// <summary>
    /// Output only. The resource names for the associated self-authored Rules that use this
    /// reference list.
    /// This is returned only when the view is REFERENCE_LIST_VIEW_FULL.
    /// </summary>
    [TerraformProperty("rules")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Rules { get; }

}
