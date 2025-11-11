using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_organization.
/// </summary>
public partial class GoogleOrganizationDataSource : TerraformDataSource
{
    public GoogleOrganizationDataSource(string name) : base("google_organization", name)
    {
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The organization attribute.
    /// </summary>
    [TerraformProperty("organization")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Organization { get; set; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The directory_customer_id attribute.
    /// </summary>
    [TerraformProperty("directory_customer_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DirectoryCustomerId { get; }

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    [TerraformProperty("lifecycle_state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LifecycleState { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformProperty("org_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OrgId { get; }

}
