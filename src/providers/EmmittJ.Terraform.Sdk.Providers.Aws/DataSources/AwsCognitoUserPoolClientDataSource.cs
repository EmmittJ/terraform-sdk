using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool_client.
/// </summary>
public partial class AwsCognitoUserPoolClientDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolClientDataSource(string name) : base("aws_cognito_user_pool_client", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    [TerraformProperty("access_token_validity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> AccessTokenValidity { get; }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    [TerraformProperty("allowed_oauth_flows")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AllowedOauthFlows { get; }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    [TerraformProperty("allowed_oauth_flows_user_pool_client")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowedOauthFlowsUserPoolClient { get; }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    [TerraformProperty("allowed_oauth_scopes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> AllowedOauthScopes { get; }

    /// <summary>
    /// The analytics_configuration attribute.
    /// </summary>
    [TerraformProperty("analytics_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AnalyticsConfiguration { get; }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    [TerraformProperty("callback_urls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> CallbackUrls { get; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformProperty("client_secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ClientSecret { get; }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    [TerraformProperty("default_redirect_uri")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DefaultRedirectUri { get; }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    [TerraformProperty("enable_propagate_additional_user_context_data")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnablePropagateAdditionalUserContextData { get; }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    [TerraformProperty("enable_token_revocation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnableTokenRevocation { get; }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    [TerraformProperty("explicit_auth_flows")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ExplicitAuthFlows { get; }

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    [TerraformProperty("generate_secret")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> GenerateSecret { get; }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    [TerraformProperty("id_token_validity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> IdTokenValidity { get; }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    [TerraformProperty("logout_urls")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> LogoutUrls { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    [TerraformProperty("prevent_user_existence_errors")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreventUserExistenceErrors { get; }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    [TerraformProperty("read_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> ReadAttributes { get; }

    /// <summary>
    /// The refresh_token_rotation attribute.
    /// </summary>
    [TerraformProperty("refresh_token_rotation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RefreshTokenRotation { get; }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    [TerraformProperty("refresh_token_validity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RefreshTokenValidity { get; }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    [TerraformProperty("supported_identity_providers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SupportedIdentityProviders { get; }

    /// <summary>
    /// The token_validity_units attribute.
    /// </summary>
    [TerraformProperty("token_validity_units")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> TokenValidityUnits { get; }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    [TerraformProperty("write_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> WriteAttributes { get; }

}
