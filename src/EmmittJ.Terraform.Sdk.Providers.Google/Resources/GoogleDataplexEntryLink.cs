using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for entry_references in .
/// Nesting mode: list
/// </summary>
public class GoogleDataplexEntryLinkEntryReferencesBlock : TerraformBlock
{
    /// <summary>
    /// The relative resource name of the referenced Entry, of the form:
    /// projects/{project_id_or_number}/locations/{location_id}/entryGroups/{entry_group_id}/entries/{entry_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The path in the Entry that is referenced in the Entry Link.
    /// Empty path denotes that the Entry itself is referenced in the Entry Link.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The reference type of the Entry. Possible values: [&amp;quot;SOURCE&amp;quot;, &amp;quot;TARGET&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataplexEntryLinkTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_dataplex_entry_link resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleDataplexEntryLink : TerraformResource
{
    public GoogleDataplexEntryLink(string name) : base("google_dataplex_entry_link", name)
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
    /// The id of the entry group this entry link is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroupId is required")]
    public required TerraformProperty<string> EntryGroupId
    {
        get => GetProperty<TerraformProperty<string>>("entry_group_id");
        set => this.WithProperty("entry_group_id", value);
    }

    /// <summary>
    /// The id of the entry link to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkId is required")]
    public required TerraformProperty<string> EntryLinkId
    {
        get => GetProperty<TerraformProperty<string>>("entry_link_id");
        set => this.WithProperty("entry_link_id", value);
    }

    /// <summary>
    /// Relative resource name of the Entry Link Type used to create this Entry Link. For example:
    /// projects/dataplex-types/locations/global/entryLinkTypes/definition
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkType is required")]
    public required TerraformProperty<string> EntryLinkType
    {
        get => GetProperty<TerraformProperty<string>>("entry_link_type");
        set => this.WithProperty("entry_link_type", value);
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
    /// The location for the entry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// Block for entry_references.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntryReferences block(s) required")]
    public List<GoogleDataplexEntryLinkEntryReferencesBlock>? EntryReferences
    {
        get => GetProperty<List<GoogleDataplexEntryLinkEntryReferencesBlock>>("entry_references");
        set => this.WithProperty("entry_references", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexEntryLinkTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataplexEntryLinkTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time when the Entry Link was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The relative resource name of the Entry Link, of the form:
    /// projects/{project_id_or_number}/locations/{location_id}/entryGroups/{entry_group_id}/entryLinks/{entry_link_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time when the Entry Link was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
