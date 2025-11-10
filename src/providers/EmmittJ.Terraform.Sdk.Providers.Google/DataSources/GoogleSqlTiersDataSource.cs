using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_tiers.
/// </summary>
public class GoogleSqlTiersDataSource : TerraformDataSource
{
    public GoogleSqlTiersDataSource(string name) : base("google_sql_tiers", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Project ID of the project for which to list tiers.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The tiers attribute.
    /// </summary>
    [TerraformPropertyName("tiers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Tiers => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tiers");

}
