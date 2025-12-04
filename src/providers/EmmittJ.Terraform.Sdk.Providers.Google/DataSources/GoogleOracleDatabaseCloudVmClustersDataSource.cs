using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_oracle_database_cloud_vm_clusters Terraform data source.
/// Retrieves information about a google_oracle_database_cloud_vm_clusters.
/// </summary>
public partial class GoogleOracleDatabaseCloudVmClustersDataSource(string name) : TerraformDataSource("google_oracle_database_cloud_vm_clusters", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
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
    /// The cloud_vm_clusters attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudVmClusters
        => AsReference("cloud_vm_clusters");

}
