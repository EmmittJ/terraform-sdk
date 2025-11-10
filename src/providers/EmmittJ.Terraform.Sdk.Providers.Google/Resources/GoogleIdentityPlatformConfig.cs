using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for blocking_functions in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigBlockingFunctionsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for client in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigClientBlock : ITerraformBlock
{
    /// <summary>
    /// API key that can be used when making requests for this project.
    /// </summary>
    [TerraformPropertyName("api_key")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ApiKey => new TerraformReferenceProperty<TerraformProperty<string>>("", "api_key");

    /// <summary>
    /// Firebase subdomain.
    /// </summary>
    [TerraformPropertyName("firebase_subdomain")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FirebaseSubdomain => new TerraformReferenceProperty<TerraformProperty<string>>("", "firebase_subdomain");

}

/// <summary>
/// Block type for mfa in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMfaBlock : ITerraformBlock
{
    /// <summary>
    /// A list of usable second factors for this project. Possible values: [&amp;quot;PHONE_SMS&amp;quot;]
    /// </summary>
    [TerraformPropertyName("enabled_providers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? EnabledProviders { get; set; }

    /// <summary>
    /// Whether MultiFactor Authentication has been enabled for this project. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;MANDATORY&amp;quot;]
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> State { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "state");

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMonitoringBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for multi_tenant in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMultiTenantBlock : ITerraformBlock
{
    /// <summary>
    /// Whether this project can have tenants or not.
    /// </summary>
    [TerraformPropertyName("allow_tenants")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowTenants { get; set; }

    /// <summary>
    /// The default cloud parent org or folder that the tenant project should be created under.
    /// The parent resource name should be in the format of &amp;quot;/&amp;quot;, such as &amp;quot;folders/123&amp;quot; or &amp;quot;organizations/456&amp;quot;.
    /// If the value is not set, the tenant will be created under the same organization or folder as the agent project.
    /// </summary>
    [TerraformPropertyName("default_tenant_location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultTenantLocation { get; set; }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigQuotaBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for sign_in in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSignInBlock : ITerraformBlock
{
    /// <summary>
    /// Whether to allow more than one account to have the same email.
    /// </summary>
    [TerraformPropertyName("allow_duplicate_emails")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AllowDuplicateEmails { get; set; }

    /// <summary>
    /// Output only. Hash config information.
    /// </summary>
    [TerraformPropertyName("hash_config")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> HashConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "hash_config");

}

/// <summary>
/// Block type for sms_region_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSmsRegionConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_identity_platform_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIdentityPlatformConfig : TerraformResource
{
    public GoogleIdentityPlatformConfig(string name) : base("google_identity_platform_config", name)
    {
    }

    /// <summary>
    /// List of domains authorized for OAuth redirects.
    /// </summary>
    [TerraformPropertyName("authorized_domains")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<string>>> AuthorizedDomains { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "authorized_domains");

    /// <summary>
    /// Whether anonymous users will be auto-deleted after a period of 30 days
    /// </summary>
    [TerraformPropertyName("autodelete_anonymous_users")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AutodeleteAnonymousUsers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for blocking_functions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlockingFunctions block(s) allowed")]
    [TerraformPropertyName("blocking_functions")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigBlockingFunctionsBlock>>? BlockingFunctions { get; set; } = new();

    /// <summary>
    /// Block for client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Client block(s) allowed")]
    [TerraformPropertyName("client")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigClientBlock>>? Client { get; set; } = new();

    /// <summary>
    /// Block for mfa.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mfa block(s) allowed")]
    [TerraformPropertyName("mfa")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigMfaBlock>>? Mfa { get; set; } = new();

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    [TerraformPropertyName("monitoring")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigMonitoringBlock>>? Monitoring { get; set; } = new();

    /// <summary>
    /// Block for multi_tenant.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTenant block(s) allowed")]
    [TerraformPropertyName("multi_tenant")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigMultiTenantBlock>>? MultiTenant { get; set; } = new();

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformPropertyName("quota")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigQuotaBlock>>? Quota { get; set; } = new();

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    [TerraformPropertyName("sign_in")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigSignInBlock>>? SignIn { get; set; } = new();

    /// <summary>
    /// Block for sms_region_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsRegionConfig block(s) allowed")]
    [TerraformPropertyName("sms_region_config")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigSmsRegionConfigBlock>>? SmsRegionConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleIdentityPlatformConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The name of the Config resource
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
