using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for admin_settings in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceAdminSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_settings";

    /// <summary>
    /// Email domain allowlist for the instance.
    /// 
    /// Define the email domains to which your users can deliver Looker (Google Cloud core) content.
    /// Updating this list will restart the instance. Updating the allowed email domains from terraform
    /// means the value provided will be considered as the entire list and not an amendment to the
    /// existing list of allowed email domains.
    /// </summary>
    public TerraformList<string>? AllowedEmailDomains
    {
        get => GetArgument<TerraformList<string>>("allowed_email_domains");
        set => SetArgument("allowed_email_domains", value);
    }

}


/// <summary>
/// Block type for custom_domain in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceCustomDomainBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_domain";

    /// <summary>
    /// Domain name
    /// </summary>
    public TerraformValue<string>? Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// Status of the custom domain.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

}


/// <summary>
/// Block type for deny_maintenance_period in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceDenyMaintenancePeriodBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "deny_maintenance_period";

    /// <summary>
    /// EndDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EndDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EndDate block(s) allowed")]
    public required TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlockEndDateBlock> EndDate
    {
        get => GetRequiredArgument<TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlockEndDateBlock>>("end_date");
        set => SetArgument("end_date", value);
    }

    /// <summary>
    /// StartDate block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartDate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartDate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartDate block(s) allowed")]
    public required TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlockStartDateBlock> StartDate
    {
        get => GetRequiredArgument<TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlockStartDateBlock>>("start_date");
        set => SetArgument("start_date", value);
    }

    /// <summary>
    /// Time block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Time is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Time block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Time block(s) allowed")]
    public required TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlockTimeBlock> Time
    {
        get => GetRequiredArgument<TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlockTimeBlock>>("time");
        set => SetArgument("time", value);
    }

}

/// <summary>
/// Block type for end_date in GoogleLookerInstanceDenyMaintenancePeriodBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceDenyMaintenancePeriodBlockEndDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "end_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0
    /// to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a
    /// month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without
    /// a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for start_date in GoogleLookerInstanceDenyMaintenancePeriodBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceDenyMaintenancePeriodBlockStartDateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_date";

    /// <summary>
    /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0
    /// to specify a year by itself or a year and month where the day isn&#39;t significant.
    /// </summary>
    public TerraformValue<double>? Day
    {
        get => GetArgument<TerraformValue<double>>("day");
        set => SetArgument("day", value);
    }

    /// <summary>
    /// Month of a year. Must be from 1 to 12, or 0 to specify a year without a
    /// month and day.
    /// </summary>
    public TerraformValue<double>? Month
    {
        get => GetArgument<TerraformValue<double>>("month");
        set => SetArgument("month", value);
    }

    /// <summary>
    /// Year of the date. Must be from 1 to 9999, or 0 to specify a date without
    /// a year.
    /// </summary>
    public TerraformValue<double>? Year
    {
        get => GetArgument<TerraformValue<double>>("year");
        set => SetArgument("year", value);
    }

}

/// <summary>
/// Block type for time in GoogleLookerInstanceDenyMaintenancePeriodBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceDenyMaintenancePeriodBlockTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "time";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for encryption_config in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceEncryptionConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_config";

    /// <summary>
    /// Name of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    public TerraformValue<string>? KmsKeyName
    {
        get => GetArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

    /// <summary>
    /// Full name and version of the CMEK key currently in use to encrypt Looker data.
    /// </summary>
    public TerraformValue<string> KmsKeyNameVersion
        => CreateReference("kms_key_name_version");

    /// <summary>
    /// Status of the customer managed encryption key (CMEK) in KMS.
    /// </summary>
    public TerraformValue<string> KmsKeyState
        => CreateReference("kms_key_state");

}


