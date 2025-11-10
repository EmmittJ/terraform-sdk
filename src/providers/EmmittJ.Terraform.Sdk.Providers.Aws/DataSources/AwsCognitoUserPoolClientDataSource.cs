using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool_client.
/// </summary>
public class AwsCognitoUserPoolClientDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolClientDataSource(string name) : base("aws_cognito_user_pool_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_token_validity");
        SetOutput("allowed_oauth_flows");
        SetOutput("allowed_oauth_flows_user_pool_client");
        SetOutput("allowed_oauth_scopes");
        SetOutput("analytics_configuration");
        SetOutput("callback_urls");
        SetOutput("client_secret");
        SetOutput("default_redirect_uri");
        SetOutput("enable_propagate_additional_user_context_data");
        SetOutput("enable_token_revocation");
        SetOutput("explicit_auth_flows");
        SetOutput("generate_secret");
        SetOutput("id_token_validity");
        SetOutput("logout_urls");
        SetOutput("name");
        SetOutput("prevent_user_existence_errors");
        SetOutput("read_attributes");
        SetOutput("refresh_token_rotation");
        SetOutput("refresh_token_validity");
        SetOutput("supported_identity_providers");
        SetOutput("token_validity_units");
        SetOutput("write_attributes");
        SetOutput("client_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformExpression AccessTokenValidity => this["access_token_validity"];

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public TerraformExpression AllowedOauthFlows => this["allowed_oauth_flows"];

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformExpression AllowedOauthFlowsUserPoolClient => this["allowed_oauth_flows_user_pool_client"];

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public TerraformExpression AllowedOauthScopes => this["allowed_oauth_scopes"];

    /// <summary>
    /// The analytics_configuration attribute.
    /// </summary>
    public TerraformExpression AnalyticsConfiguration => this["analytics_configuration"];

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public TerraformExpression CallbackUrls => this["callback_urls"];

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformExpression ClientSecret => this["client_secret"];

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformExpression DefaultRedirectUri => this["default_redirect_uri"];

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformExpression EnablePropagateAdditionalUserContextData => this["enable_propagate_additional_user_context_data"];

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformExpression EnableTokenRevocation => this["enable_token_revocation"];

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public TerraformExpression ExplicitAuthFlows => this["explicit_auth_flows"];

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    public TerraformExpression GenerateSecret => this["generate_secret"];

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformExpression IdTokenValidity => this["id_token_validity"];

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public TerraformExpression LogoutUrls => this["logout_urls"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformExpression PreventUserExistenceErrors => this["prevent_user_existence_errors"];

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public TerraformExpression ReadAttributes => this["read_attributes"];

    /// <summary>
    /// The refresh_token_rotation attribute.
    /// </summary>
    public TerraformExpression RefreshTokenRotation => this["refresh_token_rotation"];

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformExpression RefreshTokenValidity => this["refresh_token_validity"];

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public TerraformExpression SupportedIdentityProviders => this["supported_identity_providers"];

    /// <summary>
    /// The token_validity_units attribute.
    /// </summary>
    public TerraformExpression TokenValidityUnits => this["token_validity_units"];

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public TerraformExpression WriteAttributes => this["write_attributes"];

}
