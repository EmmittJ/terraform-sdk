using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_db_nodes.
/// </summary>
public class GoogleOracleDatabaseDbNodesDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseDbNodesDataSource(string name) : base("google_oracle_database_db_nodes", name)
    {
    }

    /// <summary>
    /// vmcluster
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudVmCluster is required")]
    [TerraformPropertyName("cloud_vm_cluster")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CloudVmCluster { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The db_nodes attribute.
    /// </summary>
    [TerraformPropertyName("db_nodes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DbNodes => new TerraformReference(this, "db_nodes");

}
