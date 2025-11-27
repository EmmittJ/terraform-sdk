using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for analytics_configuration in AwsCognitoManagedUserPoolClient.
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "analytics_configuration";

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationArn
    {
        get => new TerraformReference<string>(this, "application_arn");
        set => SetArgument("application_arn", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformValue<string>? ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    public TerraformValue<string>? ExternalId
    {
        get => new TerraformReference<string>(this, "external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The user_data_shared attribute.
    /// </summary>
    public TerraformValue<bool> UserDataShared
    {
        get => new TerraformReference<bool>(this, "user_data_shared");
        set => SetArgument("user_data_shared", value);
    }

}


/// <summary>
/// Block type for refresh_token_rotation in AwsCognitoManagedUserPoolClient.
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "refresh_token_rotation";

    /// <summary>
    /// The feature attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Feature is required")]
    public required TerraformValue<string> Feature
    {
        get => new TerraformReference<string>(this, "feature");
        set => SetArgument("feature", value);
    }

    /// <summary>
    /// The retry_grace_period_seconds attribute.
    /// </summary>
    public TerraformValue<double>? RetryGracePeriodSeconds
    {
        get => new TerraformReference<double>(this, "retry_grace_period_seconds");
        set => SetArgument("retry_grace_period_seconds", value);
    }

}


/// <summary>
/// Block type for token_validity_units in AwsCognitoManagedUserPoolClient.
/// Nesting mode: list
/// </summary>
public class AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "token_validity_units";

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string> AccessToken
    {
        get => new TerraformReference<string>(this, "access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The id_token attribute.
    /// </summary>
    public TerraformValue<string> IdToken
    {
        get => new TerraformReference<string>(this, "id_token");
        set => SetArgument("id_token", value);
    }

    /// <summary>
    /// The refresh_token attribute.
    /// </summary>
    public TerraformValue<string> RefreshToken
    {
        get => new TerraformReference<string>(this, "refresh_token");
        set => SetArgument("refresh_token", value);
    }

}


/// <summary>
/// Represents a aws_cognito_managed_user_pool_client Terraform resource.
/// Manages a aws_cognito_managed_user_pool_client resource.
/// </summary>
public partial class AwsCognitoManagedUserPoolClient(string name) : TerraformResource("aws_cognito_managed_user_pool_client", name)
{
    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformValue<double> AccessTokenValidity
    {
        get => new TerraformReference<double>(this, "access_token_validity");
        set => SetArgument("access_token_validity", value);
    }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public TerraformSet<string> AllowedOauthFlows
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_oauth_flows").ResolveNodes(ctx));
        set => SetArgument("allowed_oauth_flows", value);
    }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformValue<bool> AllowedOauthFlowsUserPoolClient
    {
        get => new TerraformReference<bool>(this, "allowed_oauth_flows_user_pool_client");
        set => SetArgument("allowed_oauth_flows_user_pool_client", value);
    }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public TerraformSet<string> AllowedOauthScopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_oauth_scopes").ResolveNodes(ctx));
        set => SetArgument("allowed_oauth_scopes", value);
    }

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    public TerraformValue<double> AuthSessionValidity
    {
        get => new TerraformReference<double>(this, "auth_session_validity");
        set => SetArgument("auth_session_validity", value);
    }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public TerraformSet<string> CallbackUrls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "callback_urls").ResolveNodes(ctx));
        set => SetArgument("callback_urls", value);
    }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformValue<string> DefaultRedirectUri
    {
        get => new TerraformReference<string>(this, "default_redirect_uri");
        set => SetArgument("default_redirect_uri", value);
    }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformValue<bool> EnablePropagateAdditionalUserContextData
    {
        get => new TerraformReference<bool>(this, "enable_propagate_additional_user_context_data");
        set => SetArgument("enable_propagate_additional_user_context_data", value);
    }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformValue<bool> EnableTokenRevocation
    {
        get => new TerraformReference<bool>(this, "enable_token_revocation");
        set => SetArgument("enable_token_revocation", value);
    }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public TerraformSet<string> ExplicitAuthFlows
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "explicit_auth_flows").ResolveNodes(ctx));
        set => SetArgument("explicit_auth_flows", value);
    }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformValue<double> IdTokenValidity
    {
        get => new TerraformReference<double>(this, "id_token_validity");
        set => SetArgument("id_token_validity", value);
    }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public TerraformSet<string> LogoutUrls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "logout_urls").ResolveNodes(ctx));
        set => SetArgument("logout_urls", value);
    }

    /// <summary>
    /// The name_pattern attribute.
    /// </summary>
    public TerraformValue<string>? NamePattern
    {
        get => new TerraformReference<string>(this, "name_pattern");
        set => SetArgument("name_pattern", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
    }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformValue<string> PreventUserExistenceErrors
    {
        get => new TerraformReference<string>(this, "prevent_user_existence_errors");
        set => SetArgument("prevent_user_existence_errors", value);
    }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public TerraformSet<string> ReadAttributes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "read_attributes").ResolveNodes(ctx));
        set => SetArgument("read_attributes", value);
    }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformValue<double> RefreshTokenValidity
    {
        get => new TerraformReference<double>(this, "refresh_token_validity");
        set => SetArgument("refresh_token_validity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public TerraformSet<string> SupportedIdentityProviders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_identity_providers").ResolveNodes(ctx));
        set => SetArgument("supported_identity_providers", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public TerraformSet<string> WriteAttributes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "write_attributes").ResolveNodes(ctx));
        set => SetArgument("write_attributes", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// AnalyticsConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock>? AnalyticsConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoManagedUserPoolClientAnalyticsConfigurationBlock>>("analytics_configuration");
        set => SetArgument("analytics_configuration", value);
    }

    /// <summary>
    /// RefreshTokenRotation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock>? RefreshTokenRotation
    {
        get => GetArgument<TerraformList<AwsCognitoManagedUserPoolClientRefreshTokenRotationBlock>>("refresh_token_rotation");
        set => SetArgument("refresh_token_rotation", value);
    }

    /// <summary>
    /// TokenValidityUnits block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock>? TokenValidityUnits
    {
        get => GetArgument<TerraformList<AwsCognitoManagedUserPoolClientTokenValidityUnitsBlock>>("token_validity_units");
        set => SetArgument("token_validity_units", value);
    }

}
