using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_privileged_access_manager_entitlement.
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementDataSource : TerraformDataSource
{
    public GooglePrivilegedAccessManagerEntitlementDataSource(string name) : base("google_privileged_access_manager_entitlement", name)
    {
    }

    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    [TerraformProperty("entitlement_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EntitlementId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The region of the Entitlement resource.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    [TerraformProperty("parent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Parent { get; set; }

    /// <summary>
    /// AdditionalNotificationTargets includes email addresses to be notified.
    /// </summary>
    [TerraformProperty("additional_notification_targets")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> AdditionalNotificationTargets { get; }

    /// <summary>
    /// The approvals needed before access will be granted to a requester.
    /// No approvals will be needed if this field is null. Different types of approval workflows that can be used to gate privileged access granting.
    /// </summary>
    [TerraformProperty("approval_workflow")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ApprovalWorkflow { get; }

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Who can create Grants using Entitlement. This list should contain at most one entry
    /// </summary>
    [TerraformProperty("eligible_users")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EligibleUsers { get; }

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Etag { get; }

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    [TerraformProperty("max_request_duration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MaxRequestDuration { get; }

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Privileged access that this service can be used to gate.
    /// </summary>
    [TerraformProperty("privileged_access")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PrivilegedAccess { get; }

    /// <summary>
    /// Defines the ways in which a requester should provide the justification while requesting for access.
    /// </summary>
    [TerraformProperty("requester_justification_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> RequesterJustificationConfig { get; }

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
