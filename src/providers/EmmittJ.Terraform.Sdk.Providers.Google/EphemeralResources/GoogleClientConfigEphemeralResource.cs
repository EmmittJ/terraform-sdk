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
    public TerraformProperty<TerraformProperty<string>> AccessToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_token");

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("default_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> DefaultLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "default_labels");

    /// <summary>
    /// The ID of this ephemeral resource in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the ephemeral resource in requests to Google APIs.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    [TerraformPropertyName("project")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Project => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The region to operate under.
    /// </summary>
    [TerraformPropertyName("region")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Region => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Zone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

}
