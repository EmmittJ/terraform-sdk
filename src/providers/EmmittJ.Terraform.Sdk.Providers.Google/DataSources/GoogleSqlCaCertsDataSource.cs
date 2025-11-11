using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_ca_certs.
/// </summary>
public partial class GoogleSqlCaCertsDataSource : TerraformDataSource
{
    public GoogleSqlCaCertsDataSource(string name) : base("google_sql_ca_certs", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformProperty("instance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The active_version attribute.
    /// </summary>
    [TerraformProperty("active_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ActiveVersion { get; }

    /// <summary>
    /// The certs attribute.
    /// </summary>
    [TerraformProperty("certs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Certs { get; }

}
