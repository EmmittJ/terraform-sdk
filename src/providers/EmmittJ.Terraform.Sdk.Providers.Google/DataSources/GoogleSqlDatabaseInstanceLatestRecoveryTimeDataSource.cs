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
        SetOutput("latest_recovery_time");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("project");
        SetOutput("source_instance_deletion_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Timestamp, identifies when the source instance was deleted. If this instance is deleted, then you must set the timestamp.
    /// </summary>
    public TerraformProperty<string> SourceInstanceDeletionTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("source_instance_deletion_time");
        set => SetProperty("source_instance_deletion_time", value);
    }

    /// <summary>
    /// Timestamp, identifies the latest recovery time of the source instance.
    /// </summary>
    public TerraformExpression LatestRecoveryTime => this["latest_recovery_time"];

}
