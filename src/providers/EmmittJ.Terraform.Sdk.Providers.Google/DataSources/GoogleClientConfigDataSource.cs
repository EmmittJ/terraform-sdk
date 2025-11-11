using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Use this data source to access the configuration of the Google Cloud provider.
/// </summary>
public partial class GoogleClientConfigDataSource : TerraformDataSource
{
    public GoogleClientConfigDataSource(string name) : base("google_client_config", name)
    {
    }

    /// <summary>
    /// The OAuth2 access token used by the client to authenticate against the Google Cloud API.
    /// </summary>
    [TerraformProperty("access_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessToken { get; }

    /// <summary>
    /// The default labels configured on the provider.
    /// </summary>
    [TerraformProperty("default_labels")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> DefaultLabels { get; }

    /// <summary>
    /// The ID of this data source in Terraform state. It is created in a projects/{{project}}/regions/{{region}}/zones/{{zone}} format and is NOT used by the data source in requests to Google APIs.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The ID of the project to apply any resources to.
    /// </summary>
    [TerraformProperty("project")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Project { get; }

    /// <summary>
    /// The region to operate under.
    /// </summary>
    [TerraformProperty("region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Region { get; }

    /// <summary>
    /// The zone to operate under.
    /// </summary>
    [TerraformProperty("zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Zone { get; }

}
