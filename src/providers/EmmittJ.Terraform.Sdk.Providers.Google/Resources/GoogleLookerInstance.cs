using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admin_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceAdminSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Email domain allowlist for the instance.
    /// 
    /// Define the email domains to which your users can deliver Looker (Google Cloud core) content.
    /// Updating this list will restart the instance. Updating the allowed email domains from terraform
    /// means the value provided will be considered as the entire list and not an amendment to the
    /// existing list of allowed email domains.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedEmailDomains
    {
        set => SetProperty("allowed_email_domains", value);
    }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceCustomDomainBlock : TerraformBlock
{
    /// <summary>
    /// Domain name
    /// </summary>
    public TerraformProperty<string>? Domain
    {
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// Status of the custom domain.
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for deny_maintenance_period in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceDenyMaintenancePeriodBlock : TerraformBlock
{
}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Name of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        set => SetProperty("kms_key_name", value);
    }

    /// <summary>
    /// Full name and version of the CMEK key currently in use to encrypt Looker data.
    /// </summary>
    public TerraformProperty<string>? KmsKeyNameVersion
    {
        set => SetProperty("kms_key_name_version", value);
    }

    /// <summary>
    /// Status of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeyState
    {
        set => SetProperty("kms_key_state", value);
    }

}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Required. Day of the week for this MaintenanceWindow (in UTC).
    /// 
    /// - MONDAY: Monday
    /// - TUESDAY: Tuesday
    /// - WEDNESDAY: Wednesday
    /// - THURSDAY: Thursday
    /// - FRIDAY: Friday
    /// - SATURDAY: Saturday
    /// - SUNDAY: Sunday Possible values: [&amp;quot;MONDAY&amp;quot;, &amp;quot;TUESDAY&amp;quot;, &amp;quot;WEDNESDAY&amp;quot;, &amp;quot;THURSDAY&amp;quot;, &amp;quot;FRIDAY&amp;quot;, &amp;quot;SATURDAY&amp;quot;, &amp;quot;SUNDAY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DayOfWeek is required")]
    public required TerraformProperty<string> DayOfWeek
    {
        set => SetProperty("day_of_week", value);
    }

}

