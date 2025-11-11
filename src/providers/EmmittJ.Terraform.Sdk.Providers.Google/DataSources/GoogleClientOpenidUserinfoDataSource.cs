using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Get OpenID userinfo about the credentials used with the Google provider, specifically the email.
    /// This datasource enables you to export the email of the account you&#39;ve authenticated the provider with; this can be used alongside data.google_client_config&#39;s access_token to perform OpenID Connect authentication with GKE and configure an RBAC role for the email used.
    /// 
    /// ~&amp;gt; This resource will only work as expected if the provider is configured to use the https://www.googleapis.com/auth/userinfo.email scope! You will receive an error otherwise. The provider uses this scope by default.
/// </summary>
public class GoogleClientOpenidUserinfoDataSource : TerraformDataSource
{
    public GoogleClientOpenidUserinfoDataSource(string name) : base("google_client_openid_userinfo", name)
    {
    }

    /// <summary>
    /// The email of the account used by the provider to authenticate with GCP.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Email => new TerraformReference(this, "email");

    /// <summary>
    /// The ID of this data source in Terraform state. Its value is the same as the `email` attribute. Do not use this field, use the `email` attribute instead.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
