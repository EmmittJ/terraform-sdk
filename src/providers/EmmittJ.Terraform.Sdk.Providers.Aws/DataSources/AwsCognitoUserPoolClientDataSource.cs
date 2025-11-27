using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_user_pool_client Terraform data source.
/// Retrieves information about a aws_cognito_user_pool_client.
/// </summary>
public partial class AwsCognitoUserPoolClientDataSource(string name) : TerraformDataSource("aws_cognito_user_pool_client", name)
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformValue<double> AccessTokenValidity
    {
        get => new TerraformReference<double>(this, "access_token_validity");
    }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public TerraformSet<string> AllowedOauthFlows
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_oauth_flows").ResolveNodes(ctx));
    }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformValue<bool> AllowedOauthFlowsUserPoolClient
    {
        get => new TerraformReference<bool>(this, "allowed_oauth_flows_user_pool_client");
    }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public TerraformSet<string> AllowedOauthScopes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_oauth_scopes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The analytics_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AnalyticsConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "analytics_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public TerraformSet<string> CallbackUrls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "callback_urls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
    }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformValue<string> DefaultRedirectUri
    {
        get => new TerraformReference<string>(this, "default_redirect_uri");
    }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformValue<bool> EnablePropagateAdditionalUserContextData
    {
        get => new TerraformReference<bool>(this, "enable_propagate_additional_user_context_data");
    }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformValue<bool> EnableTokenRevocation
    {
        get => new TerraformReference<bool>(this, "enable_token_revocation");
    }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public TerraformSet<string> ExplicitAuthFlows
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "explicit_auth_flows").ResolveNodes(ctx));
    }

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    public TerraformValue<bool> GenerateSecret
    {
        get => new TerraformReference<bool>(this, "generate_secret");
    }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformValue<double> IdTokenValidity
    {
        get => new TerraformReference<double>(this, "id_token_validity");
    }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public TerraformSet<string> LogoutUrls
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "logout_urls").ResolveNodes(ctx));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformValue<string> PreventUserExistenceErrors
    {
        get => new TerraformReference<string>(this, "prevent_user_existence_errors");
    }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public TerraformSet<string> ReadAttributes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "read_attributes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The refresh_token_rotation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RefreshTokenRotation
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "refresh_token_rotation").ResolveNodes(ctx));
    }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformValue<double> RefreshTokenValidity
    {
        get => new TerraformReference<double>(this, "refresh_token_validity");
    }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public TerraformSet<string> SupportedIdentityProviders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "supported_identity_providers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The token_validity_units attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TokenValidityUnits
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "token_validity_units").ResolveNodes(ctx));
    }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public TerraformSet<string> WriteAttributes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "write_attributes").ResolveNodes(ctx));
    }

}
