using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataplex_entry_link resource.
/// </summary>
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
    public TerraformProperty<string>? EntryGroupId
    {
        get => GetProperty<TerraformProperty<string>>("entry_group_id");
        set => this.WithProperty("entry_group_id", value);
    }

    /// <summary>
    /// The id of the entry link to create.
    /// </summary>
    public TerraformProperty<string>? EntryLinkId
    {
        get => GetProperty<TerraformProperty<string>>("entry_link_id");
        set => this.WithProperty("entry_link_id", value);
    }

    /// <summary>
    /// Relative resource name of the Entry Link Type used to create this Entry Link. For example:
    /// projects/dataplex-types/locations/global/entryLinkTypes/definition
    /// </summary>
    public TerraformProperty<string>? EntryLinkType
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
    public TerraformProperty<string>? Location
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
