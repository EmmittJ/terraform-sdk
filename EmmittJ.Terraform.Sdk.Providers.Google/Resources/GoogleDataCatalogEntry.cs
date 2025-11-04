using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_data_catalog_entry resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleDataCatalogEntry : TerraformResource
{
    public GoogleDataCatalogEntry(string name) : base("google_data_catalog_entry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("bigquery_date_sharded_spec");
        this.DeclareOutput("bigquery_table_spec");
        this.DeclareOutput("integrated_system");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Entry description, which can consist of several sentences or paragraphs that describe entry contents.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Display information such as title and description. A short name to identify the entry,
    /// for example, &amp;quot;Analytics Data - Jan 2011&amp;quot;.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the entry group this entry is in.
    /// </summary>
    public string? EntryGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entry_group")?.Value;
        set => this.WithProperty("entry_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id of the entry to create.
    /// </summary>
    public string? EntryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entry_id")?.Value;
        set => this.WithProperty("entry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource this metadata entry refers to.
    /// For Google Cloud Platform resources, linkedResource is the full name of the resource.
    /// For example, the linkedResource for a table resource from BigQuery is:
    /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
    /// Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType,
    /// this field is optional and defaults to an empty string.
    /// </summary>
    public string? LinkedResource
    {
        get => GetProperty<TerraformLiteralProperty<string>>("linked_resource")?.Value;
        set => this.WithProperty("linked_resource", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema
    /// attached to it. See
    /// https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema
    /// for what fields this schema can contain.
    /// </summary>
    public string? Schema
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema")?.Value;
        set => this.WithProperty("schema", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of the entry. Only used for Entries with types in the EntryType enum.
    /// Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values: [&amp;quot;FILESET&amp;quot;]
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// This field indicates the entry&#39;s source system that Data Catalog does not integrate with.
    /// userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers,
    /// and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    public string? UserSpecifiedSystem
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_specified_system")?.Value;
        set => this.WithProperty("user_specified_system", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Entry type if it does not fit any of the input-allowed values listed in EntryType enum above.
    /// When creating an entry, users should check the enum values first, if nothing matches the entry
    /// to be created, then provide a custom value, for example &amp;quot;my_special_type&amp;quot;.
    /// userSpecifiedType strings must begin with a letter or underscore and can only contain letters,
    /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    public string? UserSpecifiedType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_specified_type")?.Value;
        set => this.WithProperty("user_specified_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specification for a group of BigQuery tables with name pattern [prefix]YYYYMMDD.
    /// Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.
    /// </summary>
    public TerraformExpression BigqueryDateShardedSpec => this["bigquery_date_sharded_spec"];

    /// <summary>
    /// Specification that applies to a BigQuery table. This is only valid on entries of type TABLE.
    /// </summary>
    public TerraformExpression BigqueryTableSpec => this["bigquery_table_spec"];

    /// <summary>
    /// This field indicates the entry&#39;s source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.
    /// </summary>
    public TerraformExpression IntegratedSystem => this["integrated_system"];

    /// <summary>
    /// The Data Catalog resource name of the entry in URL format.
    /// Example: projects/{project_id}/locations/{location}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// Note that this Entry and its child resources may not actually be stored in the location in this name.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
