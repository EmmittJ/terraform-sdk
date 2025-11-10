using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_forwarding_rules.
/// </summary>
public class GoogleComputeForwardingRulesDataSource : TerraformDataSource
{
    public GoogleComputeForwardingRulesDataSource(string name) : base("google_compute_forwarding_rules", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The rules attribute.
    /// </summary>
    [TerraformPropertyName("rules")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Rules => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "rules");

}
