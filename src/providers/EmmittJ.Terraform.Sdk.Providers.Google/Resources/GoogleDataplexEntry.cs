using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aspects in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexEntryAspectsBlock : TerraformBlockBase
{
    /// <summary>
    /// Depending on how the aspect is attached to the entry, the format of the aspect key can be one of the following:
    /// 
    /// If the aspect is attached directly to the entry: {project_number}.{locationId}.{aspectTypeId}
    /// If the aspect is attached to an entry&#39;s path: {project_number}.{locationId}.{aspectTypeId}@{path}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AspectKey is required")]
    [TerraformProperty("aspect_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AspectKey { get; set; }

}

/// <summary>
/// Block type for entry_source in .
/// Nesting mode: list
/// </summary>
public partial class GoogleDataplexEntryEntrySourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The time when the resource was created in the source system.
    /// </summary>
    [TerraformProperty("create_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateTime { get; set; }

    /// <summary>
    /// A description of the data resource. Maximum length is 2,000 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A user-friendly display name. Maximum length is 500 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// User-defined labels. The maximum size of keys and values is 128 characters each.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Labels { get; set; }


    /// <summary>
    /// The platform containing the source system. Maximum length is 64 characters.
    /// </summary>
    [TerraformProperty("platform")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Platform { get; set; }

    /// <summary>
    /// The name of the resource in the source system. Maximum length is 4,000 characters.
    /// </summary>
    [TerraformProperty("resource")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Resource { get; set; }

    /// <summary>
    /// The name of the source system. Maximum length is 64 characters.
    /// </summary>
    [TerraformProperty("system")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? System { get; set; }

    /// <summary>
    /// The time when the resource was last updated in the source system.
    /// If the entry exists in the system and its EntrySource has updateTime populated,
    /// further updates to the EntrySource of the entry must provide incremental updates to its updateTime.
    /// </summary>
    [TerraformProperty("update_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UpdateTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleDataplexEntryTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataplex_entry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleDataplexEntry : TerraformResource
{
    public GoogleDataplexEntry(string name) : base("google_dataplex_entry", name)
    {
    }

    /// <summary>
    /// The entry group id of the entry group the entry will be created in.
    /// </summary>
    [TerraformProperty("entry_group_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EntryGroupId { get; set; }

    /// <summary>
    /// The entry id of the entry.
    /// </summary>
    [TerraformProperty("entry_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EntryId { get; set; }

    /// <summary>
    /// The relative resource name of the entry type that was used to create this entry, in the format projects/{project_number}/locations/{locationId}/entryTypes/{entryTypeId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryType is required")]
    [TerraformProperty("entry_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EntryType { get; set; }

    /// <summary>
    /// A name for the entry that can be referenced by an external system. For more information, see https://cloud.google.com/dataplex/docs/fully-qualified-names.
    /// The maximum size of the field is 4000 characters.
    /// </summary>
    [TerraformProperty("fully_qualified_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FullyQualifiedName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location where entry will be created.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The resource name of the parent entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    [TerraformProperty("parent_entry")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ParentEntry { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for aspects.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("aspects")]
    public TerraformList<TerraformBlock<GoogleDataplexEntryAspectsBlock>>? Aspects { get; set; }

    /// <summary>
    /// Block for entry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntrySource block(s) allowed")]
    [TerraformProperty("entry_source")]
    public TerraformList<TerraformBlock<GoogleDataplexEntryEntrySourceBlock>>? EntrySource { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleDataplexEntryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The time when the Entry was created in Dataplex.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The relative resource name of the entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The time when the entry was last updated in Dataplex.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
