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
    }

    /// <summary>
    /// The OAuth2 access token used by the client to authenticate against the Google Cloud API.
    /// </summary>
    [TerraformPropertyName("access_token")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessToken => new TerraformReference(this, "access_token");

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("default_labels")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> DefaultLabels => new TerraformReference(this, "default_labels");

    /// <summary>
    /// The ID of this ephemeral resource in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the ephemeral resource in requests to Google APIs.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    [TerraformPropertyName("project")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Project => new TerraformReference(this, "project");

    /// <summary>
    /// The region to operate under.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Region => new TerraformReference(this, "region");

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Zone => new TerraformReference(this, "zone");

}
