using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aspects in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryAspectsBlock : ITerraformBlock
{
    /// <summary>
    /// Depending on how the aspect is attached to the entry, the format of the aspect key can be one of the following:
    /// 
    /// If the aspect is attached directly to the entry: {project_number}.{locationId}.{aspectTypeId}
    /// If the aspect is attached to an entry&#39;s path: {project_number}.{locationId}.{aspectTypeId}@{path}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AspectKey is required")]
    [TerraformPropertyName("aspect_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AspectKey { get; set; }

}

/// <summary>
/// Block type for entry_source in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryEntrySourceBlock : ITerraformBlock
{
    /// <summary>
    /// The time when the resource was created in the source system.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CreateTime { get; set; }

    /// <summary>
    /// A description of the data resource. Maximum length is 2,000 characters.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// A user-friendly display name. Maximum length is 500 characters.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// User-defined labels. The maximum size of keys and values is 128 characters each.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// Location of the resource in the source system. You can search the entry by this location.
    /// By default, this should match the location of the entry group containing this entry.
    /// A different value allows capturing the source location for data external to Google Cloud.
    /// </summary>
    [TerraformPropertyName("location")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>("", "location");

    /// <summary>
    /// The platform containing the source system. Maximum length is 64 characters.
    /// </summary>
    [TerraformPropertyName("platform")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Platform { get; set; }

    /// <summary>
    /// The name of the resource in the source system. Maximum length is 4,000 characters.
    /// </summary>
    [TerraformPropertyName("resource")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Resource { get; set; }

    /// <summary>
    /// The name of the source system. Maximum length is 64 characters.
    /// </summary>
    [TerraformPropertyName("system")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? System { get; set; }

    /// <summary>
    /// The time when the resource was last updated in the source system.
    /// If the entry exists in the system and its EntrySource has updateTime populated,
    /// further updates to the EntrySource of the entry must provide incremental updates to its updateTime.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UpdateTime { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_dataplex_entry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexEntry : TerraformResource
{
    public GoogleDataplexEntry(string name) : base("google_dataplex_entry", name)
    {
    }

    /// <summary>
    /// The entry group id of the entry group the entry will be created in.
    /// </summary>
    [TerraformPropertyName("entry_group_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EntryGroupId { get; set; }

    /// <summary>
    /// The entry id of the entry.
    /// </summary>
    [TerraformPropertyName("entry_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EntryId { get; set; }

    /// <summary>
    /// The relative resource name of the entry type that was used to create this entry, in the format projects/{project_number}/locations/{locationId}/entryTypes/{entryTypeId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryType is required")]
    [TerraformPropertyName("entry_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EntryType { get; set; }

    /// <summary>
    /// A name for the entry that can be referenced by an external system. For more information, see https://cloud.google.com/dataplex/docs/fully-qualified-names.
    /// The maximum size of the field is 4000 characters.
    /// </summary>
    [TerraformPropertyName("fully_qualified_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FullyQualifiedName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location where entry will be created.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The resource name of the parent entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    [TerraformPropertyName("parent_entry")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ParentEntry { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for aspects.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("aspects")]
    public TerraformList<TerraformBlock<GoogleDataplexEntryAspectsBlock>>? Aspects { get; set; } = new();

    /// <summary>
    /// Block for entry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntrySource block(s) allowed")]
    [TerraformPropertyName("entry_source")]
    public TerraformList<TerraformBlock<GoogleDataplexEntryEntrySourceBlock>>? EntrySource { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataplexEntryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The time when the Entry was created in Dataplex.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The relative resource name of the entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The time when the entry was last updated in Dataplex.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
