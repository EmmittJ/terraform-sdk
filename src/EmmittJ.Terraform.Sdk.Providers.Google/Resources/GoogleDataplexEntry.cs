using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public TerraformLiteralProperty<string>? EntryGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entry_group_id");
        set => this.WithProperty("entry_group_id", value);
    }

    /// <summary>
    /// The entry id of the entry.
    /// </summary>
    public TerraformLiteralProperty<string>? EntryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entry_id");
        set => this.WithProperty("entry_id", value);
    }

    /// <summary>
    /// The relative resource name of the entry type that was used to create this entry, in the format projects/{project_number}/locations/{locationId}/entryTypes/{entryTypeId}.
    /// </summary>
    public TerraformLiteralProperty<string>? EntryType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entry_type");
        set => this.WithProperty("entry_type", value);
    }

    /// <summary>
    /// A name for the entry that can be referenced by an external system. For more information, see https://cloud.google.com/dataplex/docs/fully-qualified-names.
    /// The maximum size of the field is 4000 characters.
    /// </summary>
    public TerraformLiteralProperty<string>? FullyQualifiedName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fully_qualified_name");
        set => this.WithProperty("fully_qualified_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location where entry will be created.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the parent entry, in the format projects/{project_number}/locations/{locationId}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// </summary>
    public TerraformLiteralProperty<string>? ParentEntry
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent_entry");
        set => this.WithProperty("parent_entry", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
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
