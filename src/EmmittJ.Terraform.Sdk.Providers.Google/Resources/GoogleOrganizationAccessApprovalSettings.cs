using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_organization_access_approval_settings resource.
/// </summary>
public class GoogleOrganizationAccessApprovalSettings : TerraformResource
{
    public GoogleOrganizationAccessApprovalSettings(string name) : base("google_organization_access_approval_settings", name)
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
    /// ID of the organization of the access approval settings.
    /// </summary>
    public string? OrganizationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization_id")?.Value;
        set => this.WithProperty("organization_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// This field will always be unset for the organization since organizations do not have ancestors.
    /// </summary>
    public TerraformExpression AncestorHasActiveKeyVersion => this["ancestor_has_active_key_version"];

    /// <summary>
    /// This field will always be unset for the organization since organizations do not have ancestors.
    /// </summary>
    public TerraformExpression EnrolledAncestor => this["enrolled_ancestor"];

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Organization (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.).
    /// </summary>
    public TerraformExpression InvalidKeyVersion => this["invalid_key_version"];

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;organizations/{organization_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
