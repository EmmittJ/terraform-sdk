using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aspects in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryAspectsBlock : TerraformBlock
{
    /// <summary>
    /// Depending on how the aspect is attached to the entry, the format of the aspect key can be one of the following:
    /// 
    /// If the aspect is attached directly to the entry: {project_number}.{locationId}.{aspectTypeId}
    /// If the aspect is attached to an entry&#39;s path: {project_number}.{locationId}.{aspectTypeId}@{path}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AspectKey is required")]
    public required TerraformProperty<string> AspectKey
    {
        get => GetProperty<TerraformProperty<string>>("aspect_key");
        set => WithProperty("aspect_key", value);
    }

}

/// <summary>
/// Block type for entry_source in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryEntrySourceBlock : TerraformBlock
{
    /// <summary>
    /// The time when the resource was created in the source system.
    /// </summary>
    public TerraformProperty<string>? CreateTime
    {
        get => GetProperty<TerraformProperty<string>>("create_time");
        set => WithProperty("create_time", value);
    }

    /// <summary>
    /// A description of the data resource. Maximum length is 2,000 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// A user-friendly display name. Maximum length is 500 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// User-defined labels. The maximum size of keys and values is 128 characters each.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// Location of the resource in the source system. You can search the entry by this location.
    /// By default, this should match the location of the entry group containing this entry.
    /// A different value allows capturing the source location for data external to Google Cloud.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// The platform containing the source system. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? Platform
    {
        get => GetProperty<TerraformProperty<string>>("platform");
        set => WithProperty("platform", value);
    }

    /// <summary>
    /// The name of the resource in the source system. Maximum length is 4,000 characters.
    /// </summary>
    public TerraformProperty<string>? Resource
    {
        get => GetProperty<TerraformProperty<string>>("resource");
        set => WithProperty("resource", value);
    }

    /// <summary>
    /// The name of the source system. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? System
    {
        get => GetProperty<TerraformProperty<string>>("system");
        set => WithProperty("system", value);
    }

    /// <summary>
    /// The time when the resource was last updated in the source system.
    /// If the entry exists in the system and its EntrySource has updateTime populated,
    /// further updates to the EntrySource of the entry must provide incremental updates to its updateTime.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        get => GetProperty<TerraformProperty<string>>("update_time");
        set => WithProperty("update_time", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataplex_entry resource.
/// </summary>
public class GoogleDataplexEntry : TerraformResource
{
    public GoogleDataplexEntry(string name) : base("google_dataplex_entry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The entry group id of the entry group the entry will be created in.
    /// </summary>
    public TerraformProperty<string>? EntryGroupId
    {
        get => GetProperty<TerraformProperty<string>>("entry_group_id");
        set => this.WithProperty("entry_group_id", value);
    }

    /// <summary>
    /// The entry id of the entry.
    /// </summary>
    public TerraformProperty<string>? EntryId
    {
        get => GetProperty<TerraformProperty<string>>("entry_id");
        set => this.WithProperty("entry_id", value);
    }

    /// <summary>
    /// The relative resource name of the entry type that was used to create this entry, in the format projects/{project_number}/locations/{locationId}/entryTypes/{entryTypeId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryType is required")]
    public required TerraformProperty<string> EntryType
    {
        get => GetProperty<TerraformProperty<string>>("entry_type");
        set => this.WithProperty("entry_type", value);
    }

    /// <summary>
    /// A name for the entry that can be referenced by an external system. For more information, see https://cloud.google.com/dataplex/docs/fully-qualified-names.
    /// The maximum size of the field is 4000 characters.
    /// </summary>
    public TerraformProperty<string>? FullyQualifiedName
    {
        get => GetProperty<TerraformProperty<string>>("fully_qualified_name");
        set => this.WithProperty("fully_qualified_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location where entry will be created.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the parent entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    public TerraformProperty<string>? ParentEntry
    {
        get => GetProperty<TerraformProperty<string>>("parent_entry");
        set => this.WithProperty("parent_entry", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for aspects.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataplexEntryAspectsBlock>? Aspects
    {
        get => GetProperty<List<GoogleDataplexEntryAspectsBlock>>("aspects");
        set => this.WithProperty("aspects", value);
    }

    /// <summary>
    /// Block for entry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntrySource block(s) allowed")]
    public List<GoogleDataplexEntryEntrySourceBlock>? EntrySource
    {
        get => GetProperty<List<GoogleDataplexEntryEntrySourceBlock>>("entry_source");
        set => this.WithProperty("entry_source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexEntryTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataplexEntryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the Entry was created in Dataplex.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The relative resource name of the entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time when the entry was last updated in Dataplex.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
