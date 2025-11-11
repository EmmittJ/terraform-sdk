using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instance_latest_recovery_time.
/// </summary>
public partial class GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource(string name) : base("google_sql_database_instance_latest_recovery_time", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Timestamp, identifies when the source instance was deleted. If this instance is deleted, then you must set the timestamp.
    /// </summary>
    [TerraformProperty("source_instance_deletion_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceInstanceDeletionTime { get; set; }

    /// <summary>
    /// Timestamp, identifies the latest recovery time of the source instance.
    /// </summary>
    [TerraformProperty("latest_recovery_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LatestRecoveryTime { get; }

}
