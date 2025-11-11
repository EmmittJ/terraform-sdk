using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entry_references in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexEntryLinkEntryReferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// The relative resource name of the referenced Entry, of the form:
    /// projects/{project_id_or_number}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The path in the Entry that is referenced in the Entry Link.
    /// Empty path denotes that the Entry itself is referenced in the Entry Link.
    /// </summary>
    [TerraformProperty("path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Path { get; set; }

    /// <summary>
    /// The reference type of the Entry. Possible values: [&amp;quot;SOURCE&amp;quot;, &amp;quot;TARGET&amp;quot;]
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataplexEntryLinkTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a google_dataplex_entry_link resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataplexEntryLink : TerraformResource
{
    public GoogleDataplexEntryLink(string name) : base("google_dataplex_entry_link", name)
    {
    }

    /// <summary>
    /// The id of the entry group this entry link is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroupId is required")]
    [TerraformProperty("entry_group_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EntryGroupId { get; set; }

    /// <summary>
    /// The id of the entry link to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkId is required")]
    [TerraformProperty("entry_link_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EntryLinkId { get; set; }

    /// <summary>
    /// Relative resource name of the Entry Link Type used to create this Entry Link. For example:
    /// projects/dataplex-types/locations/global/entryLinkTypes/definition
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkType is required")]
    [TerraformProperty("entry_link_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EntryLinkType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the entry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for entry_references.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryReferences is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntryReferences block(s) required")]
    [TerraformProperty("entry_references")]
    public TerraformList<TerraformBlock<GoogleDataplexEntryLinkEntryReferencesBlock>>? EntryReferences { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataplexEntryLinkTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the Entry Link was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The relative resource name of the Entry Link, of the form:
    /// projects/{project_id_or_number}/locations/{location_id}/entryGroups/{entry_group_id}/entryLinks/{entry_link_id}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The time when the Entry Link was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
