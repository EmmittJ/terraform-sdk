using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceCognitoConfigBlock : TerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The user_pool attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPool is required")]
    public required TerraformProperty<string> UserPool
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_pool");
        set => WithProperty("user_pool", value);
    }

}

/// <summary>
/// Block type for oidc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceOidcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AuthenticationRequestExtraParams
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("authentication_request_extra_params");
        set => WithProperty("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformProperty<string> AuthorizationEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("authorization_endpoint");
        set => WithProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        get => GetRequiredProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

    /// <summary>
    /// The jwks_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JwksUri is required")]
    public required TerraformProperty<string> JwksUri
    {
        get => GetRequiredProperty<TerraformProperty<string>>("jwks_uri");
        set => WithProperty("jwks_uri", value);
    }

    /// <summary>
    /// The logout_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogoutEndpoint is required")]
    public required TerraformProperty<string> LogoutEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("logout_endpoint");
        set => WithProperty("logout_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformProperty<string> TokenEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("token_endpoint");
        set => WithProperty("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    public required TerraformProperty<string> UserInfoEndpoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_info_endpoint");
        set => WithProperty("user_info_endpoint", value);
    }

}

/// <summary>
/// Block type for source_ip_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceSourceIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidrs is required")]
    public HashSet<TerraformProperty<string>>? Cidrs
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("cidrs");
        set => WithProperty("cidrs", value);
    }

}

/// <summary>
/// Block type for workforce_vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceWorkforceVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Subnets
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnets");
        set => WithProperty("subnets", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => WithProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => WithProperty("vpc_id", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_workforce resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerWorkforce : TerraformResource
{
    public AwsSagemakerWorkforce(string name) : base("aws_sagemaker_workforce", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("subdomain");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The workforce_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforceName is required")]
    public required TerraformProperty<string> WorkforceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workforce_name");
        set => this.WithProperty("workforce_name", value);
    }

    /// <summary>
    /// Block for cognito_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceCognitoConfigBlock>? CognitoConfig
    {
        get => GetProperty<List<AwsSagemakerWorkforceCognitoConfigBlock>>("cognito_config");
        set => this.WithProperty("cognito_config", value);
    }

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceOidcConfigBlock>? OidcConfig
    {
        get => GetProperty<List<AwsSagemakerWorkforceOidcConfigBlock>>("oidc_config");
        set => this.WithProperty("oidc_config", value);
    }

    /// <summary>
    /// Block for source_ip_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIpConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceSourceIpConfigBlock>? SourceIpConfig
    {
        get => GetProperty<List<AwsSagemakerWorkforceSourceIpConfigBlock>>("source_ip_config");
        set => this.WithProperty("source_ip_config", value);
    }

    /// <summary>
    /// Block for workforce_vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceVpcConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceWorkforceVpcConfigBlock>? WorkforceVpcConfig
    {
        get => GetProperty<List<AwsSagemakerWorkforceWorkforceVpcConfigBlock>>("workforce_vpc_config");
        set => this.WithProperty("workforce_vpc_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    public TerraformExpression Subdomain => this["subdomain"];

}
