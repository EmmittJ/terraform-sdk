using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aspects in GoogleDataplexEntry.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryAspectsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aspects";

    /// <summary>
    /// Depending on how the aspect is attached to the entry, the format of the aspect key can be one of the following:
    /// 
    /// If the aspect is attached directly to the entry: {project_number}.{locationId}.{aspectTypeId}
    /// If the aspect is attached to an entry&#39;s path: {project_number}.{locationId}.{aspectTypeId}@{path}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AspectKey is required")]
    public required TerraformValue<string> AspectKey
    {
        get => GetArgument<TerraformValue<string>>("aspect_key");
        set => SetArgument("aspect_key", value);
    }

    /// <summary>
    /// Aspect block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Aspect is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Aspect block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aspect block(s) allowed")]
    public required TerraformList<GoogleDataplexEntryAspectsBlockAspectBlock> Aspect
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexEntryAspectsBlockAspectBlock>>("aspect");
        set => SetArgument("aspect", value);
    }

}

/// <summary>
/// Block type for aspect in GoogleDataplexEntryAspectsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryAspectsBlockAspectBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aspect";

    /// <summary>
    /// The resource name of the type used to create this Aspect.
    /// </summary>
    public TerraformValue<string> AspectType
        => AsReference("aspect_type");

    /// <summary>
    /// The time when the Aspect was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The content of the aspect in JSON form, according to its aspect type schema. The maximum size of the field is 120KB (encoded as UTF-8).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Data is required")]
    public required TerraformValue<string> Data
    {
        get => GetArgument<TerraformValue<string>>("data");
        set => SetArgument("data", value);
    }

    /// <summary>
    /// The path in the entry under which the aspect is attached.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The time when the Aspect was last modified.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}


/// <summary>
/// Block type for entry_source in GoogleDataplexEntry.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryEntrySourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entry_source";

    /// <summary>
    /// The time when the resource was created in the source system.
    /// </summary>
    public TerraformValue<string>? CreateTime
    {
        get => GetArgument<TerraformValue<string>>("create_time");
        set => SetArgument("create_time", value);
    }

    /// <summary>
    /// A description of the data resource. Maximum length is 2,000 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A user-friendly display name. Maximum length is 500 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// User-defined labels. The maximum size of keys and values is 128 characters each.
    /// An object containing a list of &amp;quot;key&amp;quot;: value pairs. Example: { &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Location of the resource in the source system. You can search the entry by this location.
    /// By default, this should match the location of the entry group containing this entry.
    /// A different value allows capturing the source location for data external to Google Cloud.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The platform containing the source system. Maximum length is 64 characters.
    /// </summary>
    public TerraformValue<string>? Platform
    {
        get => GetArgument<TerraformValue<string>>("platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// The name of the resource in the source system. Maximum length is 4,000 characters.
    /// </summary>
    public TerraformValue<string>? Resource
    {
        get => GetArgument<TerraformValue<string>>("resource");
        set => SetArgument("resource", value);
    }

    /// <summary>
    /// The name of the source system. Maximum length is 64 characters.
    /// </summary>
    public TerraformValue<string>? System
    {
        get => GetArgument<TerraformValue<string>>("system");
        set => SetArgument("system", value);
    }

    /// <summary>
    /// The time when the resource was last updated in the source system.
    /// If the entry exists in the system and its EntrySource has updateTime populated,
    /// further updates to the EntrySource of the entry must provide incremental updates to its updateTime.
    /// </summary>
    public TerraformValue<string>? UpdateTime
    {
        get => GetArgument<TerraformValue<string>>("update_time");
        set => SetArgument("update_time", value);
    }

    /// <summary>
    /// Ancestors block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataplexEntryEntrySourceBlockAncestorsBlock>? Ancestors
    {
        get => GetArgument<TerraformList<GoogleDataplexEntryEntrySourceBlockAncestorsBlock>>("ancestors");
        set => SetArgument("ancestors", value);
    }

}

/// <summary>
/// Block type for ancestors in GoogleDataplexEntryEntrySourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryEntrySourceBlockAncestorsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ancestors";

    /// <summary>
    /// The name of the ancestor resource.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type of the ancestor resource.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexEntry.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_dataplex_entry Terraform resource.
/// Manages a google_dataplex_entry resource.
/// </summary>
public partial class GoogleDataplexEntry(string name) : TerraformResource("google_dataplex_entry", name)
{
    /// <summary>
    /// The entry group id of the entry group the entry will be created in.
    /// </summary>
    public TerraformValue<string>? EntryGroupId
    {
        get => GetArgument<TerraformValue<string>>("entry_group_id");
        set => SetArgument("entry_group_id", value);
    }

    /// <summary>
    /// The entry id of the entry.
    /// </summary>
    public TerraformValue<string>? EntryId
    {
        get => GetArgument<TerraformValue<string>>("entry_id");
        set => SetArgument("entry_id", value);
    }

    /// <summary>
    /// The relative resource name of the entry type that was used to create this entry, in the format projects/{project_number}/locations/{locationId}/entryTypes/{entryTypeId}.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryType is required")]
    public required TerraformValue<string> EntryType
    {
        get => GetArgument<TerraformValue<string>>("entry_type");
        set => SetArgument("entry_type", value);
    }

    /// <summary>
    /// A name for the entry that can be referenced by an external system. For more information, see https://cloud.google.com/dataplex/docs/fully-qualified-names.
    /// The maximum size of the field is 4000 characters.
    /// </summary>
    public TerraformValue<string>? FullyQualifiedName
    {
        get => GetArgument<TerraformValue<string>>("fully_qualified_name");
        set => SetArgument("fully_qualified_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location where entry will be created.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the parent entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    public TerraformValue<string>? ParentEntry
    {
        get => GetArgument<TerraformValue<string>>("parent_entry");
        set => SetArgument("parent_entry", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The time when the Entry was created in Dataplex.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The relative resource name of the entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The time when the entry was last updated in Dataplex.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Aspects block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataplexEntryAspectsBlock>? Aspects
    {
        get => GetArgument<TerraformList<GoogleDataplexEntryAspectsBlock>>("aspects");
        set => SetArgument("aspects", value);
    }

    /// <summary>
    /// EntrySource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EntrySource block(s) allowed")]
    public TerraformList<GoogleDataplexEntryEntrySourceBlock>? EntrySource
    {
        get => GetArgument<TerraformList<GoogleDataplexEntryEntrySourceBlock>>("entry_source");
        set => SetArgument("entry_source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexEntryTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexEntryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
