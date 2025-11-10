using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for device_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock : TerraformBlock
{
    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels. Possible values: [&amp;quot;MANAGEMENT_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;BASIC&amp;quot;, &amp;quot;COMPLETE&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? AllowedDeviceManagementLevels
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_device_management_levels");
        set => WithProperty("allowed_device_management_levels", value);
    }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses. Possible values: [&amp;quot;ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;ENCRYPTION_UNSUPPORTED&amp;quot;, &amp;quot;UNENCRYPTED&amp;quot;, &amp;quot;ENCRYPTED&amp;quot;]
    /// </summary>
    public List<TerraformProperty<string>>? AllowedEncryptionStatuses
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_encryption_statuses");
        set => WithProperty("allowed_encryption_statuses", value);
    }

    /// <summary>
    /// Whether the device needs to be approved by the customer admin.
    /// </summary>
    public TerraformProperty<bool>? RequireAdminApproval
    {
        get => GetProperty<TerraformProperty<bool>>("require_admin_approval");
        set => WithProperty("require_admin_approval", value);
    }

    /// <summary>
    /// Whether the device needs to be corp owned.
    /// </summary>
    public TerraformProperty<bool>? RequireCorpOwned
    {
        get => GetProperty<TerraformProperty<bool>>("require_corp_owned");
        set => WithProperty("require_corp_owned", value);
    }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? RequireScreenLock
    {
        get => GetProperty<TerraformProperty<bool>>("require_screen_lock");
        set => WithProperty("require_screen_lock", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Block type for vpc_network_sources in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock : TerraformBlock
{
}

/// <summary>
/// Manages a google_access_context_manager_access_level_condition resource.
/// </summary>
public class GoogleAccessContextManagerAccessLevelCondition : TerraformResource
{
    public GoogleAccessContextManagerAccessLevelCondition(string name) : base("google_access_context_manager_access_level_condition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_id");
    }

    /// <summary>
    /// The name of the Access Level to add this condition to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    public required TerraformProperty<string> AccessLevel
    {
        get => GetProperty<TerraformProperty<string>>("access_level");
        set => this.WithProperty("access_level", value);
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
    public List<TerraformProperty<string>>? IpSubnetworks
    {
        get => GetProperty<List<TerraformProperty<string>>>("ip_subnetworks");
        set => this.WithProperty("ip_subnetworks", value);
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
    public List<TerraformProperty<string>>? Members
    {
        get => GetProperty<List<TerraformProperty<string>>>("members");
        set => this.WithProperty("members", value);
    }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    public TerraformProperty<bool>? Negate
    {
        get => GetProperty<TerraformProperty<bool>>("negate");
        set => this.WithProperty("negate", value);
    }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    public List<TerraformProperty<string>>? Regions
    {
        get => GetProperty<List<TerraformProperty<string>>>("regions");
        set => this.WithProperty("regions", value);
    }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    public List<TerraformProperty<string>>? RequiredAccessLevels
    {
        get => GetProperty<List<TerraformProperty<string>>>("required_access_levels");
        set => this.WithProperty("required_access_levels", value);
    }

    /// <summary>
    /// Block for device_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DevicePolicy block(s) allowed")]
    public List<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock>? DevicePolicy
    {
        get => GetProperty<List<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock>>("device_policy");
        set => this.WithProperty("device_policy", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vpc_network_sources.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock>? VpcNetworkSources
    {
        get => GetProperty<List<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock>>("vpc_network_sources");
        set => this.WithProperty("vpc_network_sources", value);
    }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    public TerraformExpression AccessPolicyId => this["access_policy_id"];

}
