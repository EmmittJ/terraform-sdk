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
    {
        get => new TerraformReference<string>(this, "access_token");
    }

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> DefaultLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "default_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ID of this data source in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the data source in requests to Google APIs.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
    }

    /// <summary>
    /// The region to operate under.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
    }

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => new TerraformReference<string>(this, "zone");
    }

}
