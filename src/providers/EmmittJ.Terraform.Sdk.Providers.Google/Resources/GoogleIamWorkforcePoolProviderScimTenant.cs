using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_iam_workforce_pool_provider_scim_tenant resource.
/// </summary>
public class GoogleIamWorkforcePoolProviderScimTenant : TerraformResource
{
    public GoogleIamWorkforcePoolProviderScimTenant(string name) : base("google_iam_workforce_pool_provider_scim_tenant", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("base_uri");
        this.DeclareOutput("name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// A user-specified description of the provider. Cannot exceed 256 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A user-specified display name for the scim tenant. Cannot exceed 32 characters.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    public required TerraformProperty<string> ProviderId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("provider_id");
        set => this.WithProperty("provider_id", value);
    }

    /// <summary>
    /// The ID to use for the SCIM tenant, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScimTenantId is required")]
    public required TerraformProperty<string> ScimTenantId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("scim_tenant_id");
        set => this.WithProperty("scim_tenant_id", value);
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformProperty<string> WorkforcePoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workforce_pool_id");
        set => this.WithProperty("workforce_pool_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Represents the base URI as defined in [RFC 7644, Section
    /// 1.3](https://datatracker.ietf.org/doc/html/rfc7644#section-1.3). Clients
    /// must use this as the root address for managing resources under the tenant.
    /// Format:
    /// https://iamscim.googleapis.com/{version}/{tenant_id}/
    /// </summary>
    public TerraformExpression BaseUri => this["base_uri"];

    /// <summary>
    /// Identifier. The resource name of the scim tenant.
    /// Format: &#39;locations/{location}/workforcePools/{workforce_pool}/providers/{workforce_pool_provider}/scimTenants/{scim_tenant_id}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the scim tenant.
    /// * STATE_UNSPECIFIED: State unspecified.
    /// * ACTIVE: The scim tenant is active and may be used to validate authentication credentials.
    /// * DELETED: The scim tenant is soft-deleted. Soft-deleted scim tenants are permanently
    ///   deleted after approximately 30 days.
    /// </summary>
    public TerraformExpression State => this["state"];

}
