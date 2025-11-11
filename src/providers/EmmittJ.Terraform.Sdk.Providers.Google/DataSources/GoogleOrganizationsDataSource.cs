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
    public TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The organizations attribute.
    /// </summary>
    [TerraformPropertyName("organizations")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Organizations => new TerraformReference(this, "organizations");

}
