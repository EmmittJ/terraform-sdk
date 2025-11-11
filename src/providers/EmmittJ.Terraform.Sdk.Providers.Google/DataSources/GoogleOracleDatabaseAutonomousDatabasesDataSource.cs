using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_autonomous_databases.
/// </summary>
public partial class GoogleOracleDatabaseAutonomousDatabasesDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseAutonomousDatabasesDataSource(string name) : base("google_oracle_database_autonomous_databases", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The autonomous_databases attribute.
    /// </summary>
    [TerraformProperty("autonomous_databases")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutonomousDatabases { get; }

}
