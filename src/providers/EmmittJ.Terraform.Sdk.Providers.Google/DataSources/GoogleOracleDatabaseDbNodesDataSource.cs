using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_oracle_database_db_nodes Terraform data source.
/// Retrieves information about a google_oracle_database_db_nodes.
/// </summary>
public partial class GoogleOracleDatabaseDbNodesDataSource(string name) : TerraformDataSource("google_oracle_database_db_nodes", name)
{
    /// <summary>
    /// vmcluster
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmCluster is required")]
    public required TerraformValue<string> CloudVmCluster
    {
        get => new TerraformReference<string>(this, "cloud_vm_cluster");
        set => SetArgument("cloud_vm_cluster", value);
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
    /// The db_nodes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DbNodes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "db_nodes").ResolveNodes(ctx));
    }

}
