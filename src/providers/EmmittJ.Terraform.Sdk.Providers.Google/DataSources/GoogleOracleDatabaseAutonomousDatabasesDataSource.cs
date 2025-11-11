using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_autonomous_databases.
/// </summary>
public class GoogleOracleDatabaseAutonomousDatabasesDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseAutonomousDatabasesDataSource(string name) : base("google_oracle_database_autonomous_databases", name)
    {
    }

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
    /// The autonomous_databases attribute.
    /// </summary>
    [TerraformPropertyName("autonomous_databases")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutonomousDatabases => new TerraformReference(this, "autonomous_databases");

}
