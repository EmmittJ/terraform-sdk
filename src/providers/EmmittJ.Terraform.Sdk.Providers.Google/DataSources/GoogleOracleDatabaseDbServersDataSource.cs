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
        get => new TerraformReference<string>(this, "cloud_exadata_infrastructure");
        set => SetArgument("cloud_exadata_infrastructure", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The db_servers attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbServers
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "db_servers").ResolveNodes(ctx));
    }

}
