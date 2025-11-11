using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Use this ephemeral resource to access the configuration of the Google Cloud provider.
/// Ephemeral resources are used for temporary credentials, tokens, and secrets.
/// </summary>
public partial class GoogleClientConfigEphemeralResource : TerraformEphemeralResource
{
    public GoogleClientConfigEphemeralResource(string name) : base("google_client_config", name)
    {
    }

    /// <summary>
    /// The OAuth2 access token used by the client to authenticate against the Google Cloud API.
    /// </summary>
    [TerraformProperty("access_token")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AccessToken { get; }

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    [TerraformProperty("default_labels")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> DefaultLabels { get; }

    /// <summary>
    /// The ID of this ephemeral resource in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the ephemeral resource in requests to Google APIs.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    [TerraformProperty("project")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Project { get; }

    /// <summary>
    /// The region to operate under.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Region { get; }

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    [TerraformProperty("zone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Zone { get; }

}
