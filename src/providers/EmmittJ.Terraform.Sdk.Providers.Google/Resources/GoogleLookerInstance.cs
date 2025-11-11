using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admin_settings in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceAdminSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// Email domain allowlist for the instance.
    /// 
    /// Define the email domains to which your users can deliver Looker (Google Cloud core) content.
    /// Updating this list will restart the instance. Updating the allowed email domains from terraform
    /// means the value provided will be considered as the entire list and not an amendment to the
    /// existing list of allowed email domains.
    /// </summary>
    [TerraformProperty("allowed_email_domains")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedEmailDomains { get; set; }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceCustomDomainBlock : TerraformBlockBase
{
    /// <summary>
    /// Domain name
    /// </summary>
    [TerraformProperty("domain")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Domain { get; set; }


}

/// <summary>
/// Block type for deny_maintenance_period in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceDenyMaintenancePeriodBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceEncryptionConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Name of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyName { get; set; }



}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceMaintenanceWindowBlock : TerraformBlockBase
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
    [TerraformProperty("day_of_week")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DayOfWeek { get; set; }

}

/// <summary>
/// Block type for oauth_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceOauthConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The client ID for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client secret for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformProperty("client_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSecret { get; set; }

}

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstancePscConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// List of VPCs that are allowed ingress into the Looker instance.
    /// </summary>
    [TerraformProperty("allowed_vpcs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedVpcs { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleLookerInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_metadata in .
/// Nesting mode: list
/// </summary>
public partial class GoogleLookerInstanceUserMetadataBlock : TerraformBlockBase
{
    /// <summary>
    /// Number of additional Developer Users to allocate to the Looker Instance.
    /// </summary>
    [TerraformProperty("additional_developer_user_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdditionalDeveloperUserCount { get; set; }

    /// <summary>
    /// Number of additional Standard Users to allocate to the Looker Instance.
    /// </summary>
    [TerraformProperty("additional_standard_user_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdditionalStandardUserCount { get; set; }

    /// <summary>
    /// Number of additional Viewer Users to allocate to the Looker Instance.
    /// </summary>
    [TerraformProperty("additional_viewer_user_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdditionalViewerUserCount { get; set; }

}

/// <summary>
/// Manages a google_looker_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleLookerInstance : TerraformResource
{
    public GoogleLookerInstance(string name) : base("google_looker_instance", name)
    {
    }

    /// <summary>
    /// Network name in the consumer project in the format of: projects/{project}/global/networks/{network}
    /// Note that the consumer network may be in a different GCP project than the consumer
    /// project that is hosting the Looker Instance.
    /// </summary>
    [TerraformProperty("consumer_network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConsumerNetwork { get; set; }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// If setting deletion_policy = &amp;quot;FORCE&amp;quot;, the Looker instance will be deleted regardless
    /// of its nested resources. If set to &amp;quot;DEFAULT&amp;quot;, Looker instances that still have
    /// nested resources will return an error. Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformProperty("deletion_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// FIPS 140-2 Encryption enablement for Looker (Google Cloud Core).
    /// </summary>
    [TerraformProperty("fips_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// Gemini enablement for Looker (Google Cloud Core).
    /// </summary>
    [TerraformProperty("gemini_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GeminiEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

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
    [TerraformProperty("platform_edition")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PlatformEdition { get; set; }

    /// <summary>
    /// Whether private IP is enabled on the Looker instance.
    /// </summary>
    [TerraformProperty("private_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PrivateIpEnabled { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Whether Public Service Connect (PSC) is enabled on the Looker instance
    /// </summary>
    [TerraformProperty("psc_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PscEnabled { get; set; }

    /// <summary>
    /// Whether public IP is enabled on the Looker instance.
    /// </summary>
    [TerraformProperty("public_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicIpEnabled { get; set; }

    /// <summary>
    /// The name of the Looker region of the instance.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Name of a reserved IP address range within the consumer network, to be used for
    /// private service access connection. User may or may not specify this in a request.
    /// </summary>
    [TerraformProperty("reserved_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReservedRange { get; set; }

    /// <summary>
    /// Block for admin_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminSettings block(s) allowed")]
    [TerraformProperty("admin_settings")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceAdminSettingsBlock>>? AdminSettings { get; set; }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    [TerraformProperty("custom_domain")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceCustomDomainBlock>>? CustomDomain { get; set; }

    /// <summary>
    /// Block for deny_maintenance_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyMaintenancePeriod block(s) allowed")]
    [TerraformProperty("deny_maintenance_period")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceDenyMaintenancePeriodBlock>>? DenyMaintenancePeriod { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformProperty("encryption_config")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformProperty("maintenance_window")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for oauth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OauthConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    [TerraformProperty("oauth_config")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceOauthConfigBlock>>? OauthConfig { get; set; }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    [TerraformProperty("psc_config")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstancePscConfigBlock>>? PscConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleLookerInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserMetadata block(s) allowed")]
    [TerraformProperty("user_metadata")]
    public partial TerraformList<TerraformBlock<GoogleLookerInstanceUserMetadataBlock>>? UserMetadata { get; set; }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Public Egress IP (IPv4).
    /// </summary>
    [TerraformProperty("egress_public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EgressPublicIp { get; }

    /// <summary>
    /// Private Ingress IP (IPv4).
    /// </summary>
    [TerraformProperty("ingress_private_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IngressPrivateIp { get; }

    /// <summary>
    /// Public Ingress IP (IPv4).
    /// </summary>
    [TerraformProperty("ingress_public_ip")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IngressPublicIp { get; }

    /// <summary>
    /// Looker instance URI which can be used to access the Looker Instance UI.
    /// </summary>
    [TerraformProperty("looker_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LookerUri { get; }

    /// <summary>
    /// The Looker version that the instance is using.
    /// </summary>
    [TerraformProperty("looker_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LookerVersion { get; }

    /// <summary>
    /// The time the instance was updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
