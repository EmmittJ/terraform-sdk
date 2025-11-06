using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The Apigee Environment associated with the Apigee API deployment.
    /// </summary>
    public string? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment")?.Value;
        set => this.WithProperty("environment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee API deployment.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Apigee API associated with the Apigee API deployment.
    /// </summary>
    public string? ProxyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proxy_id")?.Value;
        set => this.WithProperty("proxy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revision of the API proxy to be deployed.
    /// </summary>
    public string? Revision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision")?.Value;
        set => this.WithProperty("revision", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the API deployment in the format &#39;organizations/{{org_id}}/environments/{{environment}}/apis/{{proxy_id}}/revisions/{{revision}}/deployments&#39;.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
