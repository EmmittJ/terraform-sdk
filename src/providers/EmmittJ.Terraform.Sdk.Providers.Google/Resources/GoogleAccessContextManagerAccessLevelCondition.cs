using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for device_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels. Possible values: [&amp;quot;MANAGEMENT_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;BASIC&amp;quot;, &amp;quot;COMPLETE&amp;quot;]
    /// </summary>
    [TerraformProperty("allowed_device_management_levels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses. Possible values: [&amp;quot;ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;ENCRYPTION_UNSUPPORTED&amp;quot;, &amp;quot;UNENCRYPTED&amp;quot;, &amp;quot;ENCRYPTED&amp;quot;]
    /// </summary>
    [TerraformProperty("allowed_encryption_statuses")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? AllowedEncryptionStatuses { get; set; }

    /// <summary>
    /// Whether the device needs to be approved by the customer admin.
    /// </summary>
    [TerraformProperty("require_admin_approval")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireAdminApproval { get; set; }

    /// <summary>
    /// Whether the device needs to be corp owned.
    /// </summary>
    [TerraformProperty("require_corp_owned")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireCorpOwned { get; set; }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    [TerraformProperty("require_screen_lock")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RequireScreenLock { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock : TerraformBlockBase
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

}

/// <summary>
/// Block type for vpc_network_sources in .
/// Nesting mode: list
/// </summary>
public partial class GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a google_access_context_manager_access_level_condition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleAccessContextManagerAccessLevelCondition : TerraformResource
{
    public GoogleAccessContextManagerAccessLevelCondition(string name) : base("google_access_context_manager_access_level_condition", name)
    {
    }

    /// <summary>
    /// The name of the Access Level to add this condition to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    [TerraformProperty("access_level")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    [TerraformProperty("ip_subnetworks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? IpSubnetworks { get; set; }

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
    [TerraformProperty("members")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Members { get; set; }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    [TerraformProperty("negate")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Negate { get; set; }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Regions { get; set; }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [TerraformProperty("required_access_levels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? RequiredAccessLevels { get; set; }

    /// <summary>
    /// Block for device_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DevicePolicy block(s) allowed")]
    [TerraformProperty("device_policy")]
    public partial TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock>>? DevicePolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vpc_network_sources.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("vpc_network_sources")]
    public partial TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock>>? VpcNetworkSources { get; set; }

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformProperty("access_policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessPolicyId { get; }

}
