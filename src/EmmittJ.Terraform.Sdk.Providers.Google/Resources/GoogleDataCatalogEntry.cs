using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gcs_fileset_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataCatalogEntryGcsFilesetSpecBlock : TerraformBlock
{
    /// <summary>
    /// Patterns to identify a set of files in Google Cloud Storage.
    /// See [Cloud Storage documentation](https://cloud.google.com/storage/docs/gsutil/addlhelp/WildcardNames)
    /// for more information. Note that bucket wildcards are currently not supported. Examples of valid filePatterns:
    /// 
    /// * gs://bucket_name/dir/*: matches all files within bucket_name/dir directory.
    /// * gs://bucket_name/dir/**: matches all files in bucket_name/dir spanning all subdirectories.
    /// * gs://bucket_name/file*: matches files prefixed by file in bucket_name
    /// * gs://bucket_name/??.txt: matches files with two characters followed by .txt in bucket_name
    /// * gs://bucket_name/[aeiou].txt: matches files that contain a single vowel character followed by .txt in bucket_name
    /// * gs://bucket_name/[a-m].txt: matches files that contain a, b, ... or m followed by .txt in bucket_name
    /// * gs://bucket_name/a/*/b: matches all files in bucket_name that match a/*/b pattern, such as a/c/b, a/d/b
    /// * gs://another_bucket/a.txt: matches gs://another_bucket/a.txt
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilePatterns is required")]
    public List<TerraformProperty<string>>? FilePatterns
    {
        get => GetProperty<List<TerraformProperty<string>>>("file_patterns");
        set => WithProperty("file_patterns", value);
    }

    /// <summary>
    /// Sample files contained in this fileset, not all files contained in this fileset are represented here.
    /// </summary>
    public List<TerraformProperty<object>>? SampleGcsFileSpecs
    {
        get => GetProperty<List<TerraformProperty<object>>>("sample_gcs_file_specs");
        set => WithProperty("sample_gcs_file_specs", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogEntryTimeoutsBlock : TerraformBlock
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
/// Manages a google_data_catalog_entry resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Display information such as title and description. A short name to identify the entry,
    /// for example, &amp;quot;Analytics Data - Jan 2011&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The name of the entry group this entry is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroup is required")]
    public required TerraformProperty<string> EntryGroup
    {
        get => GetProperty<TerraformProperty<string>>("entry_group");
        set => this.WithProperty("entry_group", value);
    }

    /// <summary>
    /// The id of the entry to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryId is required")]
    public required TerraformProperty<string> EntryId
    {
        get => GetProperty<TerraformProperty<string>>("entry_id");
        set => this.WithProperty("entry_id", value);
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
    /// The resource this metadata entry refers to.
    /// For Google Cloud Platform resources, linkedResource is the full name of the resource.
    /// For example, the linkedResource for a table resource from BigQuery is:
    /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
    /// Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType,
    /// this field is optional and defaults to an empty string.
    /// </summary>
    public TerraformProperty<string>? LinkedResource
    {
        get => GetProperty<TerraformProperty<string>>("linked_resource");
        set => this.WithProperty("linked_resource", value);
    }

    /// <summary>
    /// Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema
    /// attached to it. See
    /// https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema
    /// for what fields this schema can contain.
    /// </summary>
    public TerraformProperty<string>? Schema
    {
        get => GetProperty<TerraformProperty<string>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// The type of the entry. Only used for Entries with types in the EntryType enum.
    /// Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values: [&amp;quot;FILESET&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// This field indicates the entry&#39;s source system that Data Catalog does not integrate with.
    /// userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers,
    /// and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    public TerraformProperty<string>? UserSpecifiedSystem
    {
        get => GetProperty<TerraformProperty<string>>("user_specified_system");
        set => this.WithProperty("user_specified_system", value);
    }

    /// <summary>
    /// Entry type if it does not fit any of the input-allowed values listed in EntryType enum above.
    /// When creating an entry, users should check the enum values first, if nothing matches the entry
    /// to be created, then provide a custom value, for example &amp;quot;my_special_type&amp;quot;.
    /// userSpecifiedType strings must begin with a letter or underscore and can only contain letters,
    /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    public TerraformProperty<string>? UserSpecifiedType
    {
        get => GetProperty<TerraformProperty<string>>("user_specified_type");
        set => this.WithProperty("user_specified_type", value);
    }

    /// <summary>
    /// Block for gcs_fileset_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsFilesetSpec block(s) allowed")]
    public List<GoogleDataCatalogEntryGcsFilesetSpecBlock>? GcsFilesetSpec
    {
        get => GetProperty<List<GoogleDataCatalogEntryGcsFilesetSpecBlock>>("gcs_fileset_spec");
        set => this.WithProperty("gcs_fileset_spec", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleDataCatalogEntryTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleDataCatalogEntryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