/// <summary>
/// Block type for maintenance_window in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceMaintenanceWindowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "maintenance_window";

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
    public required TerraformValue<string> DayOfWeek
    {
        get => GetRequiredArgument<TerraformValue<string>>("day_of_week");
        set => SetArgument("day_of_week", value);
    }

    /// <summary>
    /// StartTime block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartTime is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StartTime block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StartTime block(s) allowed")]
    public required TerraformList<GoogleLookerInstanceMaintenanceWindowBlockStartTimeBlock> StartTime
    {
        get => GetRequiredArgument<TerraformList<GoogleLookerInstanceMaintenanceWindowBlockStartTimeBlock>>("start_time");
        set => SetArgument("start_time", value);
    }

}

/// <summary>
/// Block type for start_time in GoogleLookerInstanceMaintenanceWindowBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceMaintenanceWindowBlockStartTimeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "start_time";

    /// <summary>
    /// Hours of day in 24 hour format. Should be from 0 to 23.
    /// </summary>
    public TerraformValue<double>? Hours
    {
        get => GetArgument<TerraformValue<double>>("hours");
        set => SetArgument("hours", value);
    }

    /// <summary>
    /// Minutes of hour of day. Must be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Minutes
    {
        get => GetArgument<TerraformValue<double>>("minutes");
        set => SetArgument("minutes", value);
    }

    /// <summary>
    /// Fractions of seconds in nanoseconds. Must be from 0 to 999,999,999.
    /// </summary>
    public TerraformValue<double>? Nanos
    {
        get => GetArgument<TerraformValue<double>>("nanos");
        set => SetArgument("nanos", value);
    }

    /// <summary>
    /// Seconds of minutes of the time. Must normally be from 0 to 59.
    /// </summary>
    public TerraformValue<double>? Seconds
    {
        get => GetArgument<TerraformValue<double>>("seconds");
        set => SetArgument("seconds", value);
    }

}


/// <summary>
/// Block type for oauth_config in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceOauthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth_config";

    /// <summary>
    /// The client ID for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client secret for the Oauth config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

}


/// <summary>
/// Block type for psc_config in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstancePscConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "psc_config";

    /// <summary>
    /// List of VPCs that are allowed ingress into the Looker instance.
    /// </summary>
    public TerraformList<string>? AllowedVpcs
    {
        get => GetArgument<TerraformList<string>>("allowed_vpcs");
        set => SetArgument("allowed_vpcs", value);
    }

    /// <summary>
    /// URI of the Looker service attachment.
    /// </summary>
    public TerraformValue<string> LookerServiceAttachmentUri
        => CreateReference("looker_service_attachment_uri");

    /// <summary>
    /// ServiceAttachments block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleLookerInstancePscConfigBlockServiceAttachmentsBlock>? ServiceAttachments
    {
        get => GetArgument<TerraformList<GoogleLookerInstancePscConfigBlockServiceAttachmentsBlock>>("service_attachments");
        set => SetArgument("service_attachments", value);
    }

}

