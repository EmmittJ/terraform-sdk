using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enrolled_services in GoogleOrganizationAccessApprovalSettings.
/// Nesting mode: set
/// </summary>
public class GoogleOrganizationAccessApprovalSettingsEnrolledServicesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enrolled_services";

    /// <summary>
    /// The product for which Access Approval will be enrolled. Allowed values are listed (case-sensitive):
    ///   all
    ///   appengine.googleapis.com
    ///   bigquery.googleapis.com
    ///   bigtable.googleapis.com
    ///   cloudkms.googleapis.com
    ///   compute.googleapis.com
    ///   dataflow.googleapis.com
    ///   iam.googleapis.com
    ///   pubsub.googleapis.com
    ///   storage.googleapis.com
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudProduct is required")]
    public required TerraformValue<string> CloudProduct
    {
        get => GetArgument<TerraformValue<string>>("cloud_product");
        set => SetArgument("cloud_product", value);
    }

    /// <summary>
    /// The enrollment level of the service. Default value: &amp;quot;BLOCK_ALL&amp;quot; Possible values: [&amp;quot;BLOCK_ALL&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EnrollmentLevel
    {
        get => GetArgument<TerraformValue<string>>("enrollment_level");
        set => SetArgument("enrollment_level", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleOrganizationAccessApprovalSettings.
/// Nesting mode: single
/// </summary>
public class GoogleOrganizationAccessApprovalSettingsTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_organization_access_approval_settings Terraform resource.
/// Manages a google_organization_access_approval_settings resource.
/// </summary>
public partial class GoogleOrganizationAccessApprovalSettings(string name) : TerraformResource("google_organization_access_approval_settings", name)
{
    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// </summary>
    public TerraformValue<string>? ActiveKeyVersion
    {
        get => GetArgument<TerraformValue<string>>("active_key_version");
        set => SetArgument("active_key_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    public TerraformSet<string>? NotificationEmails
    {
        get => GetArgument<TerraformSet<string>>("notification_emails");
        set => SetArgument("notification_emails", value);
    }

    /// <summary>
    /// ID of the organization of the access approval settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformValue<string> OrganizationId
    {
        get => GetArgument<TerraformValue<string>>("organization_id");
        set => SetArgument("organization_id", value);
    }

    /// <summary>
    /// This field will always be unset for the organization since organizations do not have ancestors.
    /// </summary>
    public TerraformValue<bool> AncestorHasActiveKeyVersion
        => AsReference("ancestor_has_active_key_version");

    /// <summary>
    /// This field will always be unset for the organization since organizations do not have ancestors.
    /// </summary>
    public TerraformValue<bool> EnrolledAncestor
        => AsReference("enrolled_ancestor");

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Organization (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.).
    /// </summary>
    public TerraformValue<bool> InvalidKeyVersion
        => AsReference("invalid_key_version");

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;organizations/{organization_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// EnrolledServices block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrolledServices is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnrolledServices block(s) required")]
    public required TerraformSet<GoogleOrganizationAccessApprovalSettingsEnrolledServicesBlock> EnrolledServices
    {
        get => GetRequiredArgument<TerraformSet<GoogleOrganizationAccessApprovalSettingsEnrolledServicesBlock>>("enrolled_services");
        set => SetArgument("enrolled_services", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleOrganizationAccessApprovalSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleOrganizationAccessApprovalSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
