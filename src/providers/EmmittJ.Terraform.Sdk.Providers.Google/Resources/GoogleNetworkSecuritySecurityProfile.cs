using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for custom_intercept_profile in GoogleNetworkSecuritySecurityProfile.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_intercept_profile";

    /// <summary>
    /// The Intercept Endpoint Group to which matching traffic should be intercepted.
    /// Format: projects/{project_id}/locations/global/interceptEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InterceptEndpointGroup is required")]
    public required TerraformValue<string> InterceptEndpointGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("intercept_endpoint_group");
        set => SetArgument("intercept_endpoint_group", value);
    }

}


/// <summary>
/// Block type for custom_mirroring_profile in GoogleNetworkSecuritySecurityProfile.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_mirroring_profile";

    /// <summary>
    /// The Mirroring Endpoint Group to which matching traffic should be mirrored.
    /// Format: projects/{project_id}/locations/global/mirroringEndpointGroups/{endpoint_group_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MirroringEndpointGroup is required")]
    public required TerraformValue<string> MirroringEndpointGroup
    {
        get => GetRequiredArgument<TerraformValue<string>>("mirroring_endpoint_group");
        set => SetArgument("mirroring_endpoint_group", value);
    }

}


/// <summary>
/// Block type for threat_prevention_profile in GoogleNetworkSecuritySecurityProfile.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_prevention_profile";

    /// <summary>
    /// AntivirusOverrides block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockAntivirusOverridesBlock>? AntivirusOverrides
    {
        get => GetArgument<TerraformSet<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockAntivirusOverridesBlock>>("antivirus_overrides");
        set => SetArgument("antivirus_overrides", value);
    }

    /// <summary>
    /// SeverityOverrides block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockSeverityOverridesBlock>? SeverityOverrides
    {
        get => GetArgument<TerraformSet<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockSeverityOverridesBlock>>("severity_overrides");
        set => SetArgument("severity_overrides", value);
    }

    /// <summary>
    /// ThreatOverrides block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockThreatOverridesBlock>? ThreatOverrides
    {
        get => GetArgument<TerraformSet<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockThreatOverridesBlock>>("threat_overrides");
        set => SetArgument("threat_overrides", value);
    }

}

/// <summary>
/// Block type for antivirus_overrides in GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock.
/// Nesting mode: set
/// </summary>
public class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockAntivirusOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "antivirus_overrides";

    /// <summary>
    /// Threat action override. For some threat types, only a subset of actions applies. Possible values: [&amp;quot;ALERT&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DEFAULT_ACTION&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Required protocol to match. Possible values: [&amp;quot;SMTP&amp;quot;, &amp;quot;SMB&amp;quot;, &amp;quot;POP3&amp;quot;, &amp;quot;IMAP&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;HTTP&amp;quot;, &amp;quot;FTP&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

}

/// <summary>
/// Block type for severity_overrides in GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock.
/// Nesting mode: set
/// </summary>
public class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockSeverityOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "severity_overrides";

    /// <summary>
    /// Threat action override. Possible values: [&amp;quot;ALERT&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DEFAULT_ACTION&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Severity level to match. Possible values: [&amp;quot;CRITICAL&amp;quot;, &amp;quot;HIGH&amp;quot;, &amp;quot;INFORMATIONAL&amp;quot;, &amp;quot;LOW&amp;quot;, &amp;quot;MEDIUM&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Severity is required")]
    public required TerraformValue<string> Severity
    {
        get => GetRequiredArgument<TerraformValue<string>>("severity");
        set => SetArgument("severity", value);
    }

}

/// <summary>
/// Block type for threat_overrides in GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock.
/// Nesting mode: set
/// </summary>
public class GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlockThreatOverridesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "threat_overrides";

    /// <summary>
    /// Threat action. Possible values: [&amp;quot;ALERT&amp;quot;, &amp;quot;ALLOW&amp;quot;, &amp;quot;DEFAULT_ACTION&amp;quot;, &amp;quot;DENY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Vendor-specific ID of a threat to override.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreatId is required")]
    public required TerraformValue<string> ThreatId
    {
        get => GetRequiredArgument<TerraformValue<string>>("threat_id");
        set => SetArgument("threat_id", value);
    }

    /// <summary>
    /// Type of threat.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}


/// <summary>
/// Block type for timeouts in GoogleNetworkSecuritySecurityProfile.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecuritySecurityProfileTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_security_profile Terraform resource.
/// Manages a google_network_security_security_profile resource.
/// </summary>
public partial class GoogleNetworkSecuritySecurityProfile(string name) : TerraformResource("google_network_security_security_profile", name)
{
    /// <summary>
    /// An optional description of the security profile. The Max length is 512 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A map of key/value label pairs to assign to the resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the security profile.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the security profile resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name of the parent this security profile belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The type of security profile. Possible values: [&amp;quot;THREAT_PREVENTION&amp;quot;, &amp;quot;URL_FILTERING&amp;quot;, &amp;quot;CUSTOM_MIRRORING&amp;quot;, &amp;quot;CUSTOM_INTERCEPT&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Time the security profile was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an up-to-date
    /// value before proceeding.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Server-defined URL of this resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => AsReference("self_link");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Time the security profile was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// CustomInterceptProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomInterceptProfile block(s) allowed")]
    public TerraformList<GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock>? CustomInterceptProfile
    {
        get => GetArgument<TerraformList<GoogleNetworkSecuritySecurityProfileCustomInterceptProfileBlock>>("custom_intercept_profile");
        set => SetArgument("custom_intercept_profile", value);
    }

    /// <summary>
    /// CustomMirroringProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomMirroringProfile block(s) allowed")]
    public TerraformList<GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock>? CustomMirroringProfile
    {
        get => GetArgument<TerraformList<GoogleNetworkSecuritySecurityProfileCustomMirroringProfileBlock>>("custom_mirroring_profile");
        set => SetArgument("custom_mirroring_profile", value);
    }

    /// <summary>
    /// ThreatPreventionProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreatPreventionProfile block(s) allowed")]
    public TerraformList<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock>? ThreatPreventionProfile
    {
        get => GetArgument<TerraformList<GoogleNetworkSecuritySecurityProfileThreatPreventionProfileBlock>>("threat_prevention_profile");
        set => SetArgument("threat_prevention_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecuritySecurityProfileTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecuritySecurityProfileTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
