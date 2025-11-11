using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_default_service_account.
/// </summary>
public class GoogleBigqueryDefaultServiceAccountDataSource : TerraformDataSource
{
    public GoogleBigqueryDefaultServiceAccountDataSource(string name) : base("google_bigquery_default_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Email => new TerraformReference(this, "email");

    /// <summary>
    /// The member attribute.
    /// </summary>
    [TerraformPropertyName("member")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Member => new TerraformReference(this, "member");

}
