using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_privileged_access_manager_entitlement.
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementDataSource : TerraformDataSource
{
    public GooglePrivilegedAccessManagerEntitlementDataSource(string name) : base("google_privileged_access_manager_entitlement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("additional_notification_targets");
        this.DeclareOutput("approval_workflow");
        this.DeclareOutput("create_time");
        this.DeclareOutput("eligible_users");
        this.DeclareOutput("etag");
        this.DeclareOutput("max_request_duration");
        this.DeclareOutput("name");
        this.DeclareOutput("privileged_access");
        this.DeclareOutput("requester_justification_config");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    public string? EntitlementId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("entitlement_id")?.Value;
        set => this.WithProperty("entitlement_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region of the Entitlement resource.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// AdditionalNotificationTargets includes email addresses to be notified.
    /// </summary>
    public TerraformExpression AdditionalNotificationTargets => this["additional_notification_targets"];

    /// <summary>
    /// The approvals needed before access will be granted to a requester.
    /// No approvals will be needed if this field is null. Different types of approval workflows that can be used to gate privileged access granting.
    /// </summary>
    public TerraformExpression ApprovalWorkflow => this["approval_workflow"];

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Who can create Grants using Entitlement. This list should contain at most one entry
    /// </summary>
    public TerraformExpression EligibleUsers => this["eligible_users"];

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    public TerraformExpression MaxRequestDuration => this["max_request_duration"];

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Privileged access that this service can be used to gate.
    /// </summary>
    public TerraformExpression PrivilegedAccess => this["privileged_access"];

    /// <summary>
    /// Defines the ways in which a requester should provide the justification while requesting for access.
    /// </summary>
    public TerraformExpression RequesterJustificationConfig => this["requester_justification_config"];

    /// <summary>
    /// Output only. The current state of the Entitlement.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. Update time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
