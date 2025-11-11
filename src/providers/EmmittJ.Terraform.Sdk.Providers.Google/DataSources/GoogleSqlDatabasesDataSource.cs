using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_databases.
/// </summary>
public partial class GoogleSqlDatabasesDataSource : TerraformDataSource
{
    public GoogleSqlDatabasesDataSource(string name) : base("google_sql_databases", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the Cloud SQL database instance in which the database belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformProperty("databases")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Databases { get; }

}
