using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for cmek_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleFirestoreDatabaseCmekConfigBlock() : TerraformBlock("cmek_config")
{

    /// <summary>
    /// The resource ID of a Cloud KMS key. If set, the database created will
    /// be a Customer-managed Encryption Key (CMEK) database encrypted with
    /// this key. This feature is allowlist only in initial launch.
    /// 
    /// Only keys in the same location as this database are allowed to be used
    /// for encryption. For Firestore&#39;s nam5 multi-region, this corresponds to Cloud KMS
    /// multi-region us. For Firestore&#39;s eur3 multi-region, this corresponds to
    /// Cloud KMS multi-region europe. See https://cloud.google.com/kms/docs/locations.
    /// 
    /// This value should be the KMS key resource ID in the format of
    /// &#39;projects/{project_id}/locations/{kms_location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}&#39;.
    /// How to retrieve this resource ID is listed at
    /// https://cloud.google.com/kms/docs/getting-resource-ids#getting_the_id_for_a_key_and_version.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleFirestoreDatabaseTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_firestore_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleFirestoreDatabase : TerraformResource
{
    public GoogleFirestoreDatabase(string name) : base("google_firestore_database", name)
    {
    }

    /// <summary>
    /// The App Engine integration mode to use for this database. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("app_engine_integration_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AppEngineIntegrationMode { get; set; }

    /// <summary>
    /// The concurrency control mode to use for this database. Possible values: [&amp;quot;OPTIMISTIC&amp;quot;, &amp;quot;PESSIMISTIC&amp;quot;, &amp;quot;OPTIMISTIC_WITH_ENTITY_GROUPS&amp;quot;]
    /// </summary>
    [TerraformProperty("concurrency_mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ConcurrencyMode { get; set; }

    /// <summary>
    /// The database edition. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    [TerraformProperty("database_edition")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DatabaseEdition { get; set; }

    /// <summary>
    /// State of delete protection for the database.
    /// When delete protection is enabled, this database cannot be deleted.
    /// The default value is &#39;DELETE_PROTECTION_STATE_UNSPECIFIED&#39;, which is currently equivalent to &#39;DELETE_PROTECTION_DISABLED&#39;.
    /// **Note:** Additionally, to delete this database using &#39;terraform destroy&#39;, &#39;deletion_policy&#39; must be set to &#39;DELETE&#39;. Possible values: [&amp;quot;DELETE_PROTECTION_STATE_UNSPECIFIED&amp;quot;, &amp;quot;DELETE_PROTECTION_ENABLED&amp;quot;, &amp;quot;DELETE_PROTECTION_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("delete_protection_state")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DeleteProtectionState { get; set; }

    /// <summary>
    /// Deletion behavior for this database.
    /// If the deletion policy is &#39;ABANDON&#39;, the database will be removed from Terraform state but not deleted from Google Cloud upon destruction.
    /// If the deletion policy is &#39;DELETE&#39;, the database will both be removed from Terraform state and deleted from Google Cloud upon destruction.
    /// The default value is &#39;ABANDON&#39;.
    /// See also &#39;delete_protection&#39;.
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location of the database. Available locations are listed at
    /// https://cloud.google.com/firestore/docs/locations.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationId is required")]
    [TerraformProperty("location_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocationId { get; set; }

    /// <summary>
    /// The ID to use for the database, which will become the final
    /// component of the database&#39;s resource name. This value should be 4-63
    /// characters. Valid characters are /[a-z][0-9]-/ with first character
    /// a letter and the last a letter or a number. Must not be
    /// UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/.
    /// &amp;quot;(default)&amp;quot; database id is also valid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Whether to enable the PITR feature on this database.
    /// If &#39;POINT_IN_TIME_RECOVERY_ENABLED&#39; is selected, reads are supported on selected versions of the data from within the past 7 days.
    /// versionRetentionPeriod and earliestVersionTime can be used to determine the supported versions. These include reads against any timestamp within the past hour
    /// and reads against 1-minute snapshots beyond 1 hour and within 7 days.
    /// If &#39;POINT_IN_TIME_RECOVERY_DISABLED&#39; is selected, reads are supported on any version of the data from within the past 1 hour. Default value: &amp;quot;POINT_IN_TIME_RECOVERY_DISABLED&amp;quot; Possible values: [&amp;quot;POINT_IN_TIME_RECOVERY_ENABLED&amp;quot;, &amp;quot;POINT_IN_TIME_RECOVERY_DISABLED&amp;quot;]
    /// </summary>
    [TerraformProperty("point_in_time_recovery_enablement")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PointInTimeRecoveryEnablement { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Input only. A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// The field is ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. To apply tags to an existing resource, see
    /// the &#39;google_tags_tag_value&#39; resource.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The type of the database.
    /// See https://cloud.google.com/datastore/docs/firestore-or-datastore
    /// for information about how to choose. Possible values: [&amp;quot;FIRESTORE_NATIVE&amp;quot;, &amp;quot;DATASTORE_MODE&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for cmek_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CmekConfig block(s) allowed")]
    [TerraformProperty("cmek_config")]
    public TerraformList<GoogleFirestoreDatabaseCmekConfigBlock> CmekConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleFirestoreDatabaseTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. The timestamp at which this database was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Output only. The earliest timestamp at which older versions of the data can be read from the database. See versionRetentionPeriod above; this field is populated with now - versionRetentionPeriod.
    /// This value is continuously updated, and becomes stale the moment it is queried. If you are using this value to recover data, make sure to account for the time from the moment when the value is queried to the moment when you initiate the recovery.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("earliest_version_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EarliestVersionTime { get; }

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an
    /// up-to-date value before proceeding.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output only. The keyPrefix for this database.
    /// This keyPrefix is used, in combination with the project id (&amp;quot;~&amp;quot;) to construct the application id
    /// that is returned from the Cloud Datastore APIs in Google App Engine first generation runtimes.
    /// This value may be empty in which case the appid to use for URL-encoded keys is the project_id (eg: foo instead of v~foo).
    /// </summary>
    [TerraformProperty("key_prefix")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyPrefix { get; }

    /// <summary>
    /// Output only. The system-generated UUID4 for this Database.
    /// </summary>
    [TerraformProperty("uid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uid { get; }

    /// <summary>
    /// Output only. The timestamp at which this database was most recently updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

    /// <summary>
    /// Output only. The period during which past versions of data are retained in the database.
    /// Any read or query can specify a readTime within this window, and will read the state of the database at that time.
    /// If the PITR feature is enabled, the retention period is 7 days. Otherwise, the retention period is 1 hour.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    [TerraformProperty("version_retention_period")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VersionRetentionPeriod { get; }

}
