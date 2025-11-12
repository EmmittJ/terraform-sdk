using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for additional_notification_targets in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock() : TerraformBlock("additional_notification_targets")
{
    /// <summary>
    /// Optional. Additional email addresses to be notified when a principal(requester) is granted access.
    /// </summary>
    [TerraformProperty("admin_email_recipients")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? AdminEmailRecipients { get; set; }

    /// <summary>
    /// Optional. Additional email address to be notified about an eligible entitlement.
    /// </summary>
    [TerraformProperty("requester_email_recipients")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? RequesterEmailRecipients { get; set; }

}

/// <summary>
/// Block type for approval_workflow in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock() : TerraformBlock("approval_workflow")
{
}

/// <summary>
/// Block type for eligible_users in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock() : TerraformBlock("eligible_users")
{
    /// <summary>
    /// Users who are being allowed for the operation. Each entry should be a valid v1 IAM Principal Identifier. Format for these is documented at &amp;quot;https://cloud.google.com/iam/docs/principal-identifiers#v1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principals is required")]
    [TerraformProperty("principals")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Principals { get; set; }

}

/// <summary>
/// Block type for privileged_access in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock() : TerraformBlock("privileged_access")
{
}

/// <summary>
/// Block type for requester_justification_config in .
/// Nesting mode: list
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock() : TerraformBlock("requester_justification_config")
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a google_privileged_access_manager_entitlement resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GooglePrivilegedAccessManagerEntitlement : TerraformResource
{
    public GooglePrivilegedAccessManagerEntitlement(string name) : base("google_privileged_access_manager_entitlement", name)
    {
    }

    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntitlementId is required")]
    [TerraformProperty("entitlement_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EntitlementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The region of the Entitlement resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRequestDuration is required")]
    [TerraformProperty("max_request_duration")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MaxRequestDuration { get; set; }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformProperty("parent")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// Block for additional_notification_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalNotificationTargets block(s) allowed")]
    [TerraformProperty("additional_notification_targets")]
    public TerraformList<GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock> AdditionalNotificationTargets { get; set; } = new();

    /// <summary>
    /// Block for approval_workflow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalWorkflow block(s) allowed")]
    [TerraformProperty("approval_workflow")]
    public TerraformList<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock> ApprovalWorkflow { get; set; } = new();

    /// <summary>
    /// Block for eligible_users.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EligibleUsers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EligibleUsers block(s) required")]
    [TerraformProperty("eligible_users")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock> EligibleUsers { get; set; } = new();

    /// <summary>
    /// Block for privileged_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivilegedAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivilegedAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivilegedAccess block(s) allowed")]
    [TerraformProperty("privileged_access")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock> PrivilegedAccess { get; set; } = new();

    /// <summary>
    /// Block for requester_justification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequesterJustificationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequesterJustificationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequesterJustificationConfig block(s) allowed")]
    [TerraformProperty("requester_justification_config")]
    public required TerraformList<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock> RequesterJustificationConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GooglePrivilegedAccessManagerEntitlementTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. The current state of the Entitlement.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
