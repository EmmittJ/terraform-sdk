using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for analytics_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolClientAnalyticsConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationArn { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformPropertyName("application_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ApplicationId { get; set; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformPropertyName("external_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExternalId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RoleArn { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "role_arn");

    /// <summary>
    /// The user_data_shared attribute.
    /// </summary>
    [TerraformPropertyName("user_data_shared")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> UserDataShared { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>("", "user_data_shared");

}

/// <summary>
/// Block type for refresh_token_rotation in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolClientRefreshTokenRotationBlock : ITerraformBlock
{
    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    [TerraformPropertyName("feature")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Feature { get; set; }

    /// <summary>
    /// The retry_grace_period_seconds attribute.
    /// </summary>
    [TerraformPropertyName("retry_grace_period_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetryGracePeriodSeconds { get; set; }

}

/// <summary>
/// Block type for token_validity_units in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolClientTokenValidityUnitsBlock : ITerraformBlock
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformPropertyName("access_token")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccessToken { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "access_token");

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    [TerraformPropertyName("id_token")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IdToken { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "id_token");

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> RefreshToken { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "refresh_token");

}

/// <summary>
/// Manages a aws_cognito_user_pool_client resource.
/// </summary>
public class AwsCognitoUserPoolClient : TerraformResource
{
    public AwsCognitoUserPoolClient(string name) : base("aws_cognito_user_pool_client", name)
    {
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("access_token_validity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AccessTokenValidity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "access_token_validity");

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedOauthFlows { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_oauth_flows");

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_flows_user_pool_client")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> AllowedOauthFlowsUserPoolClient { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allowed_oauth_flows_user_pool_client");

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    [TerraformPropertyName("allowed_oauth_scopes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> AllowedOauthScopes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "allowed_oauth_scopes");

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    [TerraformPropertyName("auth_session_validity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> AuthSessionValidity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "auth_session_validity");

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    [TerraformPropertyName("callback_urls")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> CallbackUrls { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "callback_urls");

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    [TerraformPropertyName("default_redirect_uri")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DefaultRedirectUri { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "default_redirect_uri");

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    [TerraformPropertyName("enable_propagate_additional_user_context_data")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnablePropagateAdditionalUserContextData { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_propagate_additional_user_context_data");

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    [TerraformPropertyName("enable_token_revocation")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> EnableTokenRevocation { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enable_token_revocation");

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    [TerraformPropertyName("explicit_auth_flows")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ExplicitAuthFlows { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "explicit_auth_flows");

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    [TerraformPropertyName("generate_secret")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? GenerateSecret { get; set; }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("id_token_validity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> IdTokenValidity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "id_token_validity");

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    [TerraformPropertyName("logout_urls")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> LogoutUrls { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "logout_urls");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    [TerraformPropertyName("prevent_user_existence_errors")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PreventUserExistenceErrors { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "prevent_user_existence_errors");

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    [TerraformPropertyName("read_attributes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ReadAttributes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "read_attributes");

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    [TerraformPropertyName("refresh_token_validity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> RefreshTokenValidity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "refresh_token_validity");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    [TerraformPropertyName("supported_identity_providers")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SupportedIdentityProviders { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "supported_identity_providers");

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    [TerraformPropertyName("write_attributes")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> WriteAttributes { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "write_attributes");

    /// <summary>
    /// Block for analytics_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("analytics_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolClientAnalyticsConfigurationBlock>>? AnalyticsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for refresh_token_rotation.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("refresh_token_rotation")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolClientRefreshTokenRotationBlock>>? RefreshTokenRotation { get; set; } = new();

    /// <summary>
    /// Block for token_validity_units.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("token_validity_units")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolClientTokenValidityUnitsBlock>>? TokenValidityUnits { get; set; } = new();

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformPropertyName("client_secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientSecret => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_secret");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
