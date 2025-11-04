using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// A user-specified display name for the scim tenant. Cannot exceed 32 characters.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location for the resource.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the provider.
    /// </summary>
    public string? ProviderId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provider_id")?.Value;
        set => this.WithProperty("provider_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID to use for the SCIM tenant, which becomes the final component of the resource name. This value must be 4-32 characters, and may contain the characters [a-z0-9-].
    /// </summary>
    public string? ScimTenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scim_tenant_id")?.Value;
        set => this.WithProperty("scim_tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the workforce pool.
    /// </summary>
    public string? WorkforcePoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workforce_pool_id")?.Value;
        set => this.WithProperty("workforce_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
