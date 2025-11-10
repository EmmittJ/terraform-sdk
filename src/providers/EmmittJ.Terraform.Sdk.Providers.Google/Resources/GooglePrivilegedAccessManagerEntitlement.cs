using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for additional_notification_targets in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Additional email addresses to be notified when a principal(requester) is granted access.
    /// </summary>
    [TerraformPropertyName("admin_email_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AdminEmailRecipients { get; set; }

    /// <summary>
    /// Optional. Additional email address to be notified about an eligible entitlement.
    /// </summary>
    [TerraformPropertyName("requester_email_recipients")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? RequesterEmailRecipients { get; set; }

}

/// <summary>
/// Block type for approval_workflow in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for eligible_users in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock : ITerraformBlock
{
    /// <summary>
    /// Users who are being allowed for the operation. Each entry should be a valid v1 IAM Principal Identifier. Format for these is documented at &amp;quot;https://cloud.google.com/iam/docs/principal-identifiers#v1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principals is required")]
    [TerraformPropertyName("principals")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Principals { get; set; }

}

/// <summary>
/// Block type for privileged_access in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for requester_justification_config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementTimeoutsBlock : ITerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_privileged_access_manager_entitlement resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivilegedAccessManagerEntitlement : TerraformResource
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
    [TerraformPropertyName("entitlement_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EntitlementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The region of the Entitlement resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRequestDuration is required")]
    [TerraformPropertyName("max_request_duration")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MaxRequestDuration { get; set; }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Parent { get; set; }

    /// <summary>
    /// Block for additional_notification_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalNotificationTargets block(s) allowed")]
    [TerraformPropertyName("additional_notification_targets")]
    public TerraformList<TerraformBlock<GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock>>? AdditionalNotificationTargets { get; set; } = new();

    /// <summary>
    /// Block for approval_workflow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalWorkflow block(s) allowed")]
    [TerraformPropertyName("approval_workflow")]
    public TerraformList<TerraformBlock<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock>>? ApprovalWorkflow { get; set; } = new();

    /// <summary>
    /// Block for eligible_users.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EligibleUsers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EligibleUsers block(s) required")]
    [TerraformPropertyName("eligible_users")]
    public TerraformList<TerraformBlock<GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock>>? EligibleUsers { get; set; } = new();

    /// <summary>
    /// Block for privileged_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivilegedAccess is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivilegedAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivilegedAccess block(s) allowed")]
    [TerraformPropertyName("privileged_access")]
    public TerraformList<TerraformBlock<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock>>? PrivilegedAccess { get; set; } = new();

    /// <summary>
    /// Block for requester_justification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequesterJustificationConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequesterJustificationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequesterJustificationConfig block(s) allowed")]
    [TerraformPropertyName("requester_justification_config")]
    public TerraformList<TerraformBlock<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock>>? RequesterJustificationConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GooglePrivilegedAccessManagerEntitlementTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. The current state of the Entitlement.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
