using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_db_servers.
/// </summary>
public class GoogleOracleDatabaseDbServersDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseDbServersDataSource(string name) : base("google_oracle_database_db_servers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("db_servers");
    }

    /// <summary>
    /// exadata
    /// </summary>
    public TerraformProperty<string>? CloudExadataInfrastructure
    {
        get => GetProperty<TerraformProperty<string>>("cloud_exadata_infrastructure");
        set => this.WithProperty("cloud_exadata_infrastructure", value);
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
    public TerraformProperty<string>? Location
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
    /// The db_servers attribute.
    /// </summary>
    public TerraformExpression DbServers => this["db_servers"];

}
