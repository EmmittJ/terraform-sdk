using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instance_latest_recovery_time.
/// </summary>
public class GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource(string name) : base("google_sql_database_instance_latest_recovery_time", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Timestamp, identifies when the source instance was deleted. If this instance is deleted, then you must set the timestamp.
    /// </summary>
    [TerraformPropertyName("source_instance_deletion_time")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceInstanceDeletionTime { get; set; }

    /// <summary>
    /// Timestamp, identifies the latest recovery time of the source instance.
    /// </summary>
    [TerraformPropertyName("latest_recovery_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestRecoveryTime => new TerraformReference(this, "latest_recovery_time");

}
