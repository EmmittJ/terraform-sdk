using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("client_secret");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public double? AccessTokenValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("access_token_validity")?.Value;
        set => this.WithProperty("access_token_validity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public HashSet<string>? AllowedOauthFlows
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_oauth_flows")?.Value;
        set => this.WithProperty("allowed_oauth_flows", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public bool? AllowedOauthFlowsUserPoolClient
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allowed_oauth_flows_user_pool_client")?.Value;
        set => this.WithProperty("allowed_oauth_flows_user_pool_client", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public HashSet<string>? AllowedOauthScopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_oauth_scopes")?.Value;
        set => this.WithProperty("allowed_oauth_scopes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    public double? AuthSessionValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("auth_session_validity")?.Value;
        set => this.WithProperty("auth_session_validity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public HashSet<string>? CallbackUrls
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("callback_urls")?.Value;
        set => this.WithProperty("callback_urls", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public string? DefaultRedirectUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_redirect_uri")?.Value;
        set => this.WithProperty("default_redirect_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public bool? EnablePropagateAdditionalUserContextData
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_propagate_additional_user_context_data")?.Value;
        set => this.WithProperty("enable_propagate_additional_user_context_data", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public bool? EnableTokenRevocation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_token_revocation")?.Value;
        set => this.WithProperty("enable_token_revocation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public HashSet<string>? ExplicitAuthFlows
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("explicit_auth_flows")?.Value;
        set => this.WithProperty("explicit_auth_flows", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    public bool? GenerateSecret
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("generate_secret")?.Value;
        set => this.WithProperty("generate_secret", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public double? IdTokenValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("id_token_validity")?.Value;
        set => this.WithProperty("id_token_validity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public HashSet<string>? LogoutUrls
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("logout_urls")?.Value;
        set => this.WithProperty("logout_urls", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public string? PreventUserExistenceErrors
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prevent_user_existence_errors")?.Value;
        set => this.WithProperty("prevent_user_existence_errors", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public HashSet<string>? ReadAttributes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("read_attributes")?.Value;
        set => this.WithProperty("read_attributes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public double? RefreshTokenValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("refresh_token_validity")?.Value;
        set => this.WithProperty("refresh_token_validity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public HashSet<string>? SupportedIdentityProviders
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_identity_providers")?.Value;
        set => this.WithProperty("supported_identity_providers", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public string? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id")?.Value;
        set => this.WithProperty("user_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public HashSet<string>? WriteAttributes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("write_attributes")?.Value;
        set => this.WithProperty("write_attributes", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
