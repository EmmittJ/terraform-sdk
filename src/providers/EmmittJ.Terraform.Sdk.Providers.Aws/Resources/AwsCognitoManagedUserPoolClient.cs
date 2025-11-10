using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for analytics_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationArn
    {
        set => SetProperty("application_arn", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformProperty<string>? ApplicationId
    {
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformProperty<string>? ExternalId
    {
        set => SetProperty("external_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The user_data_shared attribute.
    /// </summary>
    public TerraformProperty<bool>? UserDataShared
    {
        set => SetProperty("user_data_shared", value);
    }

}

/// <summary>
/// Block type for refresh_token_rotation in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock : TerraformBlock
{
    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformProperty<string> Feature
    {
        set => SetProperty("feature", value);
    }

    /// <summary>
    /// The retry_grace_period_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RetryGracePeriodSeconds
    {
        set => SetProperty("retry_grace_period_seconds", value);
    }

}

/// <summary>
/// Block type for token_validity_units in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock : TerraformBlock
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformProperty<string>? AccessToken
    {
        set => SetProperty("access_token", value);
    }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    public TerraformProperty<string>? IdToken
    {
        set => SetProperty("id_token", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformProperty<string>? RefreshToken
    {
        set => SetProperty("refresh_token", value);
    }

}

/// <summary>
/// Manages a aws_cognito_managed_user_pool_client resource.
/// </summary>
public class AwsCognitoManagedUserPoolClient : TerraformResource
{
    public AwsCognitoManagedUserPoolClient(string name) : base("aws_cognito_managed_user_pool_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("client_secret");
        SetOutput("id");
        SetOutput("name");
        SetOutput("access_token_validity");
        SetOutput("allowed_oauth_flows");
        SetOutput("allowed_oauth_flows_user_pool_client");
        SetOutput("allowed_oauth_scopes");
        SetOutput("auth_session_validity");
        SetOutput("callback_urls");
        SetOutput("default_redirect_uri");
        SetOutput("enable_propagate_additional_user_context_data");
        SetOutput("enable_token_revocation");
        SetOutput("explicit_auth_flows");
        SetOutput("id_token_validity");
        SetOutput("logout_urls");
        SetOutput("name_pattern");
        SetOutput("name_prefix");
        SetOutput("prevent_user_existence_errors");
        SetOutput("read_attributes");
        SetOutput("refresh_token_validity");
        SetOutput("region");
        SetOutput("supported_identity_providers");
        SetOutput("user_pool_id");
        SetOutput("write_attributes");
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformProperty<double> AccessTokenValidity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("access_token_validity");
        set => SetProperty("access_token_validity", value);
    }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedOauthFlows
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_oauth_flows");
        set => SetProperty("allowed_oauth_flows", value);
    }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformProperty<bool> AllowedOauthFlowsUserPoolClient
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("allowed_oauth_flows_user_pool_client");
        set => SetProperty("allowed_oauth_flows_user_pool_client", value);
    }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AllowedOauthScopes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("allowed_oauth_scopes");
        set => SetProperty("allowed_oauth_scopes", value);
    }

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    public TerraformProperty<double> AuthSessionValidity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("auth_session_validity");
        set => SetProperty("auth_session_validity", value);
    }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CallbackUrls
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("callback_urls");
        set => SetProperty("callback_urls", value);
    }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformProperty<string> DefaultRedirectUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_redirect_uri");
        set => SetProperty("default_redirect_uri", value);
    }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformProperty<bool> EnablePropagateAdditionalUserContextData
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_propagate_additional_user_context_data");
        set => SetProperty("enable_propagate_additional_user_context_data", value);
    }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformProperty<bool> EnableTokenRevocation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_token_revocation");
        set => SetProperty("enable_token_revocation", value);
    }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ExplicitAuthFlows
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("explicit_auth_flows");
        set => SetProperty("explicit_auth_flows", value);
    }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformProperty<double> IdTokenValidity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("id_token_validity");
        set => SetProperty("id_token_validity", value);
    }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> LogoutUrls
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("logout_urls");
        set => SetProperty("logout_urls", value);
    }

    /// <summary>
    /// The name_pattern attribute.
    /// </summary>
    public TerraformProperty<string> NamePattern
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_pattern");
        set => SetProperty("name_pattern", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformProperty<string> NamePrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name_prefix");
        set => SetProperty("name_prefix", value);
    }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformProperty<string> PreventUserExistenceErrors
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prevent_user_existence_errors");
        set => SetProperty("prevent_user_existence_errors", value);
    }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ReadAttributes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("read_attributes");
        set => SetProperty("read_attributes", value);
    }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformProperty<double> RefreshTokenValidity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("refresh_token_validity");
        set => SetProperty("refresh_token_validity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SupportedIdentityProviders
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("supported_identity_providers");
        set => SetProperty("supported_identity_providers", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> WriteAttributes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("write_attributes");
        set => SetProperty("write_attributes", value);
    }

    /// <summary>
    /// Block for analytics_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock>? AnalyticsConfiguration
    {
        set => SetProperty("analytics_configuration", value);
    }

    /// <summary>
    /// Block for refresh_token_rotation.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock>? RefreshTokenRotation
    {
        set => SetProperty("refresh_token_rotation", value);
    }

    /// <summary>
    /// Block for token_validity_units.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock>? TokenValidityUnits
    {
        set => SetProperty("token_validity_units", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformExpression ClientSecret => this["client_secret"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
