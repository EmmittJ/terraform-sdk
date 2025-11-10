using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_database_instance_latest_recovery_time.
/// </summary>
public class GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource : TerraformDataSource
{
    public GoogleSqlDatabaseInstanceLatestRecoveryTimeDataSource(string name) : base("google_sql_database_instance_latest_recovery_time", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("latest_recovery_time");
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
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
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
    /// Timestamp, identifies when the source instance was deleted. If this instance is deleted, then you must set the timestamp.
    /// </summary>
    public TerraformProperty<string>? SourceInstanceDeletionTime
    {
        get => GetProperty<TerraformProperty<string>>("source_instance_deletion_time");
        set => this.WithProperty("source_instance_deletion_time", value);
    }

    /// <summary>
    /// Timestamp, identifies the latest recovery time of the source instance.
    /// </summary>
    public TerraformExpression LatestRecoveryTime => this["latest_recovery_time"];

}
