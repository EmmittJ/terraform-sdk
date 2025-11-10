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
        this.DeclareOutput("autonomous_databases");
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
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The autonomous_databases attribute.
    /// </summary>
    public TerraformExpression AutonomousDatabases => this["autonomous_databases"];

}