/// <summary>
/// Block type for oauth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// The client ID for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client secret for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        set => SetProperty("client_secret", value);
    }

}

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstancePscConfigBlock : TerraformBlock
{
    /// <summary>
    /// List of VPCs that are allowed ingress into the Looker instance.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedVpcs
    {
        set => SetProperty("allowed_vpcs", value);
    }

    /// <summary>
    /// URI of the Looker service attachment.
    /// </summary>
    public TerraformProperty<string>? LookerServiceAttachmentUri
    {
        set => SetProperty("looker_service_attachment_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLookerInstanceTimeoutsBlock : TerraformBlock
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
/// Block type for user_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceUserMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Number of additional Developer Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformProperty<double>? AdditionalDeveloperUserCount
    {
        set => SetProperty("additional_developer_user_count", value);
    }

    /// <summary>
    /// Number of additional Standard Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformProperty<double>? AdditionalStandardUserCount
    {
        set => SetProperty("additional_standard_user_count", value);
    }

    /// <summary>
    /// Number of additional Viewer Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformProperty<double>? AdditionalViewerUserCount
    {
        set => SetProperty("additional_viewer_user_count", value);
    }

}

/// <summary>
/// Manages a google_looker_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLookerInstance : TerraformResource
{
    public GoogleLookerInstance(string name) : base("google_looker_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("egress_public_ip");
        SetOutput("ingress_private_ip");
        SetOutput("ingress_public_ip");
        SetOutput("looker_uri");
        SetOutput("looker_version");
        SetOutput("update_time");
        SetOutput("consumer_network");
        SetOutput("deletion_policy");
        SetOutput("fips_enabled");
        SetOutput("gemini_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("platform_edition");
        SetOutput("private_ip_enabled");
        SetOutput("project");
        SetOutput("psc_enabled");
        SetOutput("public_ip_enabled");
        SetOutput("region");
        SetOutput("reserved_range");
    }

    /// <summary>
    /// Network name in the consumer project in the format of: projects/{project}/global/networks/{network}
    /// Note that the consumer network may be in a different GCP project than the consumer
    /// project that is hosting the Looker Instance.
    /// </summary>
    public TerraformProperty<string> ConsumerNetwork
    {
        get => GetRequiredOutput<TerraformProperty<string>>("consumer_network");
        set => SetProperty("consumer_network", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// If setting deletion_policy = &amp;quot;FORCE&amp;quot;, the Looker instance will be deleted regardless
    /// of its nested resources. If set to &amp;quot;DEFAULT&amp;quot;, Looker instances that still have
    /// nested resources will return an error. Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformProperty<string> DeletionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_policy");
        set => SetProperty("deletion_policy", value);
    }

    /// <summary>
    /// FIPS 140-2 Encryption enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformProperty<bool> FipsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fips_enabled");
        set => SetProperty("fips_enabled", value);
    }

    /// <summary>
    /// Gemini enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformProperty<bool> GeminiEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("gemini_enabled");
        set => SetProperty("gemini_enabled", value);
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
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Platform editions for a Looker instance. Each edition maps to a set of instance features, like its size. Must be one of these values:
    /// - LOOKER_CORE_TRIAL: trial instance (Currently Unavailable)
    /// - LOOKER_CORE_STANDARD: pay as you go standard instance (Currently Unavailable)
    /// - LOOKER_CORE_STANDARD_ANNUAL: subscription standard instance
    /// - LOOKER_CORE_ENTERPRISE_ANNUAL: subscription enterprise instance
    /// - LOOKER_CORE_EMBED_ANNUAL: subscription embed instance
    /// - LOOKER_CORE_NONPROD_STANDARD_ANNUAL: nonprod subscription standard instance
    /// - LOOKER_CORE_NONPROD_ENTERPRISE_ANNUAL: nonprod subscription enterprise instance
    /// - LOOKER_CORE_NONPROD_EMBED_ANNUAL: nonprod subscription embed instance
    /// - LOOKER_CORE_TRIAL_STANDARD: A standard trial edition of Looker (Google Cloud core) product.
    /// - LOOKER_CORE_TRIAL_ENTERPRISE: An enterprise trial edition of Looker (Google Cloud core) product.
    /// - LOOKER_CORE_TRIAL_EMBED: An embed trial edition of Looker (Google Cloud core) product. Default value: &amp;quot;LOOKER_CORE_TRIAL&amp;quot; Possible values: [&amp;quot;LOOKER_CORE_TRIAL&amp;quot;, &amp;quot;LOOKER_CORE_STANDARD&amp;quot;, &amp;quot;LOOKER_CORE_STANDARD_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_ENTERPRISE_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_EMBED_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_NONPROD_STANDARD_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_NONPROD_ENTERPRISE_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_NONPROD_EMBED_ANNUAL&amp;quot;, &amp;quot;LOOKER_CORE_TRIAL_STANDARD&amp;quot;, &amp;quot;LOOKER_CORE_TRIAL_ENTERPRISE&amp;quot;, &amp;quot;LOOKER_CORE_TRIAL_EMBED&amp;quot;]
    /// </summary>
    public TerraformProperty<string> PlatformEdition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("platform_edition");
        set => SetProperty("platform_edition", value);
    }

    /// <summary>
    /// Whether private IP is enabled on the Looker instance.
    /// </summary>
    public TerraformProperty<bool> PrivateIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("private_ip_enabled");
        set => SetProperty("private_ip_enabled", value);
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
    /// Whether Public Service Connect (PSC) is enabled on the Looker instance
    /// </summary>
    public TerraformProperty<bool> PscEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("psc_enabled");
        set => SetProperty("psc_enabled", value);
    }

    /// <summary>
    /// Whether public IP is enabled on the Looker instance.
    /// </summary>
    public TerraformProperty<bool> PublicIpEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_ip_enabled");
        set => SetProperty("public_ip_enabled", value);
    }

    /// <summary>
    /// The name of the Looker region of the instance.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Name of a reserved IP address range within the consumer network, to be used for
    /// private service access connection. User may or may not specify this in a request.
    /// </summary>
    public TerraformProperty<string> ReservedRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reserved_range");
        set => SetProperty("reserved_range", value);
    }

    /// <summary>
    /// Block for admin_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminSettings block(s) allowed")]
    public List<GoogleLookerInstanceAdminSettingsBlock>? AdminSettings
    {
        set => SetProperty("admin_settings", value);
    }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public List<GoogleLookerInstanceCustomDomainBlock>? CustomDomain
    {
        set => SetProperty("custom_domain", value);
    }

    /// <summary>
    /// Block for deny_maintenance_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyMaintenancePeriod block(s) allowed")]
    public List<GoogleLookerInstanceDenyMaintenancePeriodBlock>? DenyMaintenancePeriod
    {
        set => SetProperty("deny_maintenance_period", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleLookerInstanceEncryptionConfigBlock>? EncryptionConfig
    {
        set => SetProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<GoogleLookerInstanceMaintenanceWindowBlock>? MaintenanceWindow
    {
        set => SetProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for oauth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OauthConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public List<GoogleLookerInstanceOauthConfigBlock>? OauthConfig
    {
        set => SetProperty("oauth_config", value);
    }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public List<GoogleLookerInstancePscConfigBlock>? PscConfig
    {
        set => SetProperty("psc_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleLookerInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserMetadata block(s) allowed")]
    public List<GoogleLookerInstanceUserMetadataBlock>? UserMetadata
    {
        set => SetProperty("user_metadata", value);
    }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Public Egress IP (IPv4).
    /// </summary>
    public TerraformExpression EgressPublicIp => this["egress_public_ip"];

    /// <summary>
    /// Private Ingress IP (IPv4).
    /// </summary>
    public TerraformExpression IngressPrivateIp => this["ingress_private_ip"];

    /// <summary>
    /// Public Ingress IP (IPv4).
    /// </summary>
    public TerraformExpression IngressPublicIp => this["ingress_public_ip"];

    /// <summary>
    /// Looker instance URI which can be used to access the Looker Instance UI.
    /// </summary>
    public TerraformExpression LookerUri => this["looker_uri"];

    /// <summary>
    /// The Looker version that the instance is using.
    /// </summary>
    public TerraformExpression LookerVersion => this["looker_version"];

    /// <summary>
    /// The time the instance was updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
