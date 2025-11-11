using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_spanner_database.
/// </summary>
public class GoogleSpannerDatabaseDataSource : TerraformDataSource
{
    public GoogleSpannerDatabaseDataSource(string name) : base("google_spanner_database", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance to create the database on.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// A unique identifier for the database, which cannot be changed after the
    /// instance is created. Values are of the form &#39;[a-z][-_a-z0-9]*[a-z0-9]&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The dialect of the Cloud Spanner Database.
    /// If it is not provided, &amp;quot;GOOGLE_STANDARD_SQL&amp;quot; will be used. Possible values: [&amp;quot;GOOGLE_STANDARD_SQL&amp;quot;, &amp;quot;POSTGRESQL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("database_dialect")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DatabaseDialect => new TerraformReference(this, "database_dialect");

    /// <summary>
    /// An optional list of DDL statements to run inside the database. Statements can create
    /// tables, indexes, etc.
    /// 
    /// During creation these statements execute atomically with the creation of the database
    /// and if there is an error in any statement, the database is not created.
    /// 
    /// Terraform does not perform drift detection on this field and assumes that the values
    /// recorded in state are accurate. Limited updates to this field are supported, and
    /// newly appended DDL statements can be executed in an update. However, modifications
    /// to prior statements will create a plan that marks the resource for recreation.
    /// </summary>
    [TerraformPropertyName("ddl")]
    // Output-only attribute - read-only reference
    public TerraformList<string> Ddl => new TerraformReference(this, "ddl");

    /// <summary>
    /// The default time zone for the database. The default time zone must be a valid name
    /// from the tz database. Default value is &amp;quot;America/Los_angeles&amp;quot;.
    /// </summary>
    [TerraformPropertyName("default_time_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultTimeZone => new TerraformReference(this, "default_time_zone");

    /// <summary>
    /// Whether Terraform will be prevented from destroying the database. Defaults to true.
    /// When a&#39;terraform destroy&#39; or &#39;terraform apply&#39; would delete the database,
    /// the command will fail if this field is not set to false in Terraform state.
    /// When the field is set to true or unset in Terraform state, a &#39;terraform apply&#39;
    /// or &#39;terraform destroy&#39; that would delete the database will fail.
    /// When the field is set to false, deleting the database is allowed.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// Whether drop protection is enabled for this database. Defaults to false.
    /// Drop protection is different from
    /// the &amp;quot;deletion_protection&amp;quot; attribute in the following ways:
    /// (1) &amp;quot;deletion_protection&amp;quot; only protects the database from deletions in Terraform.
    /// whereas setting “enableDropProtection” to true protects the database from deletions in all interfaces.
    /// (2) Setting &amp;quot;enableDropProtection&amp;quot; to true also prevents the deletion of the parent instance containing the database.
    /// &amp;quot;deletion_protection&amp;quot; attribute does not provide protection against the deletion of the parent instance.
    /// </summary>
    [TerraformPropertyName("enable_drop_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableDropProtection => new TerraformReference(this, "enable_drop_protection");

    /// <summary>
    /// Encryption configuration for the database
    /// </summary>
    [TerraformPropertyName("encryption_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EncryptionConfig => new TerraformReference(this, "encryption_config");

    /// <summary>
    /// An explanation of the status of the database.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// The retention period for the database. The retention period must be between 1 hour
    /// and 7 days, and can be specified in days, hours, minutes, or seconds. For example,
    /// the values 1d, 24h, 1440m, and 86400s are equivalent. Default value is 1h.
    /// If this property is used, you must avoid adding new DDL statements to &#39;ddl&#39; that
    /// update the database&#39;s version_retention_period.
    /// </summary>
    [TerraformPropertyName("version_retention_period")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VersionRetentionPeriod => new TerraformReference(this, "version_retention_period");

}
