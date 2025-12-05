using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleIamWorkforcePoolProviderScimTenant.
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_iam_workforce_pool_provider_scim_tenant Terraform resource.
/// Manages a google_iam_workforce_pool_provider_scim_tenant resource.
/// </summary>
public partial class GoogleIamWorkforcePoolProviderScimTenant(string name) : TerraformResource("google_iam_workforce_pool_provider_scim_tenant", name)
{
    /// <summary>
    /// A user-specified description of the provider. Cannot exceed 256 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A user-specified display name for the scim tenant. Cannot exceed 32 characters.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    public required TerraformValue<string> ProviderId
    {
        get => GetRequiredArgument<TerraformValue<string>>("provider_id");
        set => SetArgument("provider_id", value);
    }

    /// <summary>
    /// The ID to use for the SCIM tenant, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScimTenantId is required")]
    public required TerraformValue<string> ScimTenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("scim_tenant_id");
        set => SetArgument("scim_tenant_id", value);
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformValue<string> WorkforcePoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("workforce_pool_id");
        set => SetArgument("workforce_pool_id", value);
    }

    /// <summary>
    /// Represents the base URI as defined in [RFC 7644, Section
    /// 1.3](https://datatracker.ietf.org/doc/html/rfc7644#section-1.3). Clients
    /// must use this as the root address for managing resources under the tenant.
    /// Format:
    /// https://iamscim.googleapis.com/{version}/{tenant_id}/
    /// </summary>
    public TerraformValue<string> BaseUri
        => CreateReference("base_uri");

    /// <summary>
    /// Identifier. The resource name of the scim tenant.
    /// Format: &#39;locations/{location}/workforcePools/{workforce_pool}/providers/{workforce_pool_provider}/scimTenants/{scim_tenant_id}
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The current state of the scim tenant.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The scim tenant is active and may be used to validate authentication credentials.
    /// * DELETED: The scim tenant is soft-deleted. Soft-deleted scim tenants are permanently
    ///   deleted after approximately 30 days.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
