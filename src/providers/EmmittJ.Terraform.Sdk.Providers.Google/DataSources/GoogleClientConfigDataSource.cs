using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_client_config Terraform data source.
/// Use this data source to access the configuration of the Google Cloud provider.
/// </summary>
public partial class GoogleClientConfigDataSource(string name) : TerraformDataSource("google_client_config", name)
{
    /// <summary>
    /// The OAuth2 access token used by the client to authenticate against the Google Cloud API.
    /// </summary>
    public TerraformValue<string> AccessToken
        => CreateReference("access_token");

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> DefaultLabels
        => CreateReference("default_labels");

    /// <summary>
    /// The ID of this data source in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the data source in requests to Google APIs.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    public TerraformValue<string> Project
        => CreateReference("project");

    /// <summary>
    /// The region to operate under.
    /// </summary>
    public TerraformValue<string> Region
        => CreateReference("region");

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    public TerraformValue<string> Zone
        => CreateReference("zone");

}
