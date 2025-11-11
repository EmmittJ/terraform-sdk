using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_privileged_access_manager_entitlement.
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementDataSource : TerraformDataSource
{
    public GooglePrivilegedAccessManagerEntitlementDataSource(string name) : base("google_privileged_access_manager_entitlement", name)
    {
    }

    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    [TerraformPropertyName("entitlement_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EntitlementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The region of the Entitlement resource.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// AdditionalNotificationTargets includes email addresses to be notified.
    /// </summary>
    [TerraformPropertyName("additional_notification_targets")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AdditionalNotificationTargets => new TerraformReference(this, "additional_notification_targets");

    /// <summary>
    /// The approvals needed before access will be granted to a requester.
    /// No approvals will be needed if this field is null. Different types of approval workflows that can be used to gate privileged access granting.
    /// </summary>
    [TerraformPropertyName("approval_workflow")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ApprovalWorkflow => new TerraformReference(this, "approval_workflow");

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// Who can create Grants using Entitlement. This list should contain at most one entry
    /// </summary>
    [TerraformPropertyName("eligible_users")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EligibleUsers => new TerraformReference(this, "eligible_users");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Etag => new TerraformReference(this, "etag");

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    [TerraformPropertyName("max_request_duration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MaxRequestDuration => new TerraformReference(this, "max_request_duration");

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// Privileged access that this service can be used to gate.
    /// </summary>
    [TerraformPropertyName("privileged_access")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PrivilegedAccess => new TerraformReference(this, "privileged_access");

    /// <summary>
    /// Defines the ways in which a requester should provide the justification while requesting for access.
    /// </summary>
    [TerraformPropertyName("requester_justification_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RequesterJustificationConfig => new TerraformReference(this, "requester_justification_config");

    /// <summary>
    /// Output only. The current state of the Entitlement.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
