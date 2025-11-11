using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for analytics_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplicationArn { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformPropertyName("application_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ApplicationId { get; set; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformPropertyName("external_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExternalId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RoleArn { get; set; } = default!;

    /// <summary>
    /// The user_data_shared attribute.
    /// </summary>
    [TerraformPropertyName("user_data_shared")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> UserDataShared { get; set; } = default!;

}

/// <summary>
/// Block type for refresh_token_rotation in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock
{
    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    [TerraformPropertyName("feature")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Feature { get; set; }

    /// <summary>
    /// The retry_grace_period_seconds attribute.
    /// </summary>
    [TerraformPropertyName("retry_grace_period_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? RetryGracePeriodSeconds { get; set; }

}

/// <summary>
/// Block type for token_validity_units in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformPropertyName("access_token")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccessToken { get; set; } = default!;

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    [TerraformPropertyName("id_token")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> IdToken { get; set; } = default!;

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> RefreshToken { get; set; } = default!;

}

/// <summary>
/// Manages a aws_cognito_managed_user_pool_client resource.
/// </summary>
public class AwsCognitoManagedUserPoolClient : TerraformResource
{
    public AwsCognitoManagedUserPoolClient(string name) : base("aws_cognito_managed_user_pool_client", name)
    {
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("access_token_validity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AccessTokenValidity { get; set; } = default!;

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AllowedOauthFlows { get; set; } = default!;

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows_user_pool_client")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> AllowedOauthFlowsUserPoolClient { get; set; } = default!;

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_scopes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> AllowedOauthScopes { get; set; } = default!;

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    [TerraformPropertyName("auth_session_validity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> AuthSessionValidity { get; set; } = default!;

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    [TerraformPropertyName("callback_urls")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> CallbackUrls { get; set; } = default!;

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_uri")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> DefaultRedirectUri { get; set; } = default!;

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    [TerraformPropertyName("enable_propagate_additional_user_context_data")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnablePropagateAdditionalUserContextData { get; set; } = default!;

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    [TerraformPropertyName("enable_token_revocation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> EnableTokenRevocation { get; set; } = default!;

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    [TerraformPropertyName("explicit_auth_flows")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> ExplicitAuthFlows { get; set; } = default!;

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("id_token_validity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> IdTokenValidity { get; set; } = default!;

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    [TerraformPropertyName("logout_urls")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> LogoutUrls { get; set; } = default!;

    /// <summary>
    /// The name_pattern attribute.
    /// </summary>
    [TerraformPropertyName("name_pattern")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamePattern { get; set; }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    [TerraformPropertyName("name_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? NamePrefix { get; set; }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    [TerraformPropertyName("prevent_user_existence_errors")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreventUserExistenceErrors { get; set; } = default!;

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    [TerraformPropertyName("read_attributes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> ReadAttributes { get; set; } = default!;

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token_validity")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> RefreshTokenValidity { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_identity_providers")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> SupportedIdentityProviders { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    [TerraformPropertyName("write_attributes")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> WriteAttributes { get; set; } = default!;

    /// <summary>
    /// Block for analytics_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("analytics_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock>>? AnalyticsConfiguration { get; set; }

    /// <summary>
    /// Block for refresh_token_rotation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("refresh_token_rotation")]
    public TerraformList<TerraformBlock<AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock>>? RefreshTokenRotation { get; set; }

    /// <summary>
    /// Block for token_validity_units.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("token_validity_units")]
    public TerraformList<TerraformBlock<AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock>>? TokenValidityUnits { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformPropertyName("client_secret")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientSecret => new TerraformReference(this, "client_secret");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}
