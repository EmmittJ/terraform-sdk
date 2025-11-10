using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Use this ephemeral resource to access the configuration of the Google Cloud provider.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public class GoogleClientConfigEphemeralResource : TerraformEphemeralResource
{
    public GoogleClientConfigEphemeralResource(string name) : base("google_client_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("access_token");
        this.WithOutput("default_labels");
        this.WithOutput("id");
        this.WithOutput("project");
        this.WithOutput("region");
        this.WithOutput("zone");
    }

    /// <summary>
    /// The OAuth2 access token used by the client to authenticate against the Google Cloud API.
    /// </summary>
    public TerraformExpression AccessToken => this["access_token"];

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    public TerraformExpression DefaultLabels => this["default_labels"];

    /// <summary>
    /// The ID of this ephemeral resource in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the ephemeral resource in requests to Google APIs.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    public TerraformExpression Project => this["project"];

    /// <summary>
    /// The region to operate under.
    /// </summary>
    public TerraformExpression Region => this["region"];

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    public TerraformExpression Zone => this["zone"];

}
