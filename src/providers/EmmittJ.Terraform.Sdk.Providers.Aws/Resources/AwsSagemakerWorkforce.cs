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
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The user_pool attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPool is required")]
    public required TerraformProperty<string> UserPool
    {
        set => SetProperty("user_pool", value);
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
        set => SetProperty("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformProperty<string> AuthorizationEndpoint
    {
        set => SetProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformProperty<string> Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The jwks_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JwksUri is required")]
    public required TerraformProperty<string> JwksUri
    {
        set => SetProperty("jwks_uri", value);
    }

    /// <summary>
    /// The logout_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogoutEndpoint is required")]
    public required TerraformProperty<string> LogoutEndpoint
    {
        set => SetProperty("logout_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformProperty<string> TokenEndpoint
    {
        set => SetProperty("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    public required TerraformProperty<string> UserInfoEndpoint
    {
        set => SetProperty("user_info_endpoint", value);
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
        set => SetProperty("cidrs", value);
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
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Subnets
    {
        set => SetProperty("subnets", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        set => SetProperty("vpc_id", value);
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
        SetOutput("arn");
        SetOutput("subdomain");
        SetOutput("id");
        SetOutput("region");
        SetOutput("workforce_name");
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
    /// The workforce_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforceName is required")]
    public required TerraformProperty<string> WorkforceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workforce_name");
        set => SetProperty("workforce_name", value);
    }

    /// <summary>
    /// Block for cognito_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceCognitoConfigBlock>? CognitoConfig
    {
        set => SetProperty("cognito_config", value);
    }

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceOidcConfigBlock>? OidcConfig
    {
        set => SetProperty("oidc_config", value);
    }

    /// <summary>
    /// Block for source_ip_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIpConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceSourceIpConfigBlock>? SourceIpConfig
    {
        set => SetProperty("source_ip_config", value);
    }

    /// <summary>
    /// Block for workforce_vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceVpcConfig block(s) allowed")]
    public List<AwsSagemakerWorkforceWorkforceVpcConfigBlock>? WorkforceVpcConfig
    {
        set => SetProperty("workforce_vpc_config", value);
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
