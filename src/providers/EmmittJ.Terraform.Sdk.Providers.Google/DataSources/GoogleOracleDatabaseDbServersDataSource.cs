using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_oracle_database_db_servers Terraform data source.
/// Retrieves information about a google_oracle_database_db_servers.
/// </summary>
public partial class GoogleOracleDatabaseDbServersDataSource(string name) : TerraformDataSource("google_oracle_database_db_servers", name)
{
    /// <summary>
    /// exadata
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructure is required")]
    public required TerraformValue<string> CloudExadataInfrastructure
    {
        get => GetRequiredArgument<TerraformValue<string>>("cloud_exadata_infrastructure");
        set => SetArgument("cloud_exadata_infrastructure", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbServers
        => AsReference("db_servers");

}
