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
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The access_token_validity attribute.
    /// </summary>
    public TerraformValue<double> AccessTokenValidity
        => CreateReference("access_token_validity");

    /// <summary>
    /// The allowed_oauth_flows attribute.
    /// </summary>
    public TerraformSet<string> AllowedOauthFlows
        => CreateReference("allowed_oauth_flows");

    /// <summary>
    /// The allowed_oauth_flows_user_pool_client attribute.
    /// </summary>
    public TerraformValue<bool> AllowedOauthFlowsUserPoolClient
        => CreateReference("allowed_oauth_flows_user_pool_client");

    /// <summary>
    /// The allowed_oauth_scopes attribute.
    /// </summary>
    public TerraformSet<string> AllowedOauthScopes
        => CreateReference("allowed_oauth_scopes");

    /// <summary>
    /// The analytics_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AnalyticsConfiguration
        => CreateReference("analytics_configuration");

    /// <summary>
    /// The callback_urls attribute.
    /// </summary>
    public TerraformSet<string> CallbackUrls
        => CreateReference("callback_urls");

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformValue<string> ClientSecret
        => CreateReference("client_secret");

    /// <summary>
    /// The default_redirect_uri attribute.
    /// </summary>
    public TerraformValue<string> DefaultRedirectUri
        => CreateReference("default_redirect_uri");

    /// <summary>
    /// The enable_propagate_additional_user_context_data attribute.
    /// </summary>
    public TerraformValue<bool> EnablePropagateAdditionalUserContextData
        => CreateReference("enable_propagate_additional_user_context_data");

    /// <summary>
    /// The enable_token_revocation attribute.
    /// </summary>
    public TerraformValue<bool> EnableTokenRevocation
        => CreateReference("enable_token_revocation");

    /// <summary>
    /// The explicit_auth_flows attribute.
    /// </summary>
    public TerraformSet<string> ExplicitAuthFlows
        => CreateReference("explicit_auth_flows");

    /// <summary>
    /// The generate_secret attribute.
    /// </summary>
    public TerraformValue<bool> GenerateSecret
        => CreateReference("generate_secret");

    /// <summary>
    /// The id_token_validity attribute.
    /// </summary>
    public TerraformValue<double> IdTokenValidity
        => CreateReference("id_token_validity");

    /// <summary>
    /// The logout_urls attribute.
    /// </summary>
    public TerraformSet<string> LogoutUrls
        => CreateReference("logout_urls");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The prevent_user_existence_errors attribute.
    /// </summary>
    public TerraformValue<string> PreventUserExistenceErrors
        => CreateReference("prevent_user_existence_errors");

    /// <summary>
    /// The read_attributes attribute.
    /// </summary>
    public TerraformSet<string> ReadAttributes
        => CreateReference("read_attributes");

    /// <summary>
    /// The refresh_token_rotation attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RefreshTokenRotation
        => CreateReference("refresh_token_rotation");

    /// <summary>
    /// The refresh_token_validity attribute.
    /// </summary>
    public TerraformValue<double> RefreshTokenValidity
        => CreateReference("refresh_token_validity");

    /// <summary>
    /// The supported_identity_providers attribute.
    /// </summary>
    public TerraformSet<string> SupportedIdentityProviders
        => CreateReference("supported_identity_providers");

    /// <summary>
    /// The token_validity_units attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> TokenValidityUnits
        => CreateReference("token_validity_units");

    /// <summary>
    /// The write_attributes attribute.
    /// </summary>
    public TerraformSet<string> WriteAttributes
        => CreateReference("write_attributes");

}
