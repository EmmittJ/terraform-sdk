using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for blocking_functions in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigBlockingFunctionsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for client in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigClientBlock : TerraformBlock
{
    /// <summary>
    /// API key that can be used when making requests for this project.
    /// </summary>
    public TerraformProperty<string>? ApiKey
    {
        set => SetProperty("api_key", value);
    }

    /// <summary>
    /// Firebase subdomain.
    /// </summary>
    public TerraformProperty<string>? FirebaseSubdomain
    {
        set => SetProperty("firebase_subdomain", value);
    }

}

/// <summary>
/// Block type for mfa in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMfaBlock : TerraformBlock
{
    /// <summary>
    /// A list of usable second factors for this project. Possible values: [&amp;quot;PHONE_SMS&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? EnabledProviders
    {
        set => SetProperty("enabled_providers", value);
    }

    /// <summary>
    /// Whether MultiFactor Authentication has been enabled for this project. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;MANDATORY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMonitoringBlock : TerraformBlock
{
}

/// <summary>
/// Block type for multi_tenant in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigMultiTenantBlock : TerraformBlock
{
    /// <summary>
    /// Whether this project can have tenants or not.
    /// </summary>
    public TerraformProperty<bool>? AllowTenants
    {
        set => SetProperty("allow_tenants", value);
    }

    /// <summary>
    /// The default cloud parent org or folder that the tenant project should be created under.
    /// The parent resource name should be in the format of &amp;quot;/&amp;quot;, such as &amp;quot;folders/123&amp;quot; or &amp;quot;organizations/456&amp;quot;.
    /// If the value is not set, the tenant will be created under the same organization or folder as the agent project.
    /// </summary>
    public TerraformProperty<string>? DefaultTenantLocation
    {
        set => SetProperty("default_tenant_location", value);
    }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigQuotaBlock : TerraformBlock
{
}

/// <summary>
/// Block type for sign_in in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSignInBlock : TerraformBlock
{
    /// <summary>
    /// Whether to allow more than one account to have the same email.
    /// </summary>
    public TerraformProperty<bool>? AllowDuplicateEmails
    {
        set => SetProperty("allow_duplicate_emails", value);
    }

    /// <summary>
    /// Output only. Hash config information.
    /// </summary>
    public List<TerraformProperty<object>>? HashConfig
    {
        set => SetProperty("hash_config", value);
    }

}

/// <summary>
/// Block type for sms_region_config in .
/// Nesting mode: list
/// </summary>
public class GoogleIdentityPlatformConfigSmsRegionConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_identity_platform_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleIdentityPlatformConfig : TerraformResource
{
    public GoogleIdentityPlatformConfig(string name) : base("google_identity_platform_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("authorized_domains");
        SetOutput("autodelete_anonymous_users");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// List of domains authorized for OAuth redirects.
    /// </summary>
    public List<TerraformProperty<string>> AuthorizedDomains
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("authorized_domains");
        set => SetProperty("authorized_domains", value);
    }

    /// <summary>
    /// Whether anonymous users will be auto-deleted after a period of 30 days
    /// </summary>
    public TerraformProperty<bool> AutodeleteAnonymousUsers
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("autodelete_anonymous_users");
        set => SetProperty("autodelete_anonymous_users", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for blocking_functions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlockingFunctions block(s) allowed")]
    public List<GoogleIdentityPlatformConfigBlockingFunctionsBlock>? BlockingFunctions
    {
        set => SetProperty("blocking_functions", value);
    }

    /// <summary>
    /// Block for client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Client block(s) allowed")]
    public List<GoogleIdentityPlatformConfigClientBlock>? Client
    {
        set => SetProperty("client", value);
    }

    /// <summary>
    /// Block for mfa.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mfa block(s) allowed")]
    public List<GoogleIdentityPlatformConfigMfaBlock>? Mfa
    {
        set => SetProperty("mfa", value);
    }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    public List<GoogleIdentityPlatformConfigMonitoringBlock>? Monitoring
    {
        set => SetProperty("monitoring", value);
    }

    /// <summary>
    /// Block for multi_tenant.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTenant block(s) allowed")]
    public List<GoogleIdentityPlatformConfigMultiTenantBlock>? MultiTenant
    {
        set => SetProperty("multi_tenant", value);
    }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    public List<GoogleIdentityPlatformConfigQuotaBlock>? Quota
    {
        set => SetProperty("quota", value);
    }

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    public List<GoogleIdentityPlatformConfigSignInBlock>? SignIn
    {
        set => SetProperty("sign_in", value);
    }

    /// <summary>
    /// Block for sms_region_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsRegionConfig block(s) allowed")]
    public List<GoogleIdentityPlatformConfigSmsRegionConfigBlock>? SmsRegionConfig
    {
        set => SetProperty("sms_region_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIdentityPlatformConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the Config resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
