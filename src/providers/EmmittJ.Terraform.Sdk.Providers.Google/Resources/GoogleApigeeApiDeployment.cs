using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleApigeeApiDeployment.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeApiDeploymentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_apigee_api_deployment Terraform resource.
/// Manages a google_apigee_api_deployment resource.
/// </summary>
public partial class GoogleApigeeApiDeployment(string name) : TerraformResource("google_apigee_api_deployment", name)
{
    /// <summary>
    /// The Apigee Environment associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetRequiredArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The Apigee API associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProxyId is required")]
    public required TerraformValue<string> ProxyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("proxy_id");
        set => SetArgument("proxy_id", value);
    }

    /// <summary>
    /// The revision of the API proxy to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<string> Revision
    {
        get => GetRequiredArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The ID of the API deployment in the format &#39;organizations/{{org_id}}/environments/{{environment}}/apis/{{proxy_id}}/revisions/{{revision}}/deployments&#39;.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeApiDeploymentTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeApiDeploymentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
