using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeApiDeploymentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a google_apigee_api_deployment resource.
/// </summary>
public class GoogleApigeeApiDeployment : TerraformResource
{
    public GoogleApigeeApiDeployment(string name) : base("google_apigee_api_deployment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("environment");
        SetOutput("org_id");
        SetOutput("proxy_id");
        SetOutput("revision");
    }

    /// <summary>
    /// The Apigee Environment associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// The Apigee API associated with the Apigee API deployment.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProxyId is required")]
    public required TerraformProperty<string> ProxyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("proxy_id");
        set => SetProperty("proxy_id", value);
    }

    /// <summary>
    /// The revision of the API proxy to be deployed.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformProperty<string> Revision
    {
        get => GetRequiredOutput<TerraformProperty<string>>("revision");
        set => SetProperty("revision", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeApiDeploymentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The ID of the API deployment in the format &#39;organizations/{{org_id}}/environments/{{environment}}/apis/{{proxy_id}}/revisions/{{revision}}/deployments&#39;.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
