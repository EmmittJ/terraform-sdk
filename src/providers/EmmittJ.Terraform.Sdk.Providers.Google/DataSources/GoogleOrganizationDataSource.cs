using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization.
/// </summary>
public class GoogleOrganizationDataSource : TerraformDataSource
{
    public GoogleOrganizationDataSource(string name) : base("google_organization", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Domain { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [TerraformPropertyName("organization")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Organization { get; set; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The directory_customer_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_customer_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DirectoryCustomerId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "directory_customer_id");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LifecycleState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "lifecycle_state");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrgId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "org_id");

}
