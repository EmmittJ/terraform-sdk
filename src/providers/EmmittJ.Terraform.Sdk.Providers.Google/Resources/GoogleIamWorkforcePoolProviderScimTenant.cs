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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("base_uri");
        SetOutput("name");
        SetOutput("state");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("provider_id");
        SetOutput("scim_tenant_id");
        SetOutput("workforce_pool_id");
    }

    /// <summary>
    /// A user-specified description of the provider. Cannot exceed 256 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A user-specified display name for the scim tenant. Cannot exceed 32 characters.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderId is required")]
    public required TerraformProperty<string> ProviderId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provider_id");
        set => SetProperty("provider_id", value);
    }

    /// <summary>
    /// The ID to use for the SCIM tenant, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScimTenantId is required")]
    public required TerraformProperty<string> ScimTenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("scim_tenant_id");
        set => SetProperty("scim_tenant_id", value);
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforcePoolId is required")]
    public required TerraformProperty<string> WorkforcePoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workforce_pool_id");
        set => SetProperty("workforce_pool_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIamWorkforcePoolProviderScimTenantTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
