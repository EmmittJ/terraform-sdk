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
        set => SetProperty("aspect_key", value);
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
        set => SetProperty("create_time", value);
    }

    /// <summary>
    /// A description of the data resource. Maximum length is 2,000 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A user-friendly display name. Maximum length is 500 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// User-defined labels. The maximum size of keys and values is 128 characters each.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// Location of the resource in the source system. You can search the entry by this location.
    /// By default, this should match the location of the entry group containing this entry.
    /// A different value allows capturing the source location for data external to Google Cloud.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The platform containing the source system. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? Platform
    {
        set => SetProperty("platform", value);
    }

    /// <summary>
    /// The name of the resource in the source system. Maximum length is 4,000 characters.
    /// </summary>
    public TerraformProperty<string>? Resource
    {
        set => SetProperty("resource", value);
    }

    /// <summary>
    /// The name of the source system. Maximum length is 64 characters.
    /// </summary>
    public TerraformProperty<string>? System
    {
        set => SetProperty("system", value);
    }

    /// <summary>
    /// The time when the resource was last updated in the source system.
    /// If the entry exists in the system and its EntrySource has updateTime populated,
    /// further updates to the EntrySource of the entry must provide incremental updates to its updateTime.
    /// </summary>
    public TerraformProperty<string>? UpdateTime
    {
        set => SetProperty("update_time", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_dataplex_entry resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexEntry : TerraformResource
{
    public GoogleDataplexEntry(string name) : base("google_dataplex_entry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("entry_group_id");
        SetOutput("entry_id");
        SetOutput("entry_type");
        SetOutput("fully_qualified_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("parent_entry");
        SetOutput("project");
    }

    /// <summary>
    /// The entry group id of the entry group the entry will be created in.
    /// </summary>
    public TerraformProperty<string> EntryGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_group_id");
        set => SetProperty("entry_group_id", value);
    }

    /// <summary>
    /// The entry id of the entry.
    /// </summary>
    public TerraformProperty<string> EntryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_id");
        set => SetProperty("entry_id", value);
    }

    /// <summary>
    /// The relative resource name of the entry type that was used to create this entry, in the format projects/{project_number}/locations/{locationId}/entryTypes/{entryTypeId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryType is required")]
    public required TerraformProperty<string> EntryType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_type");
        set => SetProperty("entry_type", value);
    }

    /// <summary>
    /// A name for the entry that can be referenced by an external system. For more information, see https://cloud.google.com/dataplex/docs/fully-qualified-names.
    /// The maximum size of the field is 4000 characters.
    /// </summary>
    public TerraformProperty<string> FullyQualifiedName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("fully_qualified_name");
        set => SetProperty("fully_qualified_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location where entry will be created.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource name of the parent entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    public TerraformProperty<string> ParentEntry
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent_entry");
        set => SetProperty("parent_entry", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for aspects.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleDataplexEntryAspectsBlock>? Aspects
    {
        set => SetProperty("aspects", value);
    }

    /// <summary>
    /// Block for entry_source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntrySource block(s) allowed")]
    public List<GoogleDataplexEntryEntrySourceBlock>? EntrySource
    {
        set => SetProperty("entry_source", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexEntryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
