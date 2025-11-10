using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for analytics_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolClientAnalyticsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationArn
    {
        get => GetProperty<TerraformProperty<string>>("application_arn");
        set => WithProperty("application_arn", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => WithProperty("application_id", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalId
    {
        get => GetProperty<TerraformProperty<string>>("external_id");
        set => WithProperty("external_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => WithProperty("role_arn", value);
    }

    /// <summary>
    /// The user_data_shared attribute.
    /// </summary>
    public TerraformProperty<bool>? UserDataShared
    {
        get => GetProperty<TerraformProperty<bool>>("user_data_shared");
        set => WithProperty("user_data_shared", value);
    }

}

/// <summary>
/// Block type for refresh_token_rotation in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolClientRefreshTokenRotationBlock : TerraformBlock
{
    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformProperty<string> Feature
    {
        get => GetRequiredProperty<TerraformProperty<string>>("feature");
        set => WithProperty("feature", value);
    }

    /// <summary>
    /// The retry_grace_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RetryGracePeriodSeconds
    {
        get => GetProperty<TerraformProperty<double>>("retry_grace_period_seconds");
        set => WithProperty("retry_grace_period_seconds", value);
    }

}

/// <summary>
/// Block type for token_validity_units in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolClientTokenValidityUnitsBlock : TerraformBlock
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformProperty<string>? AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => WithProperty("access_token", value);
    }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    public TerraformProperty<string>? IdToken
    {
        get => GetProperty<TerraformProperty<string>>("id_token");
        set => WithProperty("id_token", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformProperty<string>? RefreshToken
    {
        get => GetProperty<TerraformProperty<string>>("refresh_token");
        set => WithProperty("refresh_token", value);
    }

}

/// <summary>
/// Manages a aws_cognito_user_pool_client resource.
/// </summary>
public class AwsCognitoUserPoolClient : TerraformResource
{
    public AwsCognitoUserPoolClient(string name) : base("aws_cognito_user_pool_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("client_secret");
        this.WithOutput("id");
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformProperty<double>? AccessTokenValidity
    {
        get => GetProperty<TerraformProperty<double>>("access_token_validity");
        set => this.WithProperty("access_token_validity", value);
    }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOauthFlows
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_oauth_flows");
        set => this.WithProperty("allowed_oauth_flows", value);
    }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowedOauthFlowsUserPoolClient
    {
        get => GetProperty<TerraformProperty<bool>>("allowed_oauth_flows_user_pool_client");
        set => this.WithProperty("allowed_oauth_flows_user_pool_client", value);
    }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOauthScopes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_oauth_scopes");
        set => this.WithProperty("allowed_oauth_scopes", value);
    }

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    public TerraformProperty<double>? AuthSessionValidity
    {
        get => GetProperty<TerraformProperty<double>>("auth_session_validity");
        set => this.WithProperty("auth_session_validity", value);
    }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CallbackUrls
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("callback_urls");
        set => this.WithProperty("callback_urls", value);
    }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultRedirectUri
    {
        get => GetProperty<TerraformProperty<string>>("default_redirect_uri");
        set => this.WithProperty("default_redirect_uri", value);
    }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePropagateAdditionalUserContextData
    {
        get => GetProperty<TerraformProperty<bool>>("enable_propagate_additional_user_context_data");
        set => this.WithProperty("enable_propagate_additional_user_context_data", value);
    }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableTokenRevocation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_token_revocation");
        set => this.WithProperty("enable_token_revocation", value);
    }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ExplicitAuthFlows
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("explicit_auth_flows");
        set => this.WithProperty("explicit_auth_flows", value);
    }

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    public TerraformProperty<bool>? GenerateSecret
    {
        get => GetProperty<TerraformProperty<bool>>("generate_secret");
        set => this.WithProperty("generate_secret", value);
    }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformProperty<double>? IdTokenValidity
    {
        get => GetProperty<TerraformProperty<double>>("id_token_validity");
        set => this.WithProperty("id_token_validity", value);
    }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? LogoutUrls
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("logout_urls");
        set => this.WithProperty("logout_urls", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformProperty<string>? PreventUserExistenceErrors
    {
        get => GetProperty<TerraformProperty<string>>("prevent_user_existence_errors");
        set => this.WithProperty("prevent_user_existence_errors", value);
    }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ReadAttributes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("read_attributes");
        set => this.WithProperty("read_attributes", value);
    }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformProperty<double>? RefreshTokenValidity
    {
        get => GetProperty<TerraformProperty<double>>("refresh_token_validity");
        set => this.WithProperty("refresh_token_validity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SupportedIdentityProviders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("supported_identity_providers");
        set => this.WithProperty("supported_identity_providers", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? WriteAttributes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("write_attributes");
        set => this.WithProperty("write_attributes", value);
    }

    /// <summary>
    /// Block for analytics_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoUserPoolClientAnalyticsConfigurationBlock>? AnalyticsConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolClientAnalyticsConfigurationBlock>>("analytics_configuration");
        set => this.WithProperty("analytics_configuration", value);
    }

    /// <summary>
    /// Block for refresh_token_rotation.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoUserPoolClientRefreshTokenRotationBlock>? RefreshTokenRotation
    {
        get => GetProperty<List<AwsCognitoUserPoolClientRefreshTokenRotationBlock>>("refresh_token_rotation");
        set => this.WithProperty("refresh_token_rotation", value);
    }

    /// <summary>
    /// Block for token_validity_units.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoUserPoolClientTokenValidityUnitsBlock>? TokenValidityUnits
    {
        get => GetProperty<List<AwsCognitoUserPoolClientTokenValidityUnitsBlock>>("token_validity_units");
        set => this.WithProperty("token_validity_units", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformExpression ClientSecret => this["client_secret"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
