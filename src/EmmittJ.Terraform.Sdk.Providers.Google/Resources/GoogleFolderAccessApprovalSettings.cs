using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_folder_access_approval_settings resource.
/// </summary>
public class GoogleFolderAccessApprovalSettings : TerraformResource
{
    public GoogleFolderAccessApprovalSettings(string name) : base("google_folder_access_approval_settings", name)
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
    public TerraformProperty<string>? ActiveKeyVersion
    {
        get => GetProperty<TerraformProperty<string>>("active_key_version");
        set => this.WithProperty("active_key_version", value);
    }

    /// <summary>
    /// ID of the folder of the access approval settings.
    /// </summary>
    public TerraformProperty<string>? FolderId
    {
        get => GetProperty<TerraformProperty<string>>("folder_id");
        set => this.WithProperty("folder_id", value);
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
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    public TerraformProperty<HashSet<string>>? NotificationEmails
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("notification_emails");
        set => this.WithProperty("notification_emails", value);
    }

    /// <summary>
    /// If the field is true, that indicates that an ancestor of this Folder has set active_key_version.
    /// </summary>
    public TerraformExpression AncestorHasActiveKeyVersion => this["ancestor_has_active_key_version"];

    /// <summary>
    /// If the field is true, that indicates that at least one service is enrolled for Access Approval in one or more ancestors of the Folder.
    /// </summary>
    public TerraformExpression EnrolledAncestor => this["enrolled_ancestor"];

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Folder (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.) This key version is not necessarily the effective key version at this level,
    /// as key versions are inherited top-down.
    /// </summary>
    public TerraformExpression InvalidKeyVersion => this["invalid_key_version"];

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;folders/{folder_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
