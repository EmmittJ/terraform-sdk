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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The path in the Entry that is referenced in the Entry Link.
    /// Empty path denotes that the Entry itself is referenced in the Entry Link.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The reference type of the Entry. Possible values: [&amp;quot;SOURCE&amp;quot;, &amp;quot;TARGET&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("create_time");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("entry_group_id");
        SetOutput("entry_link_id");
        SetOutput("entry_link_type");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// The id of the entry group this entry link is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroupId is required")]
    public required TerraformProperty<string> EntryGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_group_id");
        set => SetProperty("entry_group_id", value);
    }

    /// <summary>
    /// The id of the entry link to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkId is required")]
    public required TerraformProperty<string> EntryLinkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_link_id");
        set => SetProperty("entry_link_id", value);
    }

    /// <summary>
    /// Relative resource name of the Entry Link Type used to create this Entry Link. For example:
    /// projects/dataplex-types/locations/global/entryLinkTypes/definition
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryLinkType is required")]
    public required TerraformProperty<string> EntryLinkType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("entry_link_type");
        set => SetProperty("entry_link_type", value);
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
    /// The location for the entry.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for entry_references.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryReferences is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EntryReferences block(s) required")]
    public List<GoogleDataplexEntryLinkEntryReferencesBlock>? EntryReferences
    {
        set => SetProperty("entry_references", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataplexEntryLinkTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
