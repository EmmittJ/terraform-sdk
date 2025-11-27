using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access in GoogleBigqueryDataset.
/// Nesting mode: set
/// </summary>
public class GoogleBigqueryDatasetAccessBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access";

    /// <summary>
    /// A domain to grant access to. Any users signed in with the
    /// domain specified will be granted the specified access
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// An email address of a Google Group to grant access to.
    /// </summary>
    public TerraformValue<string>? GroupByEmail
    {
        get => new TerraformReference<string>(this, "group_by_email");
        set => SetArgument("group_by_email", value);
    }

    /// <summary>
    /// Some other type of member that appears in the IAM Policy but isn&#39;t a user,
    /// group, domain, or special group. For example: &#39;allUsers&#39;
    /// </summary>
    public TerraformValue<string>? IamMember
    {
        get => new TerraformReference<string>(this, "iam_member");
        set => SetArgument("iam_member", value);
    }

    /// <summary>
    /// Describes the rights granted to the user specified by the other
    /// member of the access object. Basic, predefined, and custom roles
    /// are supported. Predefined roles that have equivalent basic roles
    /// are swapped by the API to their basic counterparts. See
    /// [official docs](https://cloud.google.com/bigquery/docs/access-control).
    /// </summary>
    public TerraformValue<string>? Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// A special group to grant access to. Possible values include:
    /// * &#39;projectOwners&#39;: Owners of the enclosing project.
    /// * &#39;projectReaders&#39;: Readers of the enclosing project.
    /// * &#39;projectWriters&#39;: Writers of the enclosing project.
    /// * &#39;allAuthenticatedUsers&#39;: All authenticated BigQuery users.
    /// </summary>
    public TerraformValue<string>? SpecialGroup
    {
        get => new TerraformReference<string>(this, "special_group");
        set => SetArgument("special_group", value);
    }

    /// <summary>
    /// An email address of a user to grant access to. For example:
    /// fred@example.com
    /// </summary>
    public TerraformValue<string>? UserByEmail
    {
        get => new TerraformReference<string>(this, "user_by_email");
        set => SetArgument("user_by_email", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessBlockDatasetBlock>? Dataset
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// Routine block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Routine block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessBlockRoutineBlock>? Routine
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessBlockRoutineBlock>>("routine");
        set => SetArgument("routine", value);
    }

    /// <summary>
    /// View block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 View block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetAccessBlockViewBlock>? View
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetAccessBlockViewBlock>>("view");
        set => SetArgument("view", value);
    }

}

/// <summary>
/// Block type for condition in GoogleBigqueryDatasetAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => new TerraformReference<string>(this, "expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

}

/// <summary>
/// Block type for dataset in GoogleBigqueryDatasetAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessBlockDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// Which resources in the dataset this entry applies to. Currently, only views are supported,
    /// but additional target types may be added in the future. Possible values: VIEWS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTypes is required")]
    public TerraformList<string>? TargetTypes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "target_types").ResolveNodes(ctx));
        set => SetArgument("target_types", value);
    }

    /// <summary>
    /// Dataset block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dataset block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dataset block(s) allowed")]
    public required TerraformList<GoogleBigqueryDatasetAccessBlockDatasetBlockDatasetBlock> Dataset
    {
        get => GetRequiredArgument<TerraformList<GoogleBigqueryDatasetAccessBlockDatasetBlockDatasetBlock>>("dataset");
        set => SetArgument("dataset", value);
    }

}

/// <summary>
/// Block type for dataset in GoogleBigqueryDatasetAccessBlockDatasetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessBlockDatasetBlockDatasetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dataset";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for routine in GoogleBigqueryDatasetAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessBlockRoutineBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "routine";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the routine. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 256 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoutineId is required")]
    public required TerraformValue<string> RoutineId
    {
        get => new TerraformReference<string>(this, "routine_id");
        set => SetArgument("routine_id", value);
    }

}

/// <summary>
/// Block type for view in GoogleBigqueryDatasetAccessBlock.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetAccessBlockViewBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "view";

    /// <summary>
    /// The ID of the dataset containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The ID of the project containing this table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// The ID of the table. The ID must contain only letters (a-z,
    /// A-Z), numbers (0-9), or underscores (_). The maximum length
    /// is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => new TerraformReference<string>(this, "table_id");
        set => SetArgument("table_id", value);
    }

}


/// <summary>
/// Block type for default_encryption_configuration in GoogleBigqueryDataset.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_encryption_configuration";

    /// <summary>
    /// Describes the Cloud KMS encryption key that will be used to protect destination
    /// BigQuery table. The BigQuery Service Account associated with your project requires
    /// access to this encryption key.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => new TerraformReference<string>(this, "kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for external_catalog_dataset_options in GoogleBigqueryDataset.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_catalog_dataset_options";

    /// <summary>
    /// The storage location URI for all tables in the dataset. Equivalent to hive metastore&#39;s
    /// database locationUri. Maximum length of 1024 characters.
    /// </summary>
    public TerraformValue<string>? DefaultStorageLocationUri
    {
        get => new TerraformReference<string>(this, "default_storage_location_uri");
        set => SetArgument("default_storage_location_uri", value);
    }

    /// <summary>
    /// A map of key value pairs defining the parameters and properties of the open source schema.
    /// Maximum size of 2Mib.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

}


