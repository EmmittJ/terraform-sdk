using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for device_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// A list of allowed device management levels.
    /// An empty list allows all management levels. Possible values: [&amp;quot;MANAGEMENT_UNSPECIFIED&amp;quot;, &amp;quot;NONE&amp;quot;, &amp;quot;BASIC&amp;quot;, &amp;quot;COMPLETE&amp;quot;]
    /// </summary>
    [TerraformPropertyName("allowed_device_management_levels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedDeviceManagementLevels { get; set; }

    /// <summary>
    /// A list of allowed encryptions statuses.
    /// An empty list allows all statuses. Possible values: [&amp;quot;ENCRYPTION_UNSPECIFIED&amp;quot;, &amp;quot;ENCRYPTION_UNSUPPORTED&amp;quot;, &amp;quot;UNENCRYPTED&amp;quot;, &amp;quot;ENCRYPTED&amp;quot;]
    /// </summary>
    [TerraformPropertyName("allowed_encryption_statuses")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AllowedEncryptionStatuses { get; set; }

    /// <summary>
    /// Whether the device needs to be approved by the customer admin.
    /// </summary>
    [TerraformPropertyName("require_admin_approval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireAdminApproval { get; set; }

    /// <summary>
    /// Whether the device needs to be corp owned.
    /// </summary>
    [TerraformPropertyName("require_corp_owned")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireCorpOwned { get; set; }

    /// <summary>
    /// Whether or not screenlock is required for the DevicePolicy
    /// to be true. Defaults to false.
    /// </summary>
    [TerraformPropertyName("require_screen_lock")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireScreenLock { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Block type for vpc_network_sources in .
/// Nesting mode: list
/// </summary>
public class GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a google_access_context_manager_access_level_condition resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAccessContextManagerAccessLevelCondition : TerraformResource
{
    public GoogleAccessContextManagerAccessLevelCondition(string name) : base("google_access_context_manager_access_level_condition", name)
    {
    }

    /// <summary>
    /// The name of the Access Level to add this condition to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    [TerraformPropertyName("access_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessLevel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("ip_subnetworks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? IpSubnetworks { get; set; }

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
    [TerraformPropertyName("members")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Members { get; set; }

    /// <summary>
    /// Whether to negate the Condition. If true, the Condition becomes
    /// a NAND over its non-empty fields, each field must be false for
    /// the Condition overall to be satisfied. Defaults to false.
    /// </summary>
    [TerraformPropertyName("negate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Negate { get; set; }

    /// <summary>
    /// The request must originate from one of the provided
    /// countries/regions.
    /// Format: A valid ISO 3166-1 alpha-2 code.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Regions { get; set; }

    /// <summary>
    /// A list of other access levels defined in the same Policy,
    /// referenced by resource name. Referencing an AccessLevel which
    /// does not exist is an error. All access levels listed must be
    /// granted for the Condition to be true.
    /// Format: accessPolicies/{policy_id}/accessLevels/{short_name}
    /// </summary>
    [TerraformPropertyName("required_access_levels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? RequiredAccessLevels { get; set; }

    /// <summary>
    /// Block for device_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DevicePolicy block(s) allowed")]
    [TerraformPropertyName("device_policy")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelConditionDevicePolicyBlock>>? DevicePolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAccessContextManagerAccessLevelConditionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vpc_network_sources.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("vpc_network_sources")]
    public TerraformList<TerraformBlock<GoogleAccessContextManagerAccessLevelConditionVpcNetworkSourcesBlock>>? VpcNetworkSources { get; set; } = new();

    /// <summary>
    /// The name of the Access Policy this resource belongs to.
    /// </summary>
    [TerraformPropertyName("access_policy_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessPolicyId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_policy_id");

}
