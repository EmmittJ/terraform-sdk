using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeControlPlaneAccess.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeControlPlaneAccessTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_control_plane_access Terraform resource.
/// Manages a google_apigee_control_plane_access resource.
/// </summary>
public partial class GoogleApigeeControlPlaneAccess(string name) : TerraformResource("google_apigee_control_plane_access", name)
{
    /// <summary>
    /// Array of service accounts authorized to publish analytics data to the control plane, each specified using the following format: &#39;serviceAccount:service-account-name&#39;.
    /// 
    /// The &#39;service-account-name&#39; is formatted like an email address. For example: serviceAccount@my_project_id.iam.gserviceaccount.com
    /// 
    /// You might specify multiple service accounts, for example, if you have multiple environments and wish to assign a unique service account to each one.
    /// </summary>
    public TerraformList<string>? AnalyticsPublisherIdentities
    {
        get => GetArgument<TerraformList<string>>("analytics_publisher_identities");
        set => SetArgument("analytics_publisher_identities", value);
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
    /// Name of the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Array of service accounts to grant access to control plane resources (for the Synchronizer component), each specified using the following format: &#39;serviceAccount:service-account-name&#39;.
    /// 
    /// The &#39;service-account-name&#39; is formatted like an email address. For example: serviceAccount@my_project_id.iam.gserviceaccount.com
    /// 
    /// You might specify multiple service accounts, for example, if you have multiple environments and wish to assign a unique service account to each one.
    /// 
    /// The service accounts must have **Apigee Synchronizer Manager** role. See also [Create service accounts](https://cloud.google.com/apigee/docs/hybrid/v1.8/sa-about#create-the-service-accounts).
    /// </summary>
    public TerraformList<string>? SynchronizerIdentities
    {
        get => GetArgument<TerraformList<string>>("synchronizer_identities");
        set => SetArgument("synchronizer_identities", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeControlPlaneAccessTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeControlPlaneAccessTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
