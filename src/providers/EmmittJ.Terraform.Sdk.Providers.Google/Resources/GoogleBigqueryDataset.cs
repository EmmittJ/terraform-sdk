using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access in .
/// Nesting mode: set
/// </summary>
public class GoogleBigqueryDatasetAccessBlock : TerraformBlock
{
    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    public TerraformProperty<string>? GroupByEmail
    {
        get => GetProperty<TerraformProperty<string>>("group_by_email");
        set => WithProperty("group_by_email", value);
    }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    public TerraformProperty<string>? IamMember
    {
        get => GetProperty<TerraformProperty<string>>("iam_member");
        set => WithProperty("iam_member", value);
    }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles
    /// are supported. Predefined roles that have equivalent basic roles
    /// are swapped by the API to their basic counterparts. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => WithProperty("role", value);
    }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    public TerraformProperty<string>? SpecialGroup
    {
        get => GetProperty<TerraformProperty<string>>("special_group");
        set => WithProperty("special_group", value);
    }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    public TerraformProperty<string>? UserByEmail
    {
        get => GetProperty<TerraformProperty<string>>("user_by_email");
        set => WithProperty("user_by_email", value);
    }

}

/// <summary>
/// Block type for default_encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination
    /// BigQuery table. The BigQuery Service Account associated with your project requires
    /// access to this encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for external_catalog_dataset_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The storage location URI for all tables in the dataset. Equivalent to hive metastore&#39;s
    /// database locationUri. Maximum length of 1024 characters.
    /// </summary>
    public TerraformProperty<string>? DefaultStorageLocationUri
    {
        get => GetProperty<TerraformProperty<string>>("default_storage_location_uri");
        set => WithProperty("default_storage_location_uri", value);
    }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source schema.
    /// Maximum size of 2Mib.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => WithProperty("parameters", value);
    }

}

/// <summary>
/// Block type for external_dataset_reference in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetExternalDatasetReferenceBlock : TerraformBlock
{
    /// <summary>
    /// The connection id that is used to access the externalSource.
    /// Format: projects/{projectId}/locations/{locationId}/connections/{connectionId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Connection is required")]
    public required TerraformProperty<string> Connection
    {
        get => GetRequiredProperty<TerraformProperty<string>>("connection");
        set => WithProperty("connection", value);
    }

    /// <summary>
    /// External source that backs this dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalSource is required")]
    public required TerraformProperty<string> ExternalSource
    {
        get => GetRequiredProperty<TerraformProperty<string>>("external_source");
        set => WithProperty("external_source", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatasetTimeoutsBlock : TerraformBlock
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
/// Manages a google_bigquery_dataset resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDataset : TerraformResource
{
    public GoogleBigqueryDataset(string name) : base("google_bigquery_dataset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("creation_time");
        this.WithOutput("effective_labels");
        this.WithOutput("etag");
        this.WithOutput("last_modified_time");
        this.WithOutput("self_link");
        this.WithOutput("terraform_labels");
    }

    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("dataset_id");
        set => this.WithProperty("dataset_id", value);
    }

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
    public TerraformProperty<string>? DefaultCollation
    {
        get => GetProperty<TerraformProperty<string>>("default_collation");
        set => this.WithProperty("default_collation", value);
    }

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
    public TerraformProperty<double>? DefaultPartitionExpirationMs
    {
        get => GetProperty<TerraformProperty<double>>("default_partition_expiration_ms");
        set => this.WithProperty("default_partition_expiration_ms", value);
    }

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
    public TerraformProperty<double>? DefaultTableExpirationMs
    {
        get => GetProperty<TerraformProperty<double>>("default_table_expiration_ms");
        set => this.WithProperty("default_table_expiration_ms", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, delete all the tables in the
    /// dataset when destroying the resource; otherwise,
    /// destroying the resource will fail if tables are present.
    /// </summary>
    public TerraformProperty<bool>? DeleteContentsOnDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("delete_contents_on_destroy");
        set => this.WithProperty("delete_contents_on_destroy", value);
    }

    /// <summary>
    /// A user-friendly description of the dataset
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A descriptive name for the dataset
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
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
    /// TRUE if the dataset and its table names are case-insensitive, otherwise FALSE.
    /// By default, this is FALSE, which means the dataset and its table names are
    /// case-sensitive. This field does not affect routine references.
    /// </summary>
    public TerraformProperty<bool>? IsCaseInsensitive
    {
        get => GetProperty<TerraformProperty<bool>>("is_case_insensitive");
        set => this.WithProperty("is_case_insensitive", value);
    }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).
    /// </summary>
    public TerraformProperty<string>? MaxTimeTravelHours
    {
        get => GetProperty<TerraformProperty<string>>("max_time_travel_hours");
        set => this.WithProperty("max_time_travel_hours", value);
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
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be
    /// in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the
    /// ID of the parent organization or project resource for this tag key. Tag value is expected
    /// to be the short name, for example &amp;quot;Production&amp;quot;. See [Tag definitions](https://cloud.google.com/iam/docs/tags-access-control#definitions)
    /// for more details.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// Specifies the storage billing model for the dataset.
    /// Set this flag value to LOGICAL to use logical bytes for storage billing,
    /// or to PHYSICAL to use physical bytes instead.
    /// 
    /// LOGICAL is the default if this flag isn&#39;t specified.
    /// </summary>
    public TerraformProperty<string>? StorageBillingModel
    {
        get => GetProperty<TerraformProperty<string>>("storage_billing_model");
        set => this.WithProperty("storage_billing_model", value);
    }

    /// <summary>
    /// Block for access.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleBigqueryDatasetAccessBlock>? Access
    {
        get => GetProperty<HashSet<GoogleBigqueryDatasetAccessBlock>>("access");
        set => this.WithProperty("access", value);
    }

    /// <summary>
    /// Block for default_encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultEncryptionConfiguration block(s) allowed")]
    public List<GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock>? DefaultEncryptionConfiguration
    {
        get => GetProperty<List<GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock>>("default_encryption_configuration");
        set => this.WithProperty("default_encryption_configuration", value);
    }

    /// <summary>
    /// Block for external_catalog_dataset_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogDatasetOptions block(s) allowed")]
    public List<GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock>? ExternalCatalogDatasetOptions
    {
        get => GetProperty<List<GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock>>("external_catalog_dataset_options");
        set => this.WithProperty("external_catalog_dataset_options", value);
    }

    /// <summary>
    /// Block for external_dataset_reference.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDatasetReference block(s) allowed")]
    public List<GoogleBigqueryDatasetExternalDatasetReferenceBlock>? ExternalDatasetReference
    {
        get => GetProperty<List<GoogleBigqueryDatasetExternalDatasetReferenceBlock>>("external_dataset_reference");
        set => this.WithProperty("external_dataset_reference", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryDatasetTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryDatasetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The time when this dataset was created, in milliseconds since the
    /// epoch.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The date when this dataset or any of its tables was last modified, in
    /// milliseconds since the epoch.
    /// </summary>
    public TerraformExpression LastModifiedTime => this["last_modified_time"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
