using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organizations.
/// </summary>
public partial class GoogleOrganizationsDataSource : TerraformDataSource
{
    public GoogleOrganizationsDataSource(string name) : base("google_organizations", name)
    {
    }

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The organizations attribute.
    /// </summary>
    [TerraformProperty("organizations")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Organizations { get; }

}
