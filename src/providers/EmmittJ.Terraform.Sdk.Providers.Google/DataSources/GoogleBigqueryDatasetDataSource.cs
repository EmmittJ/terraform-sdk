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
    public required TerraformProperty<TerraformProperty<string>> DatasetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// An array of objects that define dataset access for one or more entities.
    /// </summary>
    [TerraformPropertyName("access")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Access => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "access");

    /// <summary>
    /// The time when this dataset was created, in milliseconds since the
    /// epoch.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> CreationTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "creation_time");

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
    public TerraformProperty<TerraformProperty<string>> DefaultCollation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_collation");

    /// <summary>
    /// The default encryption key for all tables in the dataset. Once this property is set,
    /// all newly-created partitioned tables in the dataset will have encryption key set to
    /// this value, unless table creation request (or query) overrides the key.
    /// </summary>
    [TerraformPropertyName("default_encryption_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DefaultEncryptionConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "default_encryption_configuration");

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
    public TerraformProperty<TerraformProperty<double>> DefaultPartitionExpirationMs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_partition_expiration_ms");

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
    public TerraformProperty<TerraformProperty<double>> DefaultTableExpirationMs => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_table_expiration_ms");

    /// <summary>
    /// If set to &#39;true&#39;, delete all the tables in the
    /// dataset when destroying the resource; otherwise,
    /// destroying the resource will fail if tables are present.
    /// </summary>
    [TerraformPropertyName("delete_contents_on_destroy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> DeleteContentsOnDestroy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "delete_contents_on_destroy");

    /// <summary>
    /// A user-friendly description of the dataset
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Options defining open source compatible datasets living in the BigQuery catalog. Contains
    /// metadata of open source database, schema or namespace represented by the current dataset.
    /// </summary>
    [TerraformPropertyName("external_catalog_dataset_options")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalCatalogDatasetOptions => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_catalog_dataset_options");

    /// <summary>
    /// Information about the external metadata storage where the dataset is defined.
    /// </summary>
    [TerraformPropertyName("external_dataset_reference")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalDatasetReference => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_dataset_reference");

    /// <summary>
    /// A descriptive name for the dataset
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FriendlyName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "friendly_name");

    /// <summary>
    /// TRUE if the dataset and its table names are case-insensitive, otherwise FALSE.
    /// By default, this is FALSE, which means the dataset and its table names are
    /// case-sensitive. This field does not affect routine references.
    /// </summary>
    [TerraformPropertyName("is_case_insensitive")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> IsCaseInsensitive => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "is_case_insensitive");

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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The date when this dataset or any of its tables was last modified, in
    /// milliseconds since the epoch.
    /// </summary>
    [TerraformPropertyName("last_modified_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> LastModifiedTime => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "last_modified_time");

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
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).
    /// </summary>
    [TerraformPropertyName("max_time_travel_hours")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MaxTimeTravelHours => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "max_time_travel_hours");

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be
    /// in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the
    /// ID of the parent organization or project resource for this tag key. Tag value is expected
    /// to be the short name, for example &amp;quot;Production&amp;quot;. See [Tag definitions](https://cloud.google.com/iam/docs/tags-access-control#definitions)
    /// for more details.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> ResourceTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "resource_tags");

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// Specifies the storage billing model for the dataset.
    /// Set this flag value to LOGICAL to use logical bytes for storage billing,
    /// or to PHYSICAL to use physical bytes instead.
    /// 
    /// LOGICAL is the default if this flag isn&#39;t specified.
    /// </summary>
    [TerraformPropertyName("storage_billing_model")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StorageBillingModel => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "storage_billing_model");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
