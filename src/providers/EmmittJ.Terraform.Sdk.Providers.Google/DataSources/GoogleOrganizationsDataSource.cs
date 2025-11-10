using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organizations.
/// </summary>
public class GoogleOrganizationsDataSource : TerraformDataSource
{
    public GoogleOrganizationsDataSource(string name) : base("google_organizations", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The organizations attribute.
    /// </summary>
    [TerraformPropertyName("organizations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Organizations => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "organizations");

}
