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
        get => GetProperty<List<TerraformProperty<string>>>("allowed_email_domains");
        set => WithProperty("allowed_email_domains", value);
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
        get => GetProperty<TerraformProperty<string>>("domain");
        set => WithProperty("domain", value);
    }

    /// <summary>
    /// Status of the custom domain.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => WithProperty("state", value);
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
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// Full name and version of the CMEK key currently in use to encrypt Looker data.
    /// </summary>
    public TerraformProperty<string>? KmsKeyNameVersion
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name_version");
        set => WithProperty("kms_key_name_version", value);
    }

    /// <summary>
    /// Status of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    public TerraformProperty<string>? KmsKeyState
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_state");
        set => WithProperty("kms_key_state", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("day_of_week");
        set => WithProperty("day_of_week", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client secret for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
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
        get => GetProperty<List<TerraformProperty<string>>>("allowed_vpcs");
        set => WithProperty("allowed_vpcs", value);
    }

    /// <summary>
    /// URI of the Looker service attachment.
    /// </summary>
    public TerraformProperty<string>? LookerServiceAttachmentUri
    {
        get => GetProperty<TerraformProperty<string>>("looker_service_attachment_uri");
        set => WithProperty("looker_service_attachment_uri", value);
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
        get => GetProperty<TerraformProperty<double>>("additional_developer_user_count");
        set => WithProperty("additional_developer_user_count", value);
    }

    /// <summary>
    /// Number of additional Standard Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformProperty<double>? AdditionalStandardUserCount
    {
        get => GetProperty<TerraformProperty<double>>("additional_standard_user_count");
        set => WithProperty("additional_standard_user_count", value);
    }

    /// <summary>
    /// Number of additional Viewer Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformProperty<double>? AdditionalViewerUserCount
    {
        get => GetProperty<TerraformProperty<double>>("additional_viewer_user_count");
        set => WithProperty("additional_viewer_user_count", value);
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
        this.WithOutput("create_time");
        this.WithOutput("egress_public_ip");
        this.WithOutput("ingress_private_ip");
        this.WithOutput("ingress_public_ip");
        this.WithOutput("looker_uri");
        this.WithOutput("looker_version");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// Network name in the consumer project in the format of: projects/{project}/global/networks/{network}
    /// Note that the consumer network may be in a different GCP project than the consumer
    /// project that is hosting the Looker Instance.
    /// </summary>
    public TerraformProperty<string>? ConsumerNetwork
    {
        get => GetProperty<TerraformProperty<string>>("consumer_network");
        set => this.WithProperty("consumer_network", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// If setting deletion_policy = &amp;quot;FORCE&amp;quot;, the Looker instance will be deleted regardless
    /// of its nested resources. If set to &amp;quot;DEFAULT&amp;quot;, Looker instances that still have
    /// nested resources will return an error. Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformProperty<string>? DeletionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("deletion_policy");
        set => this.WithProperty("deletion_policy", value);
    }

    /// <summary>
    /// FIPS 140-2 Encryption enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformProperty<bool>? FipsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("fips_enabled");
        set => this.WithProperty("fips_enabled", value);
    }

    /// <summary>
    /// Gemini enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformProperty<bool>? GeminiEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("gemini_enabled");
        set => this.WithProperty("gemini_enabled", value);
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
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public TerraformProperty<string>? PlatformEdition
    {
        get => GetProperty<TerraformProperty<string>>("platform_edition");
        set => this.WithProperty("platform_edition", value);
    }

    /// <summary>
    /// Whether private IP is enabled on the Looker instance.
    /// </summary>
    public TerraformProperty<bool>? PrivateIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("private_ip_enabled");
        set => this.WithProperty("private_ip_enabled", value);
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
    /// Whether Public Service Connect (PSC) is enabled on the Looker instance
    /// </summary>
    public TerraformProperty<bool>? PscEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("psc_enabled");
        set => this.WithProperty("psc_enabled", value);
    }

    /// <summary>
    /// Whether public IP is enabled on the Looker instance.
    /// </summary>
    public TerraformProperty<bool>? PublicIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_ip_enabled");
        set => this.WithProperty("public_ip_enabled", value);
    }

    /// <summary>
    /// The name of the Looker region of the instance.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Name of a reserved IP address range within the consumer network, to be used for
    /// private service access connection. User may or may not specify this in a request.
    /// </summary>
    public TerraformProperty<string>? ReservedRange
    {
        get => GetProperty<TerraformProperty<string>>("reserved_range");
        set => this.WithProperty("reserved_range", value);
    }

    /// <summary>
    /// Block for admin_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminSettings block(s) allowed")]
    public List<GoogleLookerInstanceAdminSettingsBlock>? AdminSettings
    {
        get => GetProperty<List<GoogleLookerInstanceAdminSettingsBlock>>("admin_settings");
        set => this.WithProperty("admin_settings", value);
    }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public List<GoogleLookerInstanceCustomDomainBlock>? CustomDomain
    {
        get => GetProperty<List<GoogleLookerInstanceCustomDomainBlock>>("custom_domain");
        set => this.WithProperty("custom_domain", value);
    }

    /// <summary>
    /// Block for deny_maintenance_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyMaintenancePeriod block(s) allowed")]
    public List<GoogleLookerInstanceDenyMaintenancePeriodBlock>? DenyMaintenancePeriod
    {
        get => GetProperty<List<GoogleLookerInstanceDenyMaintenancePeriodBlock>>("deny_maintenance_period");
        set => this.WithProperty("deny_maintenance_period", value);
    }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public List<GoogleLookerInstanceEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetProperty<List<GoogleLookerInstanceEncryptionConfigBlock>>("encryption_config");
        set => this.WithProperty("encryption_config", value);
    }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public List<GoogleLookerInstanceMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetProperty<List<GoogleLookerInstanceMaintenanceWindowBlock>>("maintenance_window");
        set => this.WithProperty("maintenance_window", value);
    }

    /// <summary>
    /// Block for oauth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OauthConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public List<GoogleLookerInstanceOauthConfigBlock>? OauthConfig
    {
        get => GetProperty<List<GoogleLookerInstanceOauthConfigBlock>>("oauth_config");
        set => this.WithProperty("oauth_config", value);
    }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public List<GoogleLookerInstancePscConfigBlock>? PscConfig
    {
        get => GetProperty<List<GoogleLookerInstancePscConfigBlock>>("psc_config");
        set => this.WithProperty("psc_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleLookerInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleLookerInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for user_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserMetadata block(s) allowed")]
    public List<GoogleLookerInstanceUserMetadataBlock>? UserMetadata
    {
        get => GetProperty<List<GoogleLookerInstanceUserMetadataBlock>>("user_metadata");
        set => this.WithProperty("user_metadata", value);
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
