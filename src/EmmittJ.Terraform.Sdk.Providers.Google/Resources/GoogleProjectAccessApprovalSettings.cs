using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_access_approval_settings resource.
/// </summary>
public class GoogleProjectAccessApprovalSettings : TerraformResource
{
    public GoogleProjectAccessApprovalSettings(string name) : base("google_project_access_approval_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ancestor_has_active_key_version");
        this.DeclareOutput("enrolled_ancestor");
        this.DeclareOutput("invalid_key_version");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// This property will be ignored if set by an ancestor of the resource, and new non-empty values may not be set.
    /// </summary>
    public string? ActiveKeyVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("active_key_version")?.Value;
        set => this.WithProperty("active_key_version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    public HashSet<string>? NotificationEmails
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("notification_emails")?.Value;
        set => this.WithProperty("notification_emails", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// Project id.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// ID of the project of the access approval settings.
    /// </summary>
    public string? ProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_id")?.Value;
        set => this.WithProperty("project_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If the field is true, that indicates that an ancestor of this Project has set active_key_version.
    /// </summary>
    public TerraformExpression AncestorHasActiveKeyVersion => this["ancestor_has_active_key_version"];

    /// <summary>
    /// If the field is true, that indicates that at least one service is enrolled for Access Approval in one or more ancestors of the Project.
    /// </summary>
    public TerraformExpression EnrolledAncestor => this["enrolled_ancestor"];

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Project (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.) This key version is not necessarily the effective key version at this level,
    /// as key versions are inherited top-down.
    /// </summary>
    public TerraformExpression InvalidKeyVersion => this["invalid_key_version"];

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;projects/{project_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
