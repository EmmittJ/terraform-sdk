using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for blocking_functions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigBlockingFunctionsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for client in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigClientBlock : TerraformBlockBase
{


}

/// <summary>
/// Block type for mfa in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigMfaBlock : TerraformBlockBase
{
    /// <summary>
    /// A list of usable second factors for this project. Possible values: [&amp;quot;PHONE_SMS&amp;quot;]
    /// </summary>
    [TerraformProperty("enabled_providers")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? EnabledProviders { get; set; }

    /// <summary>
    /// Whether MultiFactor Authentication has been enabled for this project. Possible values: [&amp;quot;DISABLED&amp;quot;, &amp;quot;ENABLED&amp;quot;, &amp;quot;MANDATORY&amp;quot;]
    /// </summary>
    [TerraformProperty("state")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> State { get; set; }

}

/// <summary>
/// Block type for monitoring in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigMonitoringBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for multi_tenant in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigMultiTenantBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether this project can have tenants or not.
    /// </summary>
    [TerraformProperty("allow_tenants")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowTenants { get; set; }

    /// <summary>
    /// The default cloud parent org or folder that the tenant project should be created under.
    /// The parent resource name should be in the format of &amp;quot;/&amp;quot;, such as &amp;quot;folders/123&amp;quot; or &amp;quot;organizations/456&amp;quot;.
    /// If the value is not set, the tenant will be created under the same organization or folder as the agent project.
    /// </summary>
    [TerraformProperty("default_tenant_location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultTenantLocation { get; set; }

}

/// <summary>
/// Block type for quota in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigQuotaBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for sign_in in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigSignInBlock : TerraformBlockBase
{
    /// <summary>
    /// Whether to allow more than one account to have the same email.
    /// </summary>
    [TerraformProperty("allow_duplicate_emails")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowDuplicateEmails { get; set; }


}

/// <summary>
/// Block type for sms_region_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleIdentityPlatformConfigSmsRegionConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleIdentityPlatformConfigTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_identity_platform_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleIdentityPlatformConfig : TerraformResource
{
    public GoogleIdentityPlatformConfig(string name) : base("google_identity_platform_config", name)
    {
    }

    /// <summary>
    /// List of domains authorized for OAuth redirects.
    /// </summary>
    [TerraformProperty("authorized_domains")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> AuthorizedDomains { get; set; }

    /// <summary>
    /// Whether anonymous users will be auto-deleted after a period of 30 days
    /// </summary>
    [TerraformProperty("autodelete_anonymous_users")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutodeleteAnonymousUsers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for blocking_functions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BlockingFunctions block(s) allowed")]
    [TerraformProperty("blocking_functions")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigBlockingFunctionsBlock>>? BlockingFunctions { get; set; }

    /// <summary>
    /// Block for client.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Client block(s) allowed")]
    [TerraformProperty("client")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigClientBlock>>? Client { get; set; }

    /// <summary>
    /// Block for mfa.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Mfa block(s) allowed")]
    [TerraformProperty("mfa")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigMfaBlock>>? Mfa { get; set; }

    /// <summary>
    /// Block for monitoring.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Monitoring block(s) allowed")]
    [TerraformProperty("monitoring")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigMonitoringBlock>>? Monitoring { get; set; }

    /// <summary>
    /// Block for multi_tenant.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MultiTenant block(s) allowed")]
    [TerraformProperty("multi_tenant")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigMultiTenantBlock>>? MultiTenant { get; set; }

    /// <summary>
    /// Block for quota.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Quota block(s) allowed")]
    [TerraformProperty("quota")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigQuotaBlock>>? Quota { get; set; }

    /// <summary>
    /// Block for sign_in.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignIn block(s) allowed")]
    [TerraformProperty("sign_in")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigSignInBlock>>? SignIn { get; set; }

    /// <summary>
    /// Block for sms_region_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsRegionConfig block(s) allowed")]
    [TerraformProperty("sms_region_config")]
    public TerraformList<TerraformBlock<GoogleIdentityPlatformConfigSmsRegionConfigBlock>>? SmsRegionConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleIdentityPlatformConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The name of the Config resource
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
