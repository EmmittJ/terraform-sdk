using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_iam_workforce_pool_provider_scim_tenant resource.
/// </summary>
public partial class GoogleIamWorkforcePoolProviderScimTenant : TerraformResource
{
    public GoogleIamWorkforcePoolProviderScimTenant(string name) : base("google_iam_workforce_pool_provider_scim_tenant", name)
    {
    }

    /// <summary>
    /// A user-specified description of the provider. Cannot exceed 256 characters.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A user-specified display name for the scim tenant. Cannot exceed 32 characters.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    [TerraformProperty("provider_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProviderId { get; set; }

    /// <summary>
    /// The ID to use for the SCIM tenant, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScimTenantId is required")]
    [TerraformProperty("scim_tenant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ScimTenantId { get; set; }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    [TerraformProperty("workforce_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkforcePoolId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Represents the base URI as defined in [RFC 7644, Section
    /// 1.3](https://datatracker.ietf.org/doc/html/rfc7644#section-1.3). Clients
    /// must use this as the root address for managing resources under the tenant.
    /// Format:
    /// https://iamscim.googleapis.com/{version}/{tenant_id}/
    /// </summary>
    [TerraformProperty("base_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BaseUri { get; }

    /// <summary>
    /// Identifier. The resource name of the scim tenant.
    /// Format: &#39;locations/{location}/workforcePools/{workforce_pool}/providers/{workforce_pool_provider}/scimTenants/{scim_tenant_id}
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The current state of the scim tenant.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The scim tenant is active and may be used to validate authentication credentials.
    /// * DELETED: The scim tenant is soft-deleted. Soft-deleted scim tenants are permanently
    ///   deleted after approximately 30 days.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> State { get; }

}
