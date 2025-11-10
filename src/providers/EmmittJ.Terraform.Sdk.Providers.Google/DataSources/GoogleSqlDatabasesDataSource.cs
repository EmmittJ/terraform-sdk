using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_databases.
/// </summary>
public class GoogleSqlDatabasesDataSource : TerraformDataSource
{
    public GoogleSqlDatabasesDataSource(string name) : base("google_sql_databases", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("databases");
        SetOutput("id");
        SetOutput("instance");
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
    /// The name of the Cloud SQL database instance in which the database belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    public TerraformExpression Databases => this["databases"];

}
