using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_sql_database_instance_latest_recovery_time Terraform data source.
/// Retrieves information about a google_sql_database_instance_latest_recovery_time.
/// </summary>
public partial class GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource(string name) : TerraformDataSource("google_sql_database_instance_latest_recovery_time", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
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
    /// Timestamp, identifies when the source instance was deleted. If this instance is deleted, then you must set the timestamp.
    /// </summary>
    public TerraformValue<string>? SourceInstanceDeletionTime
    {
        get => new TerraformReference<string>(this, "source_instance_deletion_time");
        set => SetArgument("source_instance_deletion_time", value);
    }

    /// <summary>
    /// Timestamp, identifies the latest recovery time of the source instance.
    /// </summary>
    public TerraformValue<string> LatestRecoveryTime
    {
        get => new TerraformReference<string>(this, "latest_recovery_time");
    }

}
