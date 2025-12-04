using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entry_references in GoogleDataplexEntryLink.
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryLinkEntryReferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "entry_references";

    /// <summary>
    /// The relative resource name of the referenced Entry, of the form:
    /// projects/{project_id_or_number}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The path in the Entry that is referenced in the Entry Link.
    /// Empty path denotes that the Entry itself is referenced in the Entry Link.
    /// </summary>
    public TerraformValue<string>? Path
    {
        get => GetArgument<TerraformValue<string>>("path");
        set => SetArgument("path", value);
    }

    /// <summary>
    /// The reference type of the Entry. Possible values: [&amp;quot;SOURCE&amp;quot;, &amp;quot;TARGET&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleDataplexEntryLink.
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryLinkTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_dataplex_entry_link Terraform resource.
/// Manages a google_dataplex_entry_link resource.
/// </summary>
public partial class GoogleDataplexEntryLink(string name) : TerraformResource("google_dataplex_entry_link", name)
{
    /// <summary>
    /// The id of the entry group this entry link is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroupId is required")]
    public required TerraformValue<string> EntryGroupId
    {
        get => GetArgument<TerraformValue<string>>("entry_group_id");
        set => SetArgument("entry_group_id", value);
    }

    /// <summary>
    /// The id of the entry link to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkId is required")]
    public required TerraformValue<string> EntryLinkId
    {
        get => GetArgument<TerraformValue<string>>("entry_link_id");
        set => SetArgument("entry_link_id", value);
    }

    /// <summary>
    /// Relative resource name of the Entry Link Type used to create this Entry Link. For example:
    /// projects/dataplex-types/locations/global/entryLinkTypes/definition
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkType is required")]
    public required TerraformValue<string> EntryLinkType
    {
        get => GetArgument<TerraformValue<string>>("entry_link_type");
        set => SetArgument("entry_link_type", value);
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
    /// The location for the entry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The time when the Entry Link was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The relative resource name of the Entry Link, of the form:
    /// projects/{project_id_or_number}/locations/{location_id}/entryGroups/{entry_group_id}/entryLinks/{entry_link_id}
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The time when the Entry Link was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// EntryReferences block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryReferences is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntryReferences block(s) required")]
    public required TerraformList<GoogleDataplexEntryLinkEntryReferencesBlock> EntryReferences
    {
        get => GetRequiredArgument<TerraformList<GoogleDataplexEntryLinkEntryReferencesBlock>>("entry_references");
        set => SetArgument("entry_references", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataplexEntryLinkTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataplexEntryLinkTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