/// <summary>
/// Block type for external_dataset_reference in GoogleBigqueryDataset.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDatasetExternalDatasetReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_dataset_reference";

    /// <summary>
    /// The connection id that is used to access the externalSource.
    /// Format: projects/{projectId}/locations/{locationId}/connections/{connectionId}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionAttribute is required")]
    public required TerraformValue<string> ConnectionAttribute
    {
        get => new TerraformReference<string>(this, "connection");
        set => SetArgument("connection", value);
    }

    /// <summary>
    /// External source that backs this dataset.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalSource is required")]
    public required TerraformValue<string> ExternalSource
    {
        get => new TerraformReference<string>(this, "external_source");
        set => SetArgument("external_source", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryDataset.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDatasetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_dataset Terraform resource.
/// Manages a google_bigquery_dataset resource.
/// </summary>
public partial class GoogleBigqueryDataset(string name) : TerraformResource("google_bigquery_dataset", name)
{
    /// <summary>
    /// A unique ID for this dataset, without the project name. The ID
    /// must contain only letters (a-z, A-Z), numbers (0-9), or
    /// underscores (_). The maximum length is 1,024 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => new TerraformReference<string>(this, "dataset_id");
        set => SetArgument("dataset_id", value);
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
    public TerraformValue<string> DefaultCollation
    {
        get => new TerraformReference<string>(this, "default_collation");
        set => SetArgument("default_collation", value);
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
    public TerraformValue<double>? DefaultPartitionExpirationMs
    {
        get => new TerraformReference<double>(this, "default_partition_expiration_ms");
        set => SetArgument("default_partition_expiration_ms", value);
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
    public TerraformValue<double>? DefaultTableExpirationMs
    {
        get => new TerraformReference<double>(this, "default_table_expiration_ms");
        set => SetArgument("default_table_expiration_ms", value);
    }

    /// <summary>
    /// If set to &#39;true&#39;, delete all the tables in the
    /// dataset when destroying the resource; otherwise,
    /// destroying the resource will fail if tables are present.
    /// </summary>
    public TerraformValue<bool>? DeleteContentsOnDestroy
    {
        get => new TerraformReference<bool>(this, "delete_contents_on_destroy");
        set => SetArgument("delete_contents_on_destroy", value);
    }

    /// <summary>
    /// A user-friendly description of the dataset
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A descriptive name for the dataset
    /// </summary>
    public TerraformValue<string>? FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
        set => SetArgument("friendly_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// TRUE if the dataset and its table names are case-insensitive, otherwise FALSE.
    /// By default, this is FALSE, which means the dataset and its table names are
    /// case-sensitive. This field does not affect routine references.
    /// </summary>
    public TerraformValue<bool> IsCaseInsensitive
    {
        get => new TerraformReference<bool>(this, "is_case_insensitive");
        set => SetArgument("is_case_insensitive", value);
    }

    /// <summary>
    /// The labels associated with this dataset. You can use these to
    /// organize and group your datasets.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
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
    public TerraformValue<string>? Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Defines the time travel window in hours. The value can be from 48 to 168 hours (2 to 7 days).
    /// </summary>
    public TerraformValue<string> MaxTimeTravelHours
    {
        get => new TerraformReference<string>(this, "max_time_travel_hours");
        set => SetArgument("max_time_travel_hours", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The tags attached to this table. Tag keys are globally unique. Tag key is expected to be
    /// in the namespaced format, for example &amp;quot;123456789012/environment&amp;quot; where 123456789012 is the
    /// ID of the parent organization or project resource for this tag key. Tag value is expected
    /// to be the short name, for example &amp;quot;Production&amp;quot;. See [Tag definitions](https://cloud.google.com/iam/docs/tags-access-control#definitions)
    /// for more details.
    /// </summary>
    public TerraformMap<string>? ResourceTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "resource_tags").ResolveNodes(ctx));
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// Specifies the storage billing model for the dataset.
    /// Set this flag value to LOGICAL to use logical bytes for storage billing,
    /// or to PHYSICAL to use physical bytes instead.
    /// 
    /// LOGICAL is the default if this flag isn&#39;t specified.
    /// </summary>
    public TerraformValue<string> StorageBillingModel
    {
        get => new TerraformReference<string>(this, "storage_billing_model");
        set => SetArgument("storage_billing_model", value);
    }

    /// <summary>
    /// The time when this dataset was created, in milliseconds since the
    /// epoch.
    /// </summary>
    public TerraformValue<double> CreationTime
    {
        get => new TerraformReference<double>(this, "creation_time");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// A hash of the resource.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The date when this dataset or any of its tables was last modified, in
    /// milliseconds since the epoch.
    /// </summary>
    public TerraformValue<double> LastModifiedTime
    {
        get => new TerraformReference<double>(this, "last_modified_time");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// Access block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleBigqueryDatasetAccessBlock>? Access
    {
        get => GetArgument<TerraformSet<GoogleBigqueryDatasetAccessBlock>>("access");
        set => SetArgument("access", value);
    }

    /// <summary>
    /// DefaultEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DefaultEncryptionConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock>? DefaultEncryptionConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetDefaultEncryptionConfigurationBlock>>("default_encryption_configuration");
        set => SetArgument("default_encryption_configuration", value);
    }

    /// <summary>
    /// ExternalCatalogDatasetOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalCatalogDatasetOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock>? ExternalCatalogDatasetOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetExternalCatalogDatasetOptionsBlock>>("external_catalog_dataset_options");
        set => SetArgument("external_catalog_dataset_options", value);
    }

    /// <summary>
    /// ExternalDatasetReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalDatasetReference block(s) allowed")]
    public TerraformList<GoogleBigqueryDatasetExternalDatasetReferenceBlock>? ExternalDatasetReference
    {
        get => GetArgument<TerraformList<GoogleBigqueryDatasetExternalDatasetReferenceBlock>>("external_dataset_reference");
        set => SetArgument("external_dataset_reference", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryDatasetTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryDatasetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
