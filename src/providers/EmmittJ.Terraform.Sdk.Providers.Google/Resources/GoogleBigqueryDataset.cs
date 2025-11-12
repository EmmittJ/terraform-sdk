using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access in .
/// Nesting mode: set
/// </summary>
public partial class GoogleBigqueryDatasetAccessBlock() : TerraformBlock("access")
{
    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Domain { get; set; }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    [TerraformProperty("group_by_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GroupByEmail { get; set; }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    [TerraformProperty("iam_member")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamMember { get; set; }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles
    /// are supported. Predefined roles that have equivalent basic roles
    /// are swapped by the API to their basic counterparts. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    [TerraformProperty("role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Role { get; set; }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    [TerraformProperty("special_group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SpecialGroup { get; set; }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    [TerraformProperty("user_by_email")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserByEmail { get; set; }

}

/// <summary>
/// Block type for default_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock() : TerraformBlock("default_encryption_configuration")
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination
    /// BigQuery table. The BigQuery Service Account associated with your project requires
    /// access to this encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for external_catalog_dataset_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock() : TerraformBlock("external_catalog_dataset_options")
{
    /// <summary>
    /// The storage location URI for all tables in the dataset. Equivalent to hive metastore&#39;s
    /// database locationUri. Maximum length of 1024 characters.
    /// </summary>
    [TerraformProperty("default_storage_location_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultStorageLocationUri { get; set; }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source schema.
    /// Maximum size of 2Mib.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

}

/// <summary>
/// Block type for external_dataset_reference in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDatasetExternalDatasetReferenceBlock() : TerraformBlock("external_dataset_reference")
{
    /// <summary>
    /// The connection id that is used to access the externalSource.
    /// Format: projects/{projectId}/locations/{locationId}/connections/{connectionId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Connection is required")]
    [TerraformProperty("connection")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Connection { get; set; }

    /// <summary>
    /// External source that backs this dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalSource is required")]
    [TerraformProperty("external_source")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExternalSource { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryDatasetTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_dataset resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryDataset : TerraformResource
{
    public GoogleBigqueryDataset(string name) : base("google_bigquery_dataset", name)
    {
    }

    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformProperty("dataset_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DatasetId { get; set; }

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
    [TerraformProperty("default_collation")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultCollation { get; set; }

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
    [TerraformProperty("default_partition_expiration_ms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DefaultPartitionExpirationMs { get; set; }

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
    [TerraformProperty("default_table_expiration_ms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DefaultTableExpirationMs { get; set; }

    /// <summary>
    /// If set to &#39;true&#39;, delete all the tables in the
    /// dataset when destroying the resource; otherwise,
    /// destroying the resource will fail if tables are present.
    /// </summary>
    [TerraformProperty("delete_contents_on_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteContentsOnDestroy { get; set; }

    /// <summary>
    /// A user-friendly description of the dataset
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A descriptive name for the dataset
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// TRUE if the dataset and its table names are case-insensitive, otherwise FALSE.
    /// By default, this is FALSE, which means the dataset and its table names are
    /// case-sensitive. This field does not affect routine references.
    /// </summary>
    [TerraformProperty("is_case_insensitive")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> IsCaseInsensitive { get; set; }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

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
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).
    /// </summary>
    [TerraformProperty("max_time_travel_hours")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxTimeTravelHours { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be
    /// in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the
    /// ID of the parent organization or project resource for this tag key. Tag value is expected
    /// to be the short name, for example &amp;quot;Production&amp;quot;. See [Tag definitions](https://cloud.google.com/iam/docs/tags-access-control#definitions)
    /// for more details.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// Specifies the storage billing model for the dataset.
    /// Set this flag value to LOGICAL to use logical bytes for storage billing,
    /// or to PHYSICAL to use physical bytes instead.
    /// 
    /// LOGICAL is the default if this flag isn&#39;t specified.
    /// </summary>
    [TerraformProperty("storage_billing_model")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StorageBillingModel { get; set; }

    /// <summary>
    /// Block for access.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("access")]
    public TerraformSet<GoogleBigqueryDatasetAccessBlock> Access { get; set; } = new();

    /// <summary>
    /// Block for default_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultEncryptionConfiguration block(s) allowed")]
    [TerraformProperty("default_encryption_configuration")]
    public TerraformList<GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock> DefaultEncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for external_catalog_dataset_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogDatasetOptions block(s) allowed")]
    [TerraformProperty("external_catalog_dataset_options")]
    public TerraformList<GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock> ExternalCatalogDatasetOptions { get; set; } = new();

    /// <summary>
    /// Block for external_dataset_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDatasetReference block(s) allowed")]
    [TerraformProperty("external_dataset_reference")]
    public TerraformList<GoogleBigqueryDatasetExternalDatasetReferenceBlock> ExternalDatasetReference { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleBigqueryDatasetTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The time when this dataset was created, in milliseconds since the
    /// epoch.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> CreationTime { get; }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformProperty("effective_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> EffectiveLabels { get; }

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The date when this dataset or any of its tables was last modified, in
    /// milliseconds since the epoch.
    /// </summary>
    [TerraformProperty("last_modified_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> LastModifiedTime { get; }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    [TerraformProperty("terraform_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TerraformLabels { get; }

}
