using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for additional_notification_targets in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Additional email addresses to be notified when a principal(requester) is granted access.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AdminEmailRecipients
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("admin_email_recipients");
        set => WithProperty("admin_email_recipients", value);
    }

    /// <summary>
    /// Optional. Additional email address to be notified about an eligible entitlement.
    /// </summary>
    public HashSet<TerraformProperty<string>>? RequesterEmailRecipients
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("requester_email_recipients");
        set => WithProperty("requester_email_recipients", value);
    }

}

/// <summary>
/// Block type for approval_workflow in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock : TerraformBlock
{
}

/// <summary>
/// Block type for eligible_users in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock : TerraformBlock
{
    /// <summary>
    /// Users who are being allowed for the operation. Each entry should be a valid v1 IAM Principal Identifier. Format for these is documented at &amp;quot;https://cloud.google.com/iam/docs/principal-identifiers#v1&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principals is required")]
    public HashSet<TerraformProperty<string>>? Principals
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("principals");
        set => WithProperty("principals", value);
    }

}

/// <summary>
/// Block type for privileged_access in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock : TerraformBlock
{
}

/// <summary>
/// Block type for requester_justification_config in .
/// Nesting mode: list
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePrivilegedAccessManagerEntitlementTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_privileged_access_manager_entitlement resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePrivilegedAccessManagerEntitlement : TerraformResource
{
    public GooglePrivilegedAccessManagerEntitlement(string name) : base("google_privileged_access_manager_entitlement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("create_time");
        this.WithOutput("etag");
        this.WithOutput("name");
        this.WithOutput("state");
        this.WithOutput("update_time");
    }

    /// <summary>
    /// The ID to use for this Entitlement. This will become the last part of the resource name.
    /// This value should be 4-63 characters, and valid characters are &amp;quot;[a-z]&amp;quot;, &amp;quot;[0-9]&amp;quot;, and &amp;quot;-&amp;quot;. The first character should be from [a-z].
    /// This value should be unique among all other Entitlements under the specified &#39;parent&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntitlementId is required")]
    public required TerraformProperty<string> EntitlementId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("entitlement_id");
        set => this.WithProperty("entitlement_id", value);
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
    /// The region of the Entitlement resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum amount of time for which access would be granted for a request.
    /// A requester can choose to ask for access for less than this duration but never more.
    /// Format: calculate the time in seconds and concatenate it with &#39;s&#39; i.e. 2 hours = &amp;quot;7200s&amp;quot;, 45 minutes = &amp;quot;2700s&amp;quot;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxRequestDuration is required")]
    public required TerraformProperty<string> MaxRequestDuration
    {
        get => GetRequiredProperty<TerraformProperty<string>>("max_request_duration");
        set => this.WithProperty("max_request_duration", value);
    }

    /// <summary>
    /// Format: projects/{project-id|project-number} or organizations/{organization-number} or folders/{folder-number}
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for additional_notification_targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdditionalNotificationTargets block(s) allowed")]
    public List<GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock>? AdditionalNotificationTargets
    {
        get => GetProperty<List<GooglePrivilegedAccessManagerEntitlementAdditionalNotificationTargetsBlock>>("additional_notification_targets");
        set => this.WithProperty("additional_notification_targets", value);
    }

    /// <summary>
    /// Block for approval_workflow.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApprovalWorkflow block(s) allowed")]
    public List<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock>? ApprovalWorkflow
    {
        get => GetProperty<List<GooglePrivilegedAccessManagerEntitlementApprovalWorkflowBlock>>("approval_workflow");
        set => this.WithProperty("approval_workflow", value);
    }

    /// <summary>
    /// Block for eligible_users.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EligibleUsers block(s) required")]
    public List<GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock>? EligibleUsers
    {
        get => GetProperty<List<GooglePrivilegedAccessManagerEntitlementEligibleUsersBlock>>("eligible_users");
        set => this.WithProperty("eligible_users", value);
    }

    /// <summary>
    /// Block for privileged_access.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrivilegedAccess block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrivilegedAccess block(s) allowed")]
    public List<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock>? PrivilegedAccess
    {
        get => GetProperty<List<GooglePrivilegedAccessManagerEntitlementPrivilegedAccessBlock>>("privileged_access");
        set => this.WithProperty("privileged_access", value);
    }

    /// <summary>
    /// Block for requester_justification_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RequesterJustificationConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequesterJustificationConfig block(s) allowed")]
    public List<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock>? RequesterJustificationConfig
    {
        get => GetProperty<List<GooglePrivilegedAccessManagerEntitlementRequesterJustificationConfigBlock>>("requester_justification_config");
        set => this.WithProperty("requester_justification_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePrivilegedAccessManagerEntitlementTimeoutsBlock? Timeouts
    {
        get => GetProperty<GooglePrivilegedAccessManagerEntitlementTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Create time stamp. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// For Resource freshness validation (https://google.aip.dev/154)
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Output Only. The entitlement&#39;s name follows a hierarchical structure, comprising the organization, folder, or project, alongside the region and a unique entitlement ID.
    /// Formats: organizations/{organization-number}/locations/{region}/entitlements/{entitlement-id}, folders/{folder-number}/locations/{region}/entitlements/{entitlement-id}, and projects/{project-id|project-number}/locations/{region}/entitlements/{entitlement-id}.
    /// </summary>
    public TerraformExpression Name => this["name"];

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
