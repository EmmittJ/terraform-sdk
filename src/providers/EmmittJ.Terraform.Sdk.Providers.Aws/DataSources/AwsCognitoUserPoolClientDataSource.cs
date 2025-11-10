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
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("access_token_validity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AccessTokenValidity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "access_token_validity");

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedOauthFlows => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_oauth_flows");

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows_user_pool_client")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowedOauthFlowsUserPoolClient => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allowed_oauth_flows_user_pool_client");

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_scopes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedOauthScopes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_oauth_scopes");

    /// <summary>
    /// The analytics_configuration attribute.
    /// </summary>
    [TerraformPropertyName("analytics_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AnalyticsConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "analytics_configuration");

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    [TerraformPropertyName("callback_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> CallbackUrls => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "callback_urls");

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformPropertyName("client_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientSecret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_secret");

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DefaultRedirectUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_redirect_uri");

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    [TerraformPropertyName("enable_propagate_additional_user_context_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnablePropagateAdditionalUserContextData => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_propagate_additional_user_context_data");

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    [TerraformPropertyName("enable_token_revocation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnableTokenRevocation => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_token_revocation");

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    [TerraformPropertyName("explicit_auth_flows")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExplicitAuthFlows => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "explicit_auth_flows");

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    [TerraformPropertyName("generate_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> GenerateSecret => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "generate_secret");

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("id_token_validity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> IdTokenValidity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "id_token_validity");

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    [TerraformPropertyName("logout_urls")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> LogoutUrls => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "logout_urls");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    [TerraformPropertyName("prevent_user_existence_errors")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreventUserExistenceErrors => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "prevent_user_existence_errors");

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    [TerraformPropertyName("read_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ReadAttributes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "read_attributes");

    /// <summary>
    /// The refresh_token_rotation attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token_rotation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> RefreshTokenRotation => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "refresh_token_rotation");

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token_validity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> RefreshTokenValidity => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "refresh_token_validity");

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_identity_providers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedIdentityProviders => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_identity_providers");

    /// <summary>
    /// The token_validity_units attribute.
    /// </summary>
    [TerraformPropertyName("token_validity_units")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> TokenValidityUnits => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "token_validity_units");

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    [TerraformPropertyName("write_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> WriteAttributes => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "write_attributes");

}
