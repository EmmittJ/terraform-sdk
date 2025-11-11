using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_db_nodes.
/// </summary>
public partial class GoogleOracleDatabaseDbNodesDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseDbNodesDataSource(string name) : base("google_oracle_database_db_nodes", name)
    {
    }

    /// <summary>
    /// vmcluster
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmCluster is required")]
    [TerraformProperty("cloud_vm_cluster")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CloudVmCluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The db_nodes attribute.
    /// </summary>
    [TerraformProperty("db_nodes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DbNodes { get; }

}
