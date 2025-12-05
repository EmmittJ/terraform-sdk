using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_privileged_access_manager_entitlement Terraform data source.
/// Retrieves information about a google_privileged_access_manager_entitlement.
/// </summary>
public partial class GooglePrivilegedAccessManagerEntitlementDataSource(string name) : TerraformDataSource("google_privileged_access_manager_entitlement", name)
{
    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    public TerraformValue<string>? EntitlementId
    {
        get => GetArgument<TerraformValue<string>>("entitlement_id");
        set => SetArgument("entitlement_id", value);
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
    /// The region of the Entitlement resource.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    public TerraformValue<string>? Parent
    {
        get => GetArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// AdditionalNotificationTargets includes email addresses to be notified.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdditionalNotificationTargets
        => CreateReference("additional_notification_targets");

    /// <summary>
    /// The approvals needed before access will be granted to a requester.
    /// No approvals will be needed if this field is null. Different types of approval workflows that can be used to gate privileged access granting.
    /// </summary>
    public TerraformList<TerraformMap<object>> ApprovalWorkflow
        => CreateReference("approval_workflow");

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Who can create Grants using Entitlement. This list should contain at most one entry
    /// </summary>
    public TerraformList<TerraformMap<object>> EligibleUsers
        => CreateReference("eligible_users");

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformValue<string> Etag
        => CreateReference("etag");

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    public TerraformValue<string> MaxRequestDuration
        => CreateReference("max_request_duration");

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Privileged access that this service can be used to gate.
    /// </summary>
    public TerraformList<TerraformMap<object>> PrivilegedAccess
        => CreateReference("privileged_access");

    /// <summary>
    /// Defines the ways in which a requester should provide the justification while requesting for access.
    /// </summary>
    public TerraformList<TerraformMap<object>> RequesterJustificationConfig
        => CreateReference("requester_justification_config");

    /// <summary>
    /// Output only. The current state of the Entitlement.
    /// </summary>
    public TerraformValue<string> State
        => CreateReference("state");

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

}
