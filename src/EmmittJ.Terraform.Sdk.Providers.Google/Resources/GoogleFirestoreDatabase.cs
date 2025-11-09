using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_firestore_database resource.
/// </summary>
public class GoogleFirestoreDatabase : TerraformResource
{
    public GoogleFirestoreDatabase(string name) : base("google_firestore_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("earliest_version_time");
        this.DeclareOutput("etag");
        this.DeclareOutput("key_prefix");
        this.DeclareOutput("uid");
        this.DeclareOutput("update_time");
        this.DeclareOutput("version_retention_period");
    }

    /// <summary>
    /// The App Engine integration mode to use for this database. Possible values: [&amp;quot;ENABLED&amp;quot;, &amp;quot;DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? AppEngineIntegrationMode
    {
        get => GetProperty<TerraformProperty<string>>("app_engine_integration_mode");
        set => this.WithProperty("app_engine_integration_mode", value);
    }

    /// <summary>
    /// The concurrency control mode to use for this database. Possible values: [&amp;quot;OPTIMISTIC&amp;quot;, &amp;quot;PESSIMISTIC&amp;quot;, &amp;quot;OPTIMISTIC_WITH_ENTITY_GROUPS&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ConcurrencyMode
    {
        get => GetProperty<TerraformProperty<string>>("concurrency_mode");
        set => this.WithProperty("concurrency_mode", value);
    }

    /// <summary>
    /// The database edition. Possible values: [&amp;quot;STANDARD&amp;quot;, &amp;quot;ENTERPRISE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DatabaseEdition
    {
        get => GetProperty<TerraformProperty<string>>("database_edition");
        set => this.WithProperty("database_edition", value);
    }

    /// <summary>
    /// State of delete protection for the database.
    /// When delete protection is enabled, this database cannot be deleted.
    /// The default value is &#39;DELETE_PROTECTION_STATE_UNSPECIFIED&#39;, which is currently equivalent to &#39;DELETE_PROTECTION_DISABLED&#39;.
    /// **Note:** Additionally, to delete this database using &#39;terraform destroy&#39;, &#39;deletion_policy&#39; must be set to &#39;DELETE&#39;. Possible values: [&amp;quot;DELETE_PROTECTION_STATE_UNSPECIFIED&amp;quot;, &amp;quot;DELETE_PROTECTION_ENABLED&amp;quot;, &amp;quot;DELETE_PROTECTION_DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? DeleteProtectionState
    {
        get => GetProperty<TerraformProperty<string>>("delete_protection_state");
        set => this.WithProperty("delete_protection_state", value);
    }

    /// <summary>
    /// Deletion behavior for this database.
    /// If the deletion policy is &#39;ABANDON&#39;, the database will be removed from Terraform state but not deleted from Google Cloud upon destruction.
    /// If the deletion policy is &#39;DELETE&#39;, the database will both be removed from Terraform state and deleted from Google Cloud upon destruction.
    /// The default value is &#39;ABANDON&#39;.
    /// See also &#39;delete_protection&#39;.
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
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
    /// The location of the database. Available locations are listed at
    /// https://cloud.google.com/firestore/docs/locations.
    /// </summary>
    public TerraformProperty<string>? LocationId
    {
        get => GetProperty<TerraformProperty<string>>("location_id");
        set => this.WithProperty("location_id", value);
    }

    /// <summary>
    /// The ID to use for the database, which will become the final
    /// component of the database&#39;s resource name. This value should be 4-63
    /// characters. Valid characters are /[a-z][0-9]-/ with first character
    /// a letter and the last a letter or a number. Must not be
    /// UUID-like /[0-9a-f]{8}(-[0-9a-f]{4}){3}-[0-9a-f]{12}/.
    /// &amp;quot;(default)&amp;quot; database id is also valid.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Whether to enable the PITR feature on this database.
    /// If &#39;POINT_IN_TIME_RECOVERY_ENABLED&#39; is selected, reads are supported on selected versions of the data from within the past 7 days.
    /// versionRetentionPeriod and earliestVersionTime can be used to determine the supported versions. These include reads against any timestamp within the past hour
    /// and reads against 1-minute snapshots beyond 1 hour and within 7 days.
    /// If &#39;POINT_IN_TIME_RECOVERY_DISABLED&#39; is selected, reads are supported on any version of the data from within the past 1 hour. Default value: &amp;quot;POINT_IN_TIME_RECOVERY_DISABLED&amp;quot; Possible values: [&amp;quot;POINT_IN_TIME_RECOVERY_ENABLED&amp;quot;, &amp;quot;POINT_IN_TIME_RECOVERY_DISABLED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? PointInTimeRecoveryEnablement
    {
        get => GetProperty<TerraformProperty<string>>("point_in_time_recovery_enablement");
        set => this.WithProperty("point_in_time_recovery_enablement", value);
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
    /// Input only. A map of resource manager tags. Resource manager tag keys
    /// and values have the same definition as resource manager tags.
    /// Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.
    /// The field is ignored when empty. The field is immutable and causes
    /// resource replacement when mutated. To apply tags to an existing resource, see
    /// the &#39;google_tags_tag_value&#39; resource.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type of the database.
    /// See https://cloud.google.com/datastore/docs/firestore-or-datastore
    /// for information about how to choose. Possible values: [&amp;quot;FIRESTORE_NATIVE&amp;quot;, &amp;quot;DATASTORE_MODE&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Output only. The timestamp at which this database was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. The earliest timestamp at which older versions of the data can be read from the database. See versionRetentionPeriod above; this field is populated with now - versionRetentionPeriod.
    /// This value is continuously updated, and becomes stale the moment it is queried. If you are using this value to recover data, make sure to account for the time from the moment when the value is queried to the moment when you initiate the recovery.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression EarliestVersionTime => this["earliest_version_time"];

    /// <summary>
    /// Output only. This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an
    /// up-to-date value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output only. The keyPrefix for this database.
    /// This keyPrefix is used, in combination with the project id (&amp;quot;~&amp;quot;) to construct the application id
    /// that is returned from the Cloud Datastore APIs in Google App Engine first generation runtimes.
    /// This value may be empty in which case the appid to use for URL-encoded keys is the project_id (eg: foo instead of v~foo).
    /// </summary>
    public TerraformExpression KeyPrefix => this["key_prefix"];

    /// <summary>
    /// Output only. The system-generated UUID4 for this Database.
    /// </summary>
    public TerraformExpression Uid => this["uid"];

    /// <summary>
    /// Output only. The timestamp at which this database was most recently updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

    /// <summary>
    /// Output only. The period during which past versions of data are retained in the database.
    /// Any read or query can specify a readTime within this window, and will read the state of the database at that time.
    /// If the PITR feature is enabled, the retention period is 7 days. Otherwise, the retention period is 1 hour.
    /// A duration in seconds with up to nine fractional digits, ending with &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformExpression VersionRetentionPeriod => this["version_retention_period"];

}
