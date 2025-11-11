using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_accounts.
/// </summary>
public partial class GoogleServiceAccountsDataSource : TerraformDataSource
{
    public GoogleServiceAccountsDataSource(string name) : base("google_service_accounts", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    [TerraformProperty("regex")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Regex { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Accounts { get; }

}
