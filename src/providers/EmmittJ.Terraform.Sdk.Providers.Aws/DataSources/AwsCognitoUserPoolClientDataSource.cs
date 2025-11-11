using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool_client.
/// </summary>
public class AwsCognitoUserPoolClientDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolClientDataSource(string name) : base("aws_cognito_user_pool_client", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("access_token_validity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AccessTokenValidity => new TerraformReference(this, "access_token_validity");

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AllowedOauthFlows => new TerraformReference(this, "allowed_oauth_flows");

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows_user_pool_client")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> AllowedOauthFlowsUserPoolClient => new TerraformReference(this, "allowed_oauth_flows_user_pool_client");

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_scopes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> AllowedOauthScopes => new TerraformReference(this, "allowed_oauth_scopes");

    /// <summary>
    /// The analytics_configuration attribute.
    /// </summary>
    [TerraformPropertyName("analytics_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AnalyticsConfiguration => new TerraformReference(this, "analytics_configuration");

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    [TerraformPropertyName("callback_urls")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> CallbackUrls => new TerraformReference(this, "callback_urls");

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformPropertyName("client_secret")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientSecret => new TerraformReference(this, "client_secret");

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DefaultRedirectUri => new TerraformReference(this, "default_redirect_uri");

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    [TerraformPropertyName("enable_propagate_additional_user_context_data")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnablePropagateAdditionalUserContextData => new TerraformReference(this, "enable_propagate_additional_user_context_data");

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    [TerraformPropertyName("enable_token_revocation")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnableTokenRevocation => new TerraformReference(this, "enable_token_revocation");

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    [TerraformPropertyName("explicit_auth_flows")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ExplicitAuthFlows => new TerraformReference(this, "explicit_auth_flows");

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    [TerraformPropertyName("generate_secret")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> GenerateSecret => new TerraformReference(this, "generate_secret");

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("id_token_validity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> IdTokenValidity => new TerraformReference(this, "id_token_validity");

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    [TerraformPropertyName("logout_urls")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> LogoutUrls => new TerraformReference(this, "logout_urls");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    [TerraformPropertyName("prevent_user_existence_errors")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreventUserExistenceErrors => new TerraformReference(this, "prevent_user_existence_errors");

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    [TerraformPropertyName("read_attributes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ReadAttributes => new TerraformReference(this, "read_attributes");

    /// <summary>
    /// The refresh_token_rotation attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token_rotation")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RefreshTokenRotation => new TerraformReference(this, "refresh_token_rotation");

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token_validity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RefreshTokenValidity => new TerraformReference(this, "refresh_token_validity");

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_identity_providers")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SupportedIdentityProviders => new TerraformReference(this, "supported_identity_providers");

    /// <summary>
    /// The token_validity_units attribute.
    /// </summary>
    [TerraformPropertyName("token_validity_units")]
    // Output-only attribute - read-only reference
    public TerraformList<object> TokenValidityUnits => new TerraformReference(this, "token_validity_units");

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    [TerraformPropertyName("write_attributes")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> WriteAttributes => new TerraformReference(this, "write_attributes");

}
