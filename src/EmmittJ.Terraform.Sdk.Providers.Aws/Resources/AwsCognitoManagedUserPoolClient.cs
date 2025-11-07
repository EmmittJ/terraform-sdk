using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("client_secret");
        this.DeclareOutput("id");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AccessTokenValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("access_token_validity");
        set => this.WithProperty("access_token_validity", value);
    }

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AllowedOauthFlows
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_oauth_flows");
        set => this.WithProperty("allowed_oauth_flows", value);
    }

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AllowedOauthFlowsUserPoolClient
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("allowed_oauth_flows_user_pool_client");
        set => this.WithProperty("allowed_oauth_flows_user_pool_client", value);
    }

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AllowedOauthScopes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_oauth_scopes");
        set => this.WithProperty("allowed_oauth_scopes", value);
    }

    /// <summary>
    /// The auth_session_validity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? AuthSessionValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("auth_session_validity");
        set => this.WithProperty("auth_session_validity", value);
    }

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CallbackUrls
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("callback_urls");
        set => this.WithProperty("callback_urls", value);
    }

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultRedirectUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_redirect_uri");
        set => this.WithProperty("default_redirect_uri", value);
    }

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnablePropagateAdditionalUserContextData
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_propagate_additional_user_context_data");
        set => this.WithProperty("enable_propagate_additional_user_context_data", value);
    }

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableTokenRevocation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_token_revocation");
        set => this.WithProperty("enable_token_revocation", value);
    }

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ExplicitAuthFlows
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("explicit_auth_flows");
        set => this.WithProperty("explicit_auth_flows", value);
    }

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? IdTokenValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("id_token_validity");
        set => this.WithProperty("id_token_validity", value);
    }

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LogoutUrls
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("logout_urls");
        set => this.WithProperty("logout_urls", value);
    }

    /// <summary>
    /// The name_pattern attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePattern
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_pattern");
        set => this.WithProperty("name_pattern", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NamePrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name_prefix");
        set => this.WithProperty("name_prefix", value);
    }

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PreventUserExistenceErrors
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prevent_user_existence_errors");
        set => this.WithProperty("prevent_user_existence_errors", value);
    }

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? ReadAttributes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("read_attributes");
        set => this.WithProperty("read_attributes", value);
    }

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RefreshTokenValidity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("refresh_token_validity");
        set => this.WithProperty("refresh_token_validity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SupportedIdentityProviders
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("supported_identity_providers");
        set => this.WithProperty("supported_identity_providers", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? WriteAttributes
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("write_attributes");
        set => this.WithProperty("write_attributes", value);
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
