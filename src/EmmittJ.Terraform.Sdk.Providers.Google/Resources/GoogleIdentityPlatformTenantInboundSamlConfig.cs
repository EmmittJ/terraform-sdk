using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_identity_platform_tenant_inbound_saml_config resource.
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfig : TerraformResource
{
    public GoogleIdentityPlatformTenantInboundSamlConfig(string name) : base("google_identity_platform_tenant_inbound_saml_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Human friendly display name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The name of the InboundSamlConfig resource. Must start with &#39;saml.&#39; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &#39;saml.&#39; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the tenant where this inbound SAML config resource exists
    /// </summary>
    public TerraformProperty<string>? Tenant
    {
        get => GetProperty<TerraformProperty<string>>("tenant");
        set => this.WithProperty("tenant", value);
    }

}