/// <summary>
/// Block type for service_attachments in GoogleLookerInstancePscConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstancePscConfigBlockServiceAttachmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_attachments";

    /// <summary>
    /// Status of the service attachment connection.
    /// </summary>
    public TerraformValue<string> ConnectionStatus
        => CreateReference("connection_status");

    /// <summary>
    /// Fully qualified domain name that will be used in the private DNS record created for the service attachment.
    /// </summary>
    public TerraformValue<string>? LocalFqdn
    {
        get => GetArgument<TerraformValue<string>>("local_fqdn");
        set => SetArgument("local_fqdn", value);
    }

    /// <summary>
    /// URI of the service attachment to connect to.
    /// </summary>
    public TerraformValue<string>? TargetServiceAttachmentUri
    {
        get => GetArgument<TerraformValue<string>>("target_service_attachment_uri");
        set => SetArgument("target_service_attachment_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleLookerInstance.
/// Nesting mode: single
/// </summary>
public class GoogleLookerInstanceTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for user_metadata in GoogleLookerInstance.
/// Nesting mode: list
/// </summary>
public class GoogleLookerInstanceUserMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_metadata";

    /// <summary>
    /// Number of additional Developer Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformValue<double>? AdditionalDeveloperUserCount
    {
        get => GetArgument<TerraformValue<double>>("additional_developer_user_count");
        set => SetArgument("additional_developer_user_count", value);
    }

    /// <summary>
    /// Number of additional Standard Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformValue<double>? AdditionalStandardUserCount
    {
        get => GetArgument<TerraformValue<double>>("additional_standard_user_count");
        set => SetArgument("additional_standard_user_count", value);
    }

    /// <summary>
    /// Number of additional Viewer Users to allocate to the Looker Instance.
    /// </summary>
    public TerraformValue<double>? AdditionalViewerUserCount
    {
        get => GetArgument<TerraformValue<double>>("additional_viewer_user_count");
        set => SetArgument("additional_viewer_user_count", value);
    }

}


/// <summary>
/// Represents a google_looker_instance Terraform resource.
/// Manages a google_looker_instance resource.
/// </summary>
public partial class GoogleLookerInstance(string name) : TerraformResource("google_looker_instance", name)
{
    /// <summary>
    /// Network name in the consumer project in the format of: projects/{project}/global/networks/{network}
    /// Note that the consumer network may be in a different GCP project than the consumer
    /// project that is hosting the Looker Instance.
    /// </summary>
    public TerraformValue<string>? ConsumerNetwork
    {
        get => GetArgument<TerraformValue<string>>("consumer_network");
        set => SetArgument("consumer_network", value);
    }

    /// <summary>
    /// Policy to determine if the cluster should be deleted forcefully.
    /// If setting deletion_policy = &amp;quot;FORCE&amp;quot;, the Looker instance will be deleted regardless
    /// of its nested resources. If set to &amp;quot;DEFAULT&amp;quot;, Looker instances that still have
    /// nested resources will return an error. Possible values: DEFAULT, FORCE
    /// </summary>
    public TerraformValue<string>? DeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("deletion_policy");
        set => SetArgument("deletion_policy", value);
    }

    /// <summary>
    /// FIPS 140-2 Encryption enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformValue<bool>? FipsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("fips_enabled");
        set => SetArgument("fips_enabled", value);
    }

    /// <summary>
    /// Gemini enablement for Looker (Google Cloud Core).
    /// </summary>
    public TerraformValue<bool>? GeminiEnabled
    {
        get => GetArgument<TerraformValue<bool>>("gemini_enabled");
        set => SetArgument("gemini_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the instance or a fully qualified identifier for the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    public TerraformValue<string>? PlatformEdition
    {
        get => GetArgument<TerraformValue<string>>("platform_edition");
        set => SetArgument("platform_edition", value);
    }

    /// <summary>
    /// Whether private IP is enabled on the Looker instance.
    /// </summary>
    public TerraformValue<bool>? PrivateIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("private_ip_enabled");
        set => SetArgument("private_ip_enabled", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Whether Public Service Connect (PSC) is enabled on the Looker instance
    /// </summary>
    public TerraformValue<bool>? PscEnabled
    {
        get => GetArgument<TerraformValue<bool>>("psc_enabled");
        set => SetArgument("psc_enabled", value);
    }

    /// <summary>
    /// Whether public IP is enabled on the Looker instance.
    /// </summary>
    public TerraformValue<bool>? PublicIpEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_ip_enabled");
        set => SetArgument("public_ip_enabled", value);
    }

    /// <summary>
    /// The name of the Looker region of the instance.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Name of a reserved IP address range within the consumer network, to be used for
    /// private service access connection. User may or may not specify this in a request.
    /// </summary>
    public TerraformValue<string>? ReservedRange
    {
        get => GetArgument<TerraformValue<string>>("reserved_range");
        set => SetArgument("reserved_range", value);
    }

    /// <summary>
    /// The time the instance was created in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Public Egress IP (IPv4).
    /// </summary>
    public TerraformValue<string> EgressPublicIp
        => CreateReference("egress_public_ip");

    /// <summary>
    /// Private Ingress IP (IPv4).
    /// </summary>
    public TerraformValue<string> IngressPrivateIp
        => CreateReference("ingress_private_ip");

    /// <summary>
    /// Public Ingress IP (IPv4).
    /// </summary>
    public TerraformValue<string> IngressPublicIp
        => CreateReference("ingress_public_ip");

    /// <summary>
    /// Looker instance URI which can be used to access the Looker Instance UI.
    /// </summary>
    public TerraformValue<string> LookerUri
        => CreateReference("looker_uri");

    /// <summary>
    /// The Looker version that the instance is using.
    /// </summary>
    public TerraformValue<string> LookerVersion
        => CreateReference("looker_version");

    /// <summary>
    /// The time the instance was updated in RFC3339 UTC &amp;quot;Zulu&amp;quot; format,
    /// accurate to nanoseconds.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// AdminSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminSettings block(s) allowed")]
    public TerraformList<GoogleLookerInstanceAdminSettingsBlock>? AdminSettings
    {
        get => GetArgument<TerraformList<GoogleLookerInstanceAdminSettingsBlock>>("admin_settings");
        set => SetArgument("admin_settings", value);
    }

    /// <summary>
    /// CustomDomain block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDomain block(s) allowed")]
    public TerraformList<GoogleLookerInstanceCustomDomainBlock>? CustomDomain
    {
        get => GetArgument<TerraformList<GoogleLookerInstanceCustomDomainBlock>>("custom_domain");
        set => SetArgument("custom_domain", value);
    }

    /// <summary>
    /// DenyMaintenancePeriod block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DenyMaintenancePeriod block(s) allowed")]
    public TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlock>? DenyMaintenancePeriod
    {
        get => GetArgument<TerraformList<GoogleLookerInstanceDenyMaintenancePeriodBlock>>("deny_maintenance_period");
        set => SetArgument("deny_maintenance_period", value);
    }

    /// <summary>
    /// EncryptionConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfig block(s) allowed")]
    public TerraformList<GoogleLookerInstanceEncryptionConfigBlock>? EncryptionConfig
    {
        get => GetArgument<TerraformList<GoogleLookerInstanceEncryptionConfigBlock>>("encryption_config");
        set => SetArgument("encryption_config", value);
    }

    /// <summary>
    /// MaintenanceWindow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MaintenanceWindow block(s) allowed")]
    public TerraformList<GoogleLookerInstanceMaintenanceWindowBlock>? MaintenanceWindow
    {
        get => GetArgument<TerraformList<GoogleLookerInstanceMaintenanceWindowBlock>>("maintenance_window");
        set => SetArgument("maintenance_window", value);
    }

    /// <summary>
    /// OauthConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OauthConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 OauthConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OauthConfig block(s) allowed")]
    public required TerraformList<GoogleLookerInstanceOauthConfigBlock> OauthConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleLookerInstanceOauthConfigBlock>>("oauth_config");
        set => SetArgument("oauth_config", value);
    }

    /// <summary>
    /// PscConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PscConfig block(s) allowed")]
    public TerraformList<GoogleLookerInstancePscConfigBlock>? PscConfig
    {
        get => GetArgument<TerraformList<GoogleLookerInstancePscConfigBlock>>("psc_config");
        set => SetArgument("psc_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleLookerInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleLookerInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserMetadata block(s) allowed")]
    public TerraformList<GoogleLookerInstanceUserMetadataBlock>? UserMetadata
    {
        get => GetArgument<TerraformList<GoogleLookerInstanceUserMetadataBlock>>("user_metadata");
        set => SetArgument("user_metadata", value);
    }

}
