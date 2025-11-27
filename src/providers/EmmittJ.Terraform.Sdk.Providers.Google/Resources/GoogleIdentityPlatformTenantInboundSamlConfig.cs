using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for idp_config in GoogleIdentityPlatformTenantInboundSamlConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idp_config";

    /// <summary>
    /// Unique identifier for all SAML entities
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpEntityId is required")]
    public required TerraformValue<string> IdpEntityId
    {
        get => new TerraformReference<string>(this, "idp_entity_id");
        set => SetArgument("idp_entity_id", value);
    }

    /// <summary>
    /// Indicates if outbounding SAMLRequest should be signed.
    /// </summary>
    public TerraformValue<bool>? SignRequest
    {
        get => new TerraformReference<bool>(this, "sign_request");
        set => SetArgument("sign_request", value);
    }

    /// <summary>
    /// URL to send Authentication request to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SsoUrl is required")]
    public required TerraformValue<string> SsoUrl
    {
        get => new TerraformReference<string>(this, "sso_url");
        set => SetArgument("sso_url", value);
    }

    /// <summary>
    /// IdpCertificates block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpCertificates is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IdpCertificates block(s) required")]
    public required TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlockIdpCertificatesBlock> IdpCertificates
    {
        get => GetRequiredArgument<TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlockIdpCertificatesBlock>>("idp_certificates");
        set => SetArgument("idp_certificates", value);
    }

}

/// <summary>
/// Block type for idp_certificates in GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlockIdpCertificatesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "idp_certificates";

    /// <summary>
    /// The x509 certificate
    /// </summary>
    public TerraformValue<string>? X509Certificate
    {
        get => new TerraformReference<string>(this, "x509_certificate");
        set => SetArgument("x509_certificate", value);
    }

}


/// <summary>
/// Block type for sp_config in GoogleIdentityPlatformTenantInboundSamlConfig.
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sp_config";

    /// <summary>
    /// Callback URI where responses from IDP are handled. Must start with &#39;https://&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallbackUri is required")]
    public required TerraformValue<string> CallbackUri
    {
        get => new TerraformReference<string>(this, "callback_uri");
        set => SetArgument("callback_uri", value);
    }

    /// <summary>
    /// The IDP&#39;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// </summary>
    public TerraformList<TerraformMap<object>> SpCertificates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sp_certificates").ResolveNodes(ctx));
    }

    /// <summary>
    /// Unique identifier for all SAML entities.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpEntityId is required")]
    public required TerraformValue<string> SpEntityId
    {
        get => new TerraformReference<string>(this, "sp_entity_id");
        set => SetArgument("sp_entity_id", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleIdentityPlatformTenantInboundSamlConfig.
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_identity_platform_tenant_inbound_saml_config Terraform resource.
/// Manages a google_identity_platform_tenant_inbound_saml_config resource.
/// </summary>
public partial class GoogleIdentityPlatformTenantInboundSamlConfig(string name) : TerraformResource("google_identity_platform_tenant_inbound_saml_config", name)
{
    /// <summary>
    /// Human friendly display name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// If this config allows users to sign in with the provider.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the InboundSamlConfig resource. Must start with &#39;saml.&#39; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &#39;saml.&#39; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The name of the tenant where this inbound SAML config resource exists
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tenant is required")]
    public required TerraformValue<string> Tenant
    {
        get => new TerraformReference<string>(this, "tenant");
        set => SetArgument("tenant", value);
    }

    /// <summary>
    /// IdpConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IdpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IdpConfig block(s) allowed")]
    public required TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock> IdpConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigIdpConfigBlock>>("idp_config");
        set => SetArgument("idp_config", value);
    }

    /// <summary>
    /// SpConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SpConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SpConfig block(s) allowed")]
    public required TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock> SpConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleIdentityPlatformTenantInboundSamlConfigSpConfigBlock>>("sp_config");
        set => SetArgument("sp_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleIdentityPlatformTenantInboundSamlConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
