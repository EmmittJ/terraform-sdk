using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enrolled_services in GoogleFolderAccessApprovalSettings.
/// Nesting mode: set
/// </summary>
public class GoogleFolderAccessApprovalSettingsEnrolledServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enrolled_services";

    /// <summary>
    /// The product for which Access Approval will be enrolled. Allowed values are listed (case-sensitive):
    ///   * all
    ///   * App Engine
    ///   * BigQuery
    ///   * Cloud Bigtable
    ///   * Cloud Key Management Service
    ///   * Compute Engine
    ///   * Cloud Dataflow
    ///   * Cloud Identity and Access Management
    ///   * Cloud Pub/Sub
    ///   * Cloud Storage
    ///   * Persistent Disk
    /// 
    /// Note: These values are supported as input, but considered a legacy format:
    ///   * all
    ///   * appengine.googleapis.com
    ///   * bigquery.googleapis.com
    ///   * bigtable.googleapis.com
    ///   * cloudkms.googleapis.com
    ///   * compute.googleapis.com
    ///   * dataflow.googleapis.com
    ///   * iam.googleapis.com
    ///   * pubsub.googleapis.com
    ///   * storage.googleapis.com
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudProduct is required")]
    public required TerraformValue<string> CloudProduct
    {
        get => new TerraformReference<string>(this, "cloud_product");
        set => SetArgument("cloud_product", value);
    }

    /// <summary>
    /// The enrollment level of the service. Default value: &amp;quot;BLOCK_ALL&amp;quot; Possible values: [&amp;quot;BLOCK_ALL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EnrollmentLevel
    {
        get => new TerraformReference<string>(this, "enrollment_level");
        set => SetArgument("enrollment_level", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleFolderAccessApprovalSettings.
/// Nesting mode: single
/// </summary>
public class GoogleFolderAccessApprovalSettingsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_folder_access_approval_settings Terraform resource.
/// Manages a google_folder_access_approval_settings resource.
/// </summary>
public partial class GoogleFolderAccessApprovalSettings(string name) : TerraformResource("google_folder_access_approval_settings", name)
{
    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// This property will be ignored if set by an ancestor of the resource, and new non-empty values may not be set.
    /// </summary>
    public TerraformValue<string>? ActiveKeyVersion
    {
        get => new TerraformReference<string>(this, "active_key_version");
        set => SetArgument("active_key_version", value);
    }

    /// <summary>
    /// ID of the folder of the access approval settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformValue<string> FolderId
    {
        get => new TerraformReference<string>(this, "folder_id");
        set => SetArgument("folder_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    public TerraformSet<string> NotificationEmails
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "notification_emails").ResolveNodes(ctx));
        set => SetArgument("notification_emails", value);
    }

    /// <summary>
    /// If the field is true, that indicates that an ancestor of this Folder has set active_key_version.
    /// </summary>
    public TerraformValue<bool> AncestorHasActiveKeyVersion
    {
        get => new TerraformReference<bool>(this, "ancestor_has_active_key_version");
    }

    /// <summary>
    /// If the field is true, that indicates that at least one service is enrolled for Access Approval in one or more ancestors of the Folder.
    /// </summary>
    public TerraformValue<bool> EnrolledAncestor
    {
        get => new TerraformReference<bool>(this, "enrolled_ancestor");
    }

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Folder (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.) This key version is not necessarily the effective key version at this level,
    /// as key versions are inherited top-down.
    /// </summary>
    public TerraformValue<bool> InvalidKeyVersion
    {
        get => new TerraformReference<bool>(this, "invalid_key_version");
    }

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;folders/{folder_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// EnrolledServices block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrolledServices is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnrolledServices block(s) required")]
    public required TerraformSet<GoogleFolderAccessApprovalSettingsEnrolledServicesBlock> EnrolledServices
    {
        get => GetRequiredArgument<TerraformSet<GoogleFolderAccessApprovalSettingsEnrolledServicesBlock>>("enrolled_services");
        set => SetArgument("enrolled_services", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleFolderAccessApprovalSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleFolderAccessApprovalSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
