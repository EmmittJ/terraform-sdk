using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeSharedflowDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeSharedflowDeploymentTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_sharedflow_deployment Terraform resource.
/// Manages a google_apigee_sharedflow_deployment resource.
/// </summary>
public partial class GoogleApigeeSharedflowDeployment(string name) : TerraformResource("google_apigee_sharedflow_deployment", name)
{
    /// <summary>
    /// The resource ID of the environment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
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
    /// The Apigee Organization associated with the Apigee instance
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Revision of the Sharedflow to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<string> Revision
    {
        get => new TerraformReference<string>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The service account represents the identity of the deployed proxy, and determines what permissions it has. The format must be {ACCOUNT_ID}@{PROJECT}.iam.gserviceaccount.com.
    /// </summary>
    public TerraformValue<string>? ServiceAccount
    {
        get => new TerraformReference<string>(this, "service_account");
        set => SetArgument("service_account", value);
    }

    /// <summary>
    /// Id of the Sharedflow to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedflowId is required")]
    public required TerraformValue<string> SharedflowId
    {
        get => new TerraformReference<string>(this, "sharedflow_id");
        set => SetArgument("sharedflow_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeSharedflowDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeSharedflowDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
