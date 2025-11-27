using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_oracle_database_cloud_exadata_infrastructures Terraform data source.
/// Retrieves information about a google_oracle_database_cloud_exadata_infrastructures.
/// </summary>
public partial class GoogleOracleDatabaseCloudExadataInfrastructuresDataSource(string name) : TerraformDataSource("google_oracle_database_cloud_exadata_infrastructures", name)
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
    /// The cloud_exadata_infrastructures attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudExadataInfrastructures
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cloud_exadata_infrastructures").ResolveNodes(ctx));
    }

}
