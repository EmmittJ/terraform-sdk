using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_table.
/// </summary>
public partial class GoogleBigqueryTableDataSource : TerraformDataSource
{
    public GoogleBigqueryTableDataSource(string name) : base("google_bigquery_table", name)
    {
    }

    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    [TerraformProperty("table_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableId { get; set; }

    /// <summary>
    /// Specifies the configuration of a BigLake managed table.
    /// </summary>
    [TerraformProperty("biglake_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> BiglakeConfiguration { get; }

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    [TerraformProperty("clustering")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> Clustering { get; }

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CreationTime { get; }

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> DeletionProtection { get; }

    /// <summary>
    /// The field description.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.
    /// </summary>
    [TerraformProperty("encryption_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EncryptionConfiguration { get; }

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    [TerraformProperty("expiration_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ExpirationTime { get; }

    /// <summary>
    /// Options defining open source compatible table.
    /// </summary>
    [TerraformProperty("external_catalog_table_options")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ExternalCatalogTableOptions { get; }

    /// <summary>
    /// Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.
    /// </summary>
    [TerraformProperty("external_data_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ExternalDataConfiguration { get; }

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FriendlyName { get; }

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    [TerraformProperty("generated_schema_columns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GeneratedSchemaColumns { get; }

    /// <summary>
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    [TerraformProperty("ignore_auto_generated_schema")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> IgnoreAutoGeneratedSchema { get; }

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    [TerraformProperty("ignore_schema_changes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> IgnoreSchemaChanges { get; }

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Labels { get; }

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LastModifiedTime { get; }

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// If specified, configures this table as a materialized view.
    /// </summary>
    [TerraformProperty("materialized_view")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> MaterializedView { get; }

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    [TerraformProperty("max_staleness")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaxStaleness { get; }

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    [TerraformProperty("num_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumBytes { get; }

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    [TerraformProperty("num_long_term_bytes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumLongTermBytes { get; }

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    [TerraformProperty("num_rows")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumRows { get; }

    /// <summary>
    /// If specified, configures range-based partitioning for this table.
    /// </summary>
    [TerraformProperty("range_partitioning")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RangePartitioning { get; }

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    [TerraformProperty("require_partition_filter")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> RequirePartitionFilter { get; }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> ResourceTags { get; }

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    [TerraformProperty("schema")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Schema { get; }

    /// <summary>
    /// Specifies metadata of the foreign data type definition in field schema.
    /// </summary>
    [TerraformProperty("schema_foreign_type_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> SchemaForeignTypeInfo { get; }

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// Defines the primary key and foreign keys.
    /// </summary>
    [TerraformProperty("table_constraints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TableConstraints { get; }

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    [TerraformProperty("table_metadata_view")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TableMetadataView { get; }

    /// <summary>
    /// Replication info of a table created using &amp;quot;AS REPLICA&amp;quot; DDL like: &amp;quot;CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv&amp;quot;.
    /// </summary>
    [TerraformProperty("table_replication_info")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TableReplicationInfo { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

    /// <summary>
    /// If specified, configures time-based partitioning for this table.
    /// </summary>
    [TerraformProperty("time_partitioning")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> TimePartitioning { get; }

    /// <summary>
    /// Describes the table type.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

    /// <summary>
    /// If specified, configures this table as a view.
    /// </summary>
    [TerraformProperty("view")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> View { get; }

}
