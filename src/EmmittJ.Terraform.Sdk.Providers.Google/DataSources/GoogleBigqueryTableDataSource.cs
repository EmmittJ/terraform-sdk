using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_table.
/// </summary>
public class GoogleBigqueryTableDataSource : TerraformDataSource
{
    public GoogleBigqueryTableDataSource(string name) : base("google_bigquery_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("biglake_configuration");
        this.DeclareOutput("clustering");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("deletion_protection");
        this.DeclareOutput("description");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("encryption_configuration");
        this.DeclareOutput("etag");
        this.DeclareOutput("expiration_time");
        this.DeclareOutput("external_catalog_table_options");
        this.DeclareOutput("external_data_configuration");
        this.DeclareOutput("friendly_name");
        this.DeclareOutput("generated_schema_columns");
        this.DeclareOutput("ignore_auto_generated_schema");
        this.DeclareOutput("ignore_schema_changes");
        this.DeclareOutput("labels");
        this.DeclareOutput("last_modified_time");
        this.DeclareOutput("location");
        this.DeclareOutput("materialized_view");
        this.DeclareOutput("max_staleness");
        this.DeclareOutput("num_bytes");
        this.DeclareOutput("num_long_term_bytes");
        this.DeclareOutput("num_rows");
        this.DeclareOutput("range_partitioning");
        this.DeclareOutput("require_partition_filter");
        this.DeclareOutput("resource_tags");
        this.DeclareOutput("schema");
        this.DeclareOutput("schema_foreign_type_info");
        this.DeclareOutput("self_link");
        this.DeclareOutput("table_constraints");
        this.DeclareOutput("table_metadata_view");
        this.DeclareOutput("table_replication_info");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("time_partitioning");
        this.DeclareOutput("type");
        this.DeclareOutput("view");
    }

