using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for gcs_fileset_spec in .
/// Nesting mode: list
/// </summary>
public class GoogleDataCatalogEntryGcsFilesetSpecBlock : ITerraformBlock
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
    [TerraformPropertyName("file_patterns")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? FilePatterns { get; set; }

    /// <summary>
    /// Sample files contained in this fileset, not all files contained in this fileset are represented here.
    /// </summary>
    [TerraformPropertyName("sample_gcs_file_specs")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SampleGcsFileSpecs => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "sample_gcs_file_specs");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogEntryTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    }

    /// <summary>
    /// Entry description, which can consist of several sentences or paragraphs that describe entry contents.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// Display information such as title and description. A short name to identify the entry,
    /// for example, &amp;quot;Analytics Data - Jan 2011&amp;quot;.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The name of the entry group this entry is in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroup is required")]
    [TerraformPropertyName("entry_group")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EntryGroup { get; set; }

    /// <summary>
    /// The id of the entry to create.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryId is required")]
    [TerraformPropertyName("entry_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EntryId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The resource this metadata entry refers to.
    /// For Google Cloud Platform resources, linkedResource is the full name of the resource.
    /// For example, the linkedResource for a table resource from BigQuery is:
    /// //bigquery.googleapis.com/projects/projectId/datasets/datasetId/tables/tableId
    /// Output only when Entry is of type in the EntryType enum. For entries with userSpecifiedType,
    /// this field is optional and defaults to an empty string.
    /// </summary>
    [TerraformPropertyName("linked_resource")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> LinkedResource { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "linked_resource");

    /// <summary>
    /// Schema of the entry (e.g. BigQuery, GoogleSQL, Avro schema), as a json string. An entry might not have any schema
    /// attached to it. See
    /// https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.entries#schema
    /// for what fields this schema can contain.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Schema { get; set; }

    /// <summary>
    /// The type of the entry. Only used for Entries with types in the EntryType enum.
    /// Currently, only FILESET enum value is allowed. All other entries created through Data Catalog must use userSpecifiedType. Possible values: [&amp;quot;FILESET&amp;quot;]
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// This field indicates the entry&#39;s source system that Data Catalog does not integrate with.
    /// userSpecifiedSystem strings must begin with a letter or underscore and can only contain letters, numbers,
    /// and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [TerraformPropertyName("user_specified_system")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserSpecifiedSystem { get; set; }

    /// <summary>
    /// Entry type if it does not fit any of the input-allowed values listed in EntryType enum above.
    /// When creating an entry, users should check the enum values first, if nothing matches the entry
    /// to be created, then provide a custom value, for example &amp;quot;my_special_type&amp;quot;.
    /// userSpecifiedType strings must begin with a letter or underscore and can only contain letters,
    /// numbers, and underscores; are case insensitive; must be at least 1 character and at most 64 characters long.
    /// </summary>
    [TerraformPropertyName("user_specified_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserSpecifiedType { get; set; }

    /// <summary>
    /// Block for gcs_fileset_spec.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GcsFilesetSpec block(s) allowed")]
    [TerraformPropertyName("gcs_fileset_spec")]
    public TerraformList<TerraformBlock<GoogleDataCatalogEntryGcsFilesetSpecBlock>>? GcsFilesetSpec { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleDataCatalogEntryTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Specification for a group of BigQuery tables with name pattern [prefix]YYYYMMDD.
    /// Context: https://cloud.google.com/bigquery/docs/partitioned-tables#partitioning_versus_sharding.
    /// </summary>
    [TerraformPropertyName("bigquery_date_sharded_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BigqueryDateShardedSpec => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bigquery_date_sharded_spec");

    /// <summary>
    /// Specification that applies to a BigQuery table. This is only valid on entries of type TABLE.
    /// </summary>
    [TerraformPropertyName("bigquery_table_spec")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> BigqueryTableSpec => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "bigquery_table_spec");

    /// <summary>
    /// This field indicates the entry&#39;s source system that Data Catalog integrates with, such as BigQuery or Pub/Sub.
    /// </summary>
    [TerraformPropertyName("integrated_system")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IntegratedSystem => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "integrated_system");

    /// <summary>
    /// The Data Catalog resource name of the entry in URL format.
    /// Example: projects/{project_id}/locations/{location}/entryGroups/{entryGroupId}/entries/{entryId}.
    /// Note that this Entry and its child resources may not actually be stored in the location in this name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
