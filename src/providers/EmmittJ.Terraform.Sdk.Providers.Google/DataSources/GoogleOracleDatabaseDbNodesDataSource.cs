using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_db_nodes.
/// </summary>
public class GoogleOracleDatabaseDbNodesDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseDbNodesDataSource(string name) : base("google_oracle_database_db_nodes", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("db_nodes");
        SetOutput("cloud_vm_cluster");
        SetOutput("id");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// vmcluster
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmCluster is required")]
    public required TerraformProperty<string> CloudVmCluster
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_vm_cluster");
        set => SetProperty("cloud_vm_cluster", value);
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
    /// The db_nodes attribute.
    /// </summary>
    public TerraformExpression DbNodes => this["db_nodes"];

}
