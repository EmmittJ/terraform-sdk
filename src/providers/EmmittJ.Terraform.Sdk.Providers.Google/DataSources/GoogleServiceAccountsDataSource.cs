using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_service_accounts.
/// </summary>
public class GoogleServiceAccountsDataSource : TerraformDataSource
{
    public GoogleServiceAccountsDataSource(string name) : base("google_service_accounts", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformPropertyName("prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Prefix { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The regex attribute.
    /// </summary>
    [TerraformPropertyName("regex")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Regex { get; set; }

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Accounts => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "accounts");

}
