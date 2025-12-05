using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for device_policy in GoogleAccessContextManagerAccessLevelCondition.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "device_policy";

    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels. Possible values: [&amp;quot;MANAGEMENT_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;BASIC&amp;quot;, &amp;quot;COMPLETE&amp;quot;]
    /// </summary>
    public TerraformList<string>? AllowedDeviceManagementLevels
    {
        get => GetArgument<TerraformList<string>>("allowed_device_management_levels");
        set => SetArgument("allowed_device_management_levels", value);
    }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses. Possible values: [&amp;quot;ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;ENCRYPTION_UNSUPPORTED&amp;quot;, &amp;quot;UNENCRYPTED&amp;quot;, &amp;quot;ENCRYPTED&amp;quot;]
    /// </summary>
    public TerraformList<string>? AllowedEncryptionStatuses
    {
        get => GetArgument<TerraformList<string>>("allowed_encryption_statuses");
        set => SetArgument("allowed_encryption_statuses", value);
    }

    /// <summary>
    /// Whether the device needs to be approved by the customer admin.
    /// </summary>
    public TerraformValue<bool>? RequireAdminApproval
    {
        get => GetArgument<TerraformValue<bool>>("require_admin_approval");
        set => SetArgument("require_admin_approval", value);
    }

    /// <summary>
    /// Whether the device needs to be corp owned.
    /// </summary>
    public TerraformValue<bool>? RequireCorpOwned
    {
        get => GetArgument<TerraformValue<bool>>("require_corp_owned");
        set => SetArgument("require_corp_owned", value);
    }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? RequireScreenLock
    {
        get => GetArgument<TerraformValue<bool>>("require_screen_lock");
        set => SetArgument("require_screen_lock", value);
    }

    /// <summary>
    /// OsConstraints block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlockOsConstraintsBlock>? OsConstraints
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlockOsConstraintsBlock>>("os_constraints");
        set => SetArgument("os_constraints", value);
    }

}

/// <summary>
/// Block type for os_constraints in GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlockOsConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "os_constraints";

    /// <summary>
    /// The minimum allowed OS version. If not set, any version
    /// of this OS satisfies the constraint.
    /// Format: &amp;quot;major.minor.patch&amp;quot; such as &amp;quot;10.5.301&amp;quot;, &amp;quot;9.2.1&amp;quot;.
    /// </summary>
    public TerraformValue<string>? MinimumVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_version");
        set => SetArgument("minimum_version", value);
    }

    /// <summary>
    /// The operating system type of the device. Possible values: [&amp;quot;OS_UNSPECIFIED&amp;quot;, &amp;quot;DESKTOP_MAC&amp;quot;, &amp;quot;DESKTOP_WINDOWS&amp;quot;, &amp;quot;DESKTOP_LINUX&amp;quot;, &amp;quot;DESKTOP_CHROME_OS&amp;quot;, &amp;quot;ANDROID&amp;quot;, &amp;quot;IOS&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OsType is required")]
    public required TerraformValue<string> OsType
    {
        get => GetRequiredArgument<TerraformValue<string>>("os_type");
        set => SetArgument("os_type", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerAccessLevelCondition.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Block type for vpc_network_sources in GoogleAccessContextManagerAccessLevelCondition.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_network_sources";

    /// <summary>
    /// VpcSubnetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcSubnetwork block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlockVpcSubnetworkBlock>? VpcSubnetwork
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlockVpcSubnetworkBlock>>("vpc_subnetwork");
        set => SetArgument("vpc_subnetwork", value);
    }

}

/// <summary>
/// Block type for vpc_subnetwork in GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlockVpcSubnetworkBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_subnetwork";

    /// <summary>
    /// Required. Network name to be allowed by this Access Level. Networks of foreign organizations requires &#39;compute.network.get&#39; permission to be granted to caller.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Network is required")]
    public required TerraformValue<string> Network
    {
        get => GetRequiredArgument<TerraformValue<string>>("network");
        set => SetArgument("network", value);
    }

    /// <summary>
    /// CIDR block IP subnetwork specification. Must be IPv4.
    /// </summary>
    public TerraformList<string>? VpcIpSubnetworks
    {
        get => GetArgument<TerraformList<string>>("vpc_ip_subnetworks");
        set => SetArgument("vpc_ip_subnetworks", value);
    }

}


/// <summary>
/// Represents a google_access_context_manager_access_level_condition Terraform resource.
/// Manages a google_access_context_manager_access_level_condition resource.
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelCondition(string name) : TerraformResource("google_access_context_manager_access_level_condition", name)
{
    /// <summary>
    /// The name of the Access Level to add this condition to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    public required TerraformValue<string> AccessLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_level");
        set => SetArgument("access_level", value);
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
    /// A list of CIDR block IP subnetwork specification. May be IPv4
    /// or IPv6.
    /// Note that for a CIDR IP address block, the specified IP address
    /// portion must be properly truncated (i.e. all the host bits must
    /// be zero) or the input is considered malformed. For example,
    /// &amp;quot;192.0.2.0/24&amp;quot; is accepted but &amp;quot;192.0.2.1/24&amp;quot; is not. Similarly,
    /// for IPv6, &amp;quot;2001:db8::/32&amp;quot; is accepted whereas &amp;quot;2001:db8::1/32&amp;quot;
    /// is not. The originating IP of a request must be in one of the
    /// listed subnets in order for this Condition to be true.
    /// If empty, all IP addresses are allowed.
    /// </summary>
    public TerraformList<string>? IpSubnetworks
    {
        get => GetArgument<TerraformList<string>>("ip_subnetworks");
        set => SetArgument("ip_subnetworks", value);
    }

    /// <summary>
    /// An allowed list of members (users, service accounts).
    /// Using groups is not supported yet.
    /// 
    /// The signed-in user originating the request must be a part of one
    /// of the provided members. If not specified, a request may come
    /// from any user (logged in/not logged in, not present in any
    /// groups, etc.).
    /// Formats: &#39;user:{emailid}&#39;, &#39;serviceAccount:{emailid}&#39;
    /// </summary>
    public TerraformList<string>? Members
    {
        get => GetArgument<TerraformList<string>>("members");
        set => SetArgument("members", value);
    }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    public TerraformValue<bool>? Negate
    {
        get => GetArgument<TerraformValue<bool>>("negate");
        set => SetArgument("negate", value);
    }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => GetArgument<TerraformList<string>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    public TerraformList<string>? RequiredAccessLevels
    {
        get => GetArgument<TerraformList<string>>("required_access_levels");
        set => SetArgument("required_access_levels", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformValue<string> AccessPolicyId
        => CreateReference("access_policy_id");

    /// <summary>
    /// DevicePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DevicePolicy block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock>? DevicePolicy
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock>>("device_policy");
        set => SetArgument("device_policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VpcNetworkSources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock>? VpcNetworkSources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock>>("vpc_network_sources");
        set => SetArgument("vpc_network_sources", value);
    }

}
