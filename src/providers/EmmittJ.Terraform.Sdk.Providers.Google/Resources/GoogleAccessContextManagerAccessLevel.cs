using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic in GoogleAccessContextManagerAccessLevel.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic";

    /// <summary>
    /// How the conditions list should be combined to determine if a request
    /// is granted this AccessLevel. If AND is used, each Condition in
    /// conditions must be satisfied for the AccessLevel to be applied. If
    /// OR is used, at least one Condition in conditions must be satisfied
    /// for the AccessLevel to be applied. Default value: &amp;quot;AND&amp;quot; Possible values: [&amp;quot;AND&amp;quot;, &amp;quot;OR&amp;quot;]
    /// </summary>
    public TerraformValue<string>? CombiningFunction
    {
        get => GetArgument<TerraformValue<string>>("combining_function");
        set => SetArgument("combining_function", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    public required TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlock> Conditions
    {
        get => GetRequiredArgument<TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleAccessContextManagerAccessLevelBasicBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

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
    /// DevicePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DevicePolicy block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlock>? DevicePolicy
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlock>>("device_policy");
        set => SetArgument("device_policy", value);
    }

    /// <summary>
    /// VpcNetworkSources block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlock>? VpcNetworkSources
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlock>>("vpc_network_sources");
        set => SetArgument("vpc_network_sources", value);
    }

}

/// <summary>
/// Block type for device_policy in GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlock : TerraformBlock
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
    public TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlockOsConstraintsBlock>? OsConstraints
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlockOsConstraintsBlock>>("os_constraints");
        set => SetArgument("os_constraints", value);
    }

}

/// <summary>
/// Block type for os_constraints in GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockDevicePolicyBlockOsConstraintsBlock : TerraformBlock
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

    /// <summary>
    /// If you specify DESKTOP_CHROME_OS for osType, you can optionally include requireVerifiedChromeOs to require Chrome Verified Access.
    /// </summary>
    public TerraformValue<bool>? RequireVerifiedChromeOs
    {
        get => GetArgument<TerraformValue<bool>>("require_verified_chrome_os");
        set => SetArgument("require_verified_chrome_os", value);
    }

}

/// <summary>
/// Block type for vpc_network_sources in GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_network_sources";

    /// <summary>
    /// VpcSubnetwork block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcSubnetwork block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlockVpcSubnetworkBlock>? VpcSubnetwork
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlockVpcSubnetworkBlock>>("vpc_subnetwork");
        set => SetArgument("vpc_subnetwork", value);
    }

}

/// <summary>
/// Block type for vpc_subnetwork in GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelBasicBlockConditionsBlockVpcNetworkSourcesBlockVpcSubnetworkBlock : TerraformBlock
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
    /// A list of CIDR block IP subnetwork specification. Must be IPv4.
    /// </summary>
    public TerraformList<string>? VpcIpSubnetworks
    {
        get => GetArgument<TerraformList<string>>("vpc_ip_subnetworks");
        set => SetArgument("vpc_ip_subnetworks", value);
    }

}


/// <summary>
/// Block type for custom in GoogleAccessContextManagerAccessLevel.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelCustomBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom";

    /// <summary>
    /// Expr block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expr is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Expr block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expr block(s) allowed")]
    public required TerraformList<GoogleAccessContextManagerAccessLevelCustomBlockExprBlock> Expr
    {
        get => GetRequiredArgument<TerraformList<GoogleAccessContextManagerAccessLevelCustomBlockExprBlock>>("expr");
        set => SetArgument("expr", value);
    }

}

/// <summary>
/// Block type for expr in GoogleAccessContextManagerAccessLevelCustomBlock.
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelCustomBlockExprBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expr";

    /// <summary>
    /// Description of the expression
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetRequiredArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file name and a position in the file
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAccessContextManagerAccessLevel.
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessLevelTimeoutsBlock : TerraformBlock
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
/// Represents a google_access_context_manager_access_level Terraform resource.
/// Manages a google_access_context_manager_access_level resource.
/// </summary>
public partial class GoogleAccessContextManagerAccessLevel(string name) : TerraformResource("google_access_context_manager_access_level", name)
{
    /// <summary>
    /// Description of the AccessLevel and its use. Does not affect behavior.
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
    /// Resource name for the Access Level. The short_name component must begin
    /// with a letter and only include alphanumeric and &#39;_&#39;.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The AccessPolicy this AccessLevel lives in.
    /// Format: accessPolicies/{policy_id}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Human readable title. Must be unique within the Policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    public required TerraformValue<string> Title
    {
        get => GetRequiredArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// Basic block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Basic block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerAccessLevelBasicBlock>? Basic
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelBasicBlock>>("basic");
        set => SetArgument("basic", value);
    }

    /// <summary>
    /// Custom block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Custom block(s) allowed")]
    public TerraformList<GoogleAccessContextManagerAccessLevelCustomBlock>? Custom
    {
        get => GetArgument<TerraformList<GoogleAccessContextManagerAccessLevelCustomBlock>>("custom");
        set => SetArgument("custom", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAccessContextManagerAccessLevelTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAccessContextManagerAccessLevelTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
