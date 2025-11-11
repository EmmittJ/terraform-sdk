using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_dataset.
/// </summary>
public class GoogleBigqueryDatasetDataSource : TerraformDataSource
{
    public GoogleBigqueryDatasetDataSource(string name) : base("google_bigquery_dataset", name)
    {
    }

    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DatasetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// An array of objects that define dataset access for one or more entities.
    /// </summary>
    [TerraformPropertyName("access")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Access => new TerraformReference(this, "access");

    /// <summary>
    /// The time when this dataset was created, in milliseconds since the
    /// epoch.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// Defines the default collation specification of future tables created
    /// in the dataset. If a table is created in this dataset without table-level
    /// default collation, then the table inherits the dataset default collation,
    /// which is applied to the string fields that do not have explicit collation
    /// specified. A change to this field affects only tables created afterwards,
    /// and does not alter the existing tables.
    /// 
    /// The following values are supported:
    /// - &#39;und:ci&#39;: undetermined locale, case insensitive.
    /// - &#39;&#39;: empty string. Default to case-sensitive behavior.
    /// </summary>
    [TerraformPropertyName("default_collation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultCollation => new TerraformReference(this, "default_collation");

    /// <summary>
    /// The default encryption key for all tables in the dataset. Once this property is set,
    /// all newly-created partitioned tables in the dataset will have encryption key set to
    /// this value, unless table creation request (or query) overrides the key.
    /// </summary>
    [TerraformPropertyName("default_encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DefaultEncryptionConfiguration => new TerraformReference(this, "default_encryption_configuration");

    /// <summary>
    /// The default partition expiration for all partitioned tables in
    /// the dataset, in milliseconds.
    /// Once this property is set, all newly-created partitioned tables in
    /// the dataset will have an &#39;expirationMs&#39; property in the &#39;timePartitioning&#39;
    /// settings set to this value, and changing the value will only
    /// affect new tables, not existing ones. The storage in a partition will
    /// have an expiration time of its partition time plus this value.
    /// Setting this property overrides the use of &#39;defaultTableExpirationMs&#39;
    /// for partitioned tables: only one of &#39;defaultTableExpirationMs&#39; and
    /// &#39;defaultPartitionExpirationMs&#39; will be used for any new partitioned
    /// table. If you provide an explicit &#39;timePartitioning.expirationMs&#39; when
    /// creating or updating a partitioned table, that value takes precedence
    /// over the default partition expiration time indicated by this property.
    /// </summary>
    [TerraformPropertyName("default_partition_expiration_ms")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultPartitionExpirationMs => new TerraformReference(this, "default_partition_expiration_ms");

    /// <summary>
    /// The default lifetime of all tables in the dataset, in milliseconds.
    /// The minimum value is 3600000 milliseconds (one hour).
    /// Once this property is set, all newly-created tables in the dataset
    /// will have an &#39;expirationTime&#39; property set to the creation time plus
    /// the value in this property, and changing the value will only affect
    /// new tables, not existing ones. When the &#39;expirationTime&#39; for a given
    /// table is reached, that table will be deleted automatically.
    /// If a table&#39;s &#39;expirationTime&#39; is modified or removed before the
    /// table expires, or if you provide an explicit &#39;expirationTime&#39; when
    /// creating a table, that value takes precedence over the default
    /// expiration time indicated by this property.
    /// </summary>
    [TerraformPropertyName("default_table_expiration_ms")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultTableExpirationMs => new TerraformReference(this, "default_table_expiration_ms");

    /// <summary>
    /// If set to &#39;true&#39;, delete all the tables in the
    /// dataset when destroying the resource; otherwise,
    /// destroying the resource will fail if tables are present.
    /// </summary>
    [TerraformPropertyName("delete_contents_on_destroy")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeleteContentsOnDestroy => new TerraformReference(this, "delete_contents_on_destroy");

    /// <summary>
    /// A user-friendly description of the dataset
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> EffectiveLabels => new TerraformReference(this, "effective_labels");

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// Options defining open source compatible datasets living in the BigQuery catalog. Contains
    /// metadata of open source database, schema or namespace represented by the current dataset.
    /// </summary>
    [TerraformPropertyName("external_catalog_dataset_options")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExternalCatalogDatasetOptions => new TerraformReference(this, "external_catalog_dataset_options");

    /// <summary>
    /// Information about the external metadata storage where the dataset is defined.
    /// </summary>
    [TerraformPropertyName("external_dataset_reference")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExternalDatasetReference => new TerraformReference(this, "external_dataset_reference");

    /// <summary>
    /// A descriptive name for the dataset
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FriendlyName => new TerraformReference(this, "friendly_name");

    /// <summary>
    /// TRUE if the dataset and its table names are case-insensitive, otherwise FALSE.
    /// By default, this is FALSE, which means the dataset and its table names are
    /// case-sensitive. This field does not affect routine references.
    /// </summary>
    [TerraformPropertyName("is_case_insensitive")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> IsCaseInsensitive => new TerraformReference(this, "is_case_insensitive");

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Labels => new TerraformReference(this, "labels");

    /// <summary>
    /// The date when this dataset or any of its tables was last modified, in
    /// milliseconds since the epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> LastModifiedTime => new TerraformReference(this, "last_modified_time");

    /// <summary>
    /// The geographic location where the dataset should reside.
    /// See [official docs](https://cloud.google.com/bigquery/docs/dataset-locations).
    /// There are two types of locations, regional or multi-regional. A regional
    /// location is a specific geographic place, such as Tokyo, and a multi-regional
    /// location is a large geographic area, such as the United States, that
    /// contains at least two geographic places.
    /// The default value is multi-regional location &#39;US&#39;.
    /// Changing this forces a new resource to be created.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).
    /// </summary>
    [TerraformPropertyName("max_time_travel_hours")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaxTimeTravelHours => new TerraformReference(this, "max_time_travel_hours");

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be
    /// in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the
    /// ID of the parent organization or project resource for this tag key. Tag value is expected
    /// to be the short name, for example &amp;quot;Production&amp;quot;. See [Tag definitions](https://cloud.google.com/iam/docs/tags-access-control#definitions)
    /// for more details.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ResourceTags => new TerraformReference(this, "resource_tags");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SelfLink => new TerraformReference(this, "self_link");

    /// <summary>
    /// Specifies the storage billing model for the dataset.
    /// Set this flag value to LOGICAL to use logical bytes for storage billing,
    /// or to PHYSICAL to use physical bytes instead.
    /// 
    /// LOGICAL is the default if this flag isn&#39;t specified.
    /// </summary>
    [TerraformPropertyName("storage_billing_model")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StorageBillingModel => new TerraformReference(this, "storage_billing_model");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TerraformLabels => new TerraformReference(this, "terraform_labels");

}
