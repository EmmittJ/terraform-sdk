using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_autonomous_databases.
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasesDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseAutonomousDatabasesDataSource(string name) : base("google_oracle_database_autonomous_databases", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("autonomous_databases");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
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
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The autonomous_databases attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabases => this["autonomous_databases"];

}
