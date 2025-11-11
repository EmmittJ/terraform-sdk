using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_tiers.
/// </summary>
public partial class GoogleSqlTiersDataSource : TerraformDataSource
{
    public GoogleSqlTiersDataSource(string name) : base("google_sql_tiers", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Project ID of the project for which to list tiers.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The tiers attribute.
    /// </summary>
    [TerraformProperty("tiers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Tiers { get; }

}
