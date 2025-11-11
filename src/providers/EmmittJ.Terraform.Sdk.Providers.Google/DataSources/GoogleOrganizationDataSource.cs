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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Domain { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [TerraformPropertyName("organization")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Organization { get; set; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The directory_customer_id attribute.
    /// </summary>
    [TerraformPropertyName("directory_customer_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DirectoryCustomerId => new TerraformReference(this, "directory_customer_id");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformPropertyName("lifecycle_state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LifecycleState => new TerraformReference(this, "lifecycle_state");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrgId => new TerraformReference(this, "org_id");

}
