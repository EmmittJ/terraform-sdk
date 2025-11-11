using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admin_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceAdminSettingsBlock
{
    /// <summary>
    /// Email domain allowlist for the instance.
    /// 
    /// Define the email domains to which your users can deliver Looker (Google Cloud core) content.
    /// Updating this list will restart the instance. Updating the allowed email domains from terraform
    /// means the value provided will be considered as the entire list and not an amendment to the
    /// existing list of allowed email domains.
    /// </summary>
    [TerraformPropertyName("allowed_email_domains")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedEmailDomains { get; set; }

}

/// <summary>
/// Block type for custom_domain in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceCustomDomainBlock
{
    /// <summary>
    /// Domain name
    /// </summary>
    [TerraformPropertyName("domain")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Domain { get; set; }


}

/// <summary>
/// Block type for deny_maintenance_period in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceDenyMaintenancePeriodBlock
{
}

/// <summary>
/// Block type for encryption_config in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceEncryptionConfigBlock
{
    /// <summary>
    /// Name of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyName { get; set; }



}

/// <summary>
/// Block type for maintenance_window in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceMaintenanceWindowBlock
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
    [TerraformPropertyName("day_of_week")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DayOfWeek { get; set; }

}

/// <summary>
/// Block type for oauth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceOauthConfigBlock
{
    /// <summary>
    /// The client ID for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client secret for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientSecret { get; set; }

}

/// <summary>
/// Block type for psc_config in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstancePscConfigBlock
{
    /// <summary>
    /// List of VPCs that are allowed ingress into the Looker instance.
    /// </summary>
    [TerraformPropertyName("allowed_vpcs")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? AllowedVpcs { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleLookerInstanceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for user_metadata in .
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceUserMetadataBlock
{
    /// <summary>
    /// Number of additional Developer Users to allocate to the Looker Instance.
    /// </summary>
    [TerraformPropertyName("additional_developer_user_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AdditionalDeveloperUserCount { get; set; }

    /// <summary>
    /// Number of additional Standard Users to allocate to the Looker Instance.
    /// </summary>
    [TerraformPropertyName("additional_standard_user_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AdditionalStandardUserCount { get; set; }

    /// <summary>
    /// Number of additional Viewer Users to allocate to the Looker Instance.
    /// </summary>
    [TerraformPropertyName("additional_viewer_user_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? AdditionalViewerUserCount { get; set; }

}

/// <summary>
/// Manages a google_looker_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleLookerInstance : TerraformResource
{
    public GoogleLookerInstance(string name) : base("google_looker_instance", name)
    {
    }

    /// <summary>
    /// Network name in the consumer project in the format of: projects/{project}/global/networks/{network}
    /// Note that the consumer network may be in a different GCP project than the consumer
    /// project that is hosting the Looker Instance.
    /// </summary>
    [TerraformPropertyName("consumer_network")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConsumerNetwork { get; set; }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// If setting deletion_policy = &amp;quot;FORCE&amp;quot;, the Looker instance will be deleted regardless
    /// of its nested resources. If set to &amp;quot;DEFAULT&amp;quot;, Looker instances that still have
    /// nested resources will return an error. Possible values: DEFAULT, FORCE
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeletionPolicy { get; set; }

    /// <summary>
    /// FIPS 140-2 Encryption enablement for Looker (Google Cloud Core).
    /// </summary>
    [TerraformPropertyName("fips_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? FipsEnabled { get; set; }

    /// <summary>
    /// Gemini enablement for Looker (Google Cloud Core).
    /// </summary>
    [TerraformPropertyName("gemini_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? GeminiEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    [TerraformPropertyName("platform_edition")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PlatformEdition { get; set; }

    /// <summary>
    /// Whether private IP is enabled on the Looker instance.
    /// </summary>
    [TerraformPropertyName("private_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PrivateIpEnabled { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// Whether Public Service Connect (PSC) is enabled on the Looker instance
    /// </summary>
    [TerraformPropertyName("psc_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PscEnabled { get; set; }

    /// <summary>
    /// Whether public IP is enabled on the Looker instance.
    /// </summary>
    [TerraformPropertyName("public_ip_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicIpEnabled { get; set; }

    /// <summary>
    /// The name of the Looker region of the instance.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Name of a reserved IP address range within the consumer network, to be used for
    /// private service access connection. User may or may not specify this in a request.
    /// </summary>
    [TerraformPropertyName("reserved_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReservedRange { get; set; }

    /// <summary>
    /// Block for admin_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminSettings block(s) allowed")]
    [TerraformPropertyName("admin_settings")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceAdminSettingsBlock>>? AdminSettings { get; set; }

    /// <summary>
    /// Block for custom_domain.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    [TerraformPropertyName("custom_domain")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceCustomDomainBlock>>? CustomDomain { get; set; }

    /// <summary>
    /// Block for deny_maintenance_period.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyMaintenancePeriod block(s) allowed")]
    [TerraformPropertyName("deny_maintenance_period")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceDenyMaintenancePeriodBlock>>? DenyMaintenancePeriod { get; set; }

    /// <summary>
    /// Block for encryption_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    [TerraformPropertyName("encryption_config")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceEncryptionConfigBlock>>? EncryptionConfig { get; set; }

    /// <summary>
    /// Block for maintenance_window.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    [TerraformPropertyName("maintenance_window")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceMaintenanceWindowBlock>>? MaintenanceWindow { get; set; }

    /// <summary>
    /// Block for oauth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OauthConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    [TerraformPropertyName("oauth_config")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceOauthConfigBlock>>? OauthConfig { get; set; }

    /// <summary>
    /// Block for psc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    [TerraformPropertyName("psc_config")]
    public TerraformList<TerraformBlock<GoogleLookerInstancePscConfigBlock>>? PscConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleLookerInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for user_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserMetadata block(s) allowed")]
    [TerraformPropertyName("user_metadata")]
    public TerraformList<TerraformBlock<GoogleLookerInstanceUserMetadataBlock>>? UserMetadata { get; set; }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Public Egress IP (IPv4).
    /// </summary>
    [TerraformPropertyName("egress_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EgressPublicIp => new TerraformReference(this, "egress_public_ip");

    /// <summary>
    /// Private Ingress IP (IPv4).
    /// </summary>
    [TerraformPropertyName("ingress_private_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IngressPrivateIp => new TerraformReference(this, "ingress_private_ip");

    /// <summary>
    /// Public Ingress IP (IPv4).
    /// </summary>
    [TerraformPropertyName("ingress_public_ip")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> IngressPublicIp => new TerraformReference(this, "ingress_public_ip");

    /// <summary>
    /// Looker instance URI which can be used to access the Looker Instance UI.
    /// </summary>
    [TerraformPropertyName("looker_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LookerUri => new TerraformReference(this, "looker_uri");

    /// <summary>
    /// The Looker version that the instance is using.
    /// </summary>
    [TerraformPropertyName("looker_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LookerVersion => new TerraformReference(this, "looker_version");

    /// <summary>
    /// The time the instance was updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
