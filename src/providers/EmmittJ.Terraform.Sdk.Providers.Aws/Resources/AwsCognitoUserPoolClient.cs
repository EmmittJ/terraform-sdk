using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for analytics_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolClientAnalyticsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformProperty("application_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationArn { get; set; }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [TerraformProperty("application_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApplicationId { get; set; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformProperty("external_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExternalId { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The user_data_shared attribute.
    /// </summary>
    [TerraformProperty("user_data_shared")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> UserDataShared { get; set; }

}

/// <summary>
/// Block type for refresh_token_rotation in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolClientRefreshTokenRotationBlock : TerraformBlockBase
{
    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    [TerraformProperty("feature")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Feature { get; set; }

    /// <summary>
    /// The retry_grace_period_seconds attribute.
    /// </summary>
    [TerraformProperty("retry_grace_period_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryGracePeriodSeconds { get; set; }

}

/// <summary>
/// Block type for token_validity_units in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolClientTokenValidityUnitsBlock : TerraformBlockBase
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    [TerraformProperty("access_token")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccessToken { get; set; }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    [TerraformProperty("id_token")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> IdToken { get; set; }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    [TerraformProperty("refresh_token")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> RefreshToken { get; set; }

}

/// <summary>
/// Manages a aws_cognito_user_pool_client resource.
/// </summary>
public partial class AwsCognitoUserPoolClient : TerraformResource
{
    public AwsCognitoUserPoolClient(string name) : base("aws_cognito_user_pool_client", name)
    {
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    [TerraformProperty("access_token_validity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AccessTokenValidity { get; set; }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    [TerraformProperty("allowed_oauth_flows")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> AllowedOauthFlows { get; set; }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    [TerraformProperty("allowed_oauth_flows_user_pool_client")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AllowedOauthFlowsUserPoolClient { get; set; }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    [TerraformProperty("allowed_oauth_scopes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> AllowedOauthScopes { get; set; }

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    [TerraformProperty("auth_session_validity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> AuthSessionValidity { get; set; }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    [TerraformProperty("callback_urls")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> CallbackUrls { get; set; }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    [TerraformProperty("default_redirect_uri")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DefaultRedirectUri { get; set; }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    [TerraformProperty("enable_propagate_additional_user_context_data")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnablePropagateAdditionalUserContextData { get; set; }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    [TerraformProperty("enable_token_revocation")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> EnableTokenRevocation { get; set; }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    [TerraformProperty("explicit_auth_flows")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ExplicitAuthFlows { get; set; }

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    [TerraformProperty("generate_secret")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? GenerateSecret { get; set; }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    [TerraformProperty("id_token_validity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> IdTokenValidity { get; set; }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    [TerraformProperty("logout_urls")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> LogoutUrls { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    [TerraformProperty("prevent_user_existence_errors")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PreventUserExistenceErrors { get; set; }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    [TerraformProperty("read_attributes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ReadAttributes { get; set; }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    [TerraformProperty("refresh_token_validity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> RefreshTokenValidity { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    [TerraformProperty("supported_identity_providers")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SupportedIdentityProviders { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    [TerraformProperty("write_attributes")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> WriteAttributes { get; set; }

    /// <summary>
    /// Block for analytics_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("analytics_configuration")]
    public partial TerraformList<TerraformBlock<AwsCognitoUserPoolClientAnalyticsConfigurationBlock>>? AnalyticsConfiguration { get; set; }

    /// <summary>
    /// Block for refresh_token_rotation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("refresh_token_rotation")]
    public partial TerraformList<TerraformBlock<AwsCognitoUserPoolClientRefreshTokenRotationBlock>>? RefreshTokenRotation { get; set; }

    /// <summary>
    /// Block for token_validity_units.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("token_validity_units")]
    public partial TerraformList<TerraformBlock<AwsCognitoUserPoolClientTokenValidityUnitsBlock>>? TokenValidityUnits { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [TerraformProperty("client_secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientSecret { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
