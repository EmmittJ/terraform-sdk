using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_default_service_account.
/// </summary>
public partial class GoogleBigqueryDefaultServiceAccountDataSource : TerraformDataSource
{
    public GoogleBigqueryDefaultServiceAccountDataSource(string name) : base("google_bigquery_default_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Email { get; }

    /// <summary>
    /// The member attribute.
    /// </summary>
    [TerraformProperty("member")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Member { get; }

}