    /// <summary>
    /// The dataset ID to create the table in. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformLiteralProperty<string>? DatasetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset_id");
        set => this.WithProperty("dataset_id", value);
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
    /// The ID of the project in which the resource belongs.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A unique ID for the resource. Changing this forces a new resource to be created.
    /// </summary>
    public TerraformLiteralProperty<string>? TableId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table_id");
        set => this.WithProperty("table_id", value);
    }

    /// <summary>
    /// Specifies the configuration of a BigLake managed table.
    /// </summary>
    public TerraformExpression BiglakeConfiguration => this["biglake_configuration"];

    /// <summary>
    /// Specifies column names to use for data clustering. Up to four top-level columns are allowed, and should be specified in descending priority order.
    /// </summary>
    public TerraformExpression Clustering => this["clustering"];

    /// <summary>
    /// The time when this table was created, in milliseconds since the epoch.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// Whether Terraform will be prevented from destroying the instance. When the field is set to true or unset in Terraform state, a terraform apply or terraform destroy that would delete the table will fail. When the field is set to false, deleting the table is allowed.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// The field description.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Specifies how the table should be encrypted. If left blank, the table will be encrypted with a Google-managed key; that process is transparent to the user.
    /// </summary>
    public TerraformExpression EncryptionConfiguration => this["encryption_configuration"];

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The time when this table expires, in milliseconds since the epoch. If not present, the table will persist indefinitely. Expired tables will be deleted and their storage reclaimed.
    /// </summary>
    public TerraformExpression ExpirationTime => this["expiration_time"];

    /// <summary>
    /// Options defining open source compatible table.
    /// </summary>
    public TerraformExpression ExternalCatalogTableOptions => this["external_catalog_table_options"];

    /// <summary>
    /// Describes the data format, location, and other properties of a table stored outside of BigQuery. By defining these properties, the data source can then be queried as if it were a standard BigQuery table.
    /// </summary>
    public TerraformExpression ExternalDataConfiguration => this["external_data_configuration"];

    /// <summary>
    /// A descriptive name for the table.
    /// </summary>
    public TerraformExpression FriendlyName => this["friendly_name"];

    /// <summary>
    /// (Output-only) A list of autogenerated schema fields.
    /// </summary>
    public TerraformExpression GeneratedSchemaColumns => this["generated_schema_columns"];

    /// <summary>
    /// Whether Terraform will prevent implicitly added columns in schema from showing diff.
    /// </summary>
    public TerraformExpression IgnoreAutoGeneratedSchema => this["ignore_auto_generated_schema"];

    /// <summary>
    /// Mention which fields in schema are to be ignored
    /// </summary>
    public TerraformExpression IgnoreSchemaChanges => this["ignore_schema_changes"];

    /// <summary>
    /// A mapping of labels to assign to the resource.
    /// 
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The time when this table was last modified, in milliseconds since the epoch.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// If specified, configures this table as a materialized view.
    /// </summary>
    public TerraformExpression MaterializedView => this["materialized_view"];

    /// <summary>
    /// The maximum staleness of data that could be returned when the table (or stale MV) is queried. Staleness encoded as a string encoding of [SQL IntervalValue type](https://cloud.google.com/bigquery/docs/reference/standard-sql/data-types#interval_type).
    /// </summary>
    public TerraformExpression MaxStaleness => this["max_staleness"];

    /// <summary>
    /// The geographic location where the table resides. This value is inherited from the dataset.
    /// </summary>
    public TerraformExpression NumBytes => this["num_bytes"];

    /// <summary>
    /// The number of bytes in the table that are considered &amp;quot;long-term storage&amp;quot;.
    /// </summary>
    public TerraformExpression NumLongTermBytes => this["num_long_term_bytes"];

    /// <summary>
    /// The number of rows of data in this table, excluding any data in the streaming buffer.
    /// </summary>
    public TerraformExpression NumRows => this["num_rows"];

    /// <summary>
    /// If specified, configures range-based partitioning for this table.
    /// </summary>
    public TerraformExpression RangePartitioning => this["range_partitioning"];

    /// <summary>
    /// If set to true, queries over this table require a partition filter that can be used for partition elimination to be specified.
    /// </summary>
    public TerraformExpression RequirePartitionFilter => this["require_partition_filter"];

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the ID of the parent organization or project resource for this tag key. Tag value is expected to be the short name, for example &amp;quot;Production&amp;quot;.
    /// </summary>
    public TerraformExpression ResourceTags => this["resource_tags"];

    /// <summary>
    /// A JSON schema for the table.
    /// </summary>
    public TerraformExpression Schema => this["schema"];

    /// <summary>
    /// Specifies metadata of the foreign data type definition in field schema.
    /// </summary>
    public TerraformExpression SchemaForeignTypeInfo => this["schema_foreign_type_info"];

    /// <summary>
    /// The URI of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Defines the primary key and foreign keys.
    /// </summary>
    public TerraformExpression TableConstraints => this["table_constraints"];

    /// <summary>
    /// View sets the optional parameter &amp;quot;view&amp;quot;: Specifies the view that determines which table information is returned. By default, basic table information and storage statistics (STORAGE_STATS) are returned. Possible values: TABLE_METADATA_VIEW_UNSPECIFIED, BASIC, STORAGE_STATS, FULL
    /// </summary>
    public TerraformExpression TableMetadataView => this["table_metadata_view"];

    /// <summary>
    /// Replication info of a table created using &amp;quot;AS REPLICA&amp;quot; DDL like: &amp;quot;CREATE MATERIALIZED VIEW mv1 AS REPLICA OF src_mv&amp;quot;.
    /// </summary>
    public TerraformExpression TableReplicationInfo => this["table_replication_info"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// If specified, configures time-based partitioning for this table.
    /// </summary>
    public TerraformExpression TimePartitioning => this["time_partitioning"];

    /// <summary>
    /// Describes the table type.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// If specified, configures this table as a view.
    /// </summary>
    public TerraformExpression View => this["view"];

}
