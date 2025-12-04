using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_config in AwsSagemakerWorkforce.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceCognitoConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognito_config";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The user_pool attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPool is required")]
    public required TerraformValue<string> UserPool
    {
        get => GetArgument<TerraformValue<string>>("user_pool");
        set => SetArgument("user_pool", value);
    }

}


/// <summary>
/// Block type for oidc_config in AwsSagemakerWorkforce.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceOidcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_config";

    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    public TerraformMap<string>? AuthenticationRequestExtraParams
    {
        get => GetArgument<TerraformMap<string>>("authentication_request_extra_params");
        set => SetArgument("authentication_request_extra_params", value);
    }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    public required TerraformValue<string> AuthorizationEndpoint
    {
        get => GetArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    public required TerraformValue<string> Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The jwks_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JwksUri is required")]
    public required TerraformValue<string> JwksUri
    {
        get => GetArgument<TerraformValue<string>>("jwks_uri");
        set => SetArgument("jwks_uri", value);
    }

    /// <summary>
    /// The logout_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogoutEndpoint is required")]
    public required TerraformValue<string> LogoutEndpoint
    {
        get => GetArgument<TerraformValue<string>>("logout_endpoint");
        set => SetArgument("logout_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    public required TerraformValue<string> TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    public required TerraformValue<string> UserInfoEndpoint
    {
        get => GetArgument<TerraformValue<string>>("user_info_endpoint");
        set => SetArgument("user_info_endpoint", value);
    }

}


/// <summary>
/// Block type for source_ip_config in AwsSagemakerWorkforce.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceSourceIpConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_ip_config";

    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidrs is required")]
    public required TerraformSet<string> Cidrs
    {
        get => GetArgument<TerraformSet<string>>("cidrs");
        set => SetArgument("cidrs", value);
    }

}


/// <summary>
/// Block type for workforce_vpc_config in AwsSagemakerWorkforce.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceWorkforceVpcConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "workforce_vpc_config";

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    public TerraformSet<string>? Subnets
    {
        get => GetArgument<TerraformSet<string>>("subnets");
        set => SetArgument("subnets", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string> VpcEndpointId
        => AsReference("vpc_endpoint_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_workforce Terraform resource.
/// Manages a aws_sagemaker_workforce resource.
/// </summary>
public partial class AwsSagemakerWorkforce(string name) : TerraformResource("aws_sagemaker_workforce", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforceName is required")]
    public required TerraformValue<string> WorkforceName
    {
        get => GetArgument<TerraformValue<string>>("workforce_name");
        set => SetArgument("workforce_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    public TerraformValue<string> Subdomain
        => AsReference("subdomain");

    /// <summary>
    /// CognitoConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoConfig block(s) allowed")]
    public TerraformList<AwsSagemakerWorkforceCognitoConfigBlock>? CognitoConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkforceCognitoConfigBlock>>("cognito_config");
        set => SetArgument("cognito_config", value);
    }

    /// <summary>
    /// OidcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    public TerraformList<AwsSagemakerWorkforceOidcConfigBlock>? OidcConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkforceOidcConfigBlock>>("oidc_config");
        set => SetArgument("oidc_config", value);
    }

    /// <summary>
    /// SourceIpConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIpConfig block(s) allowed")]
    public TerraformList<AwsSagemakerWorkforceSourceIpConfigBlock>? SourceIpConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkforceSourceIpConfigBlock>>("source_ip_config");
        set => SetArgument("source_ip_config", value);
    }

    /// <summary>
    /// WorkforceVpcConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceVpcConfig block(s) allowed")]
    public TerraformList<AwsSagemakerWorkforceWorkforceVpcConfigBlock>? WorkforceVpcConfig
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkforceWorkforceVpcConfigBlock>>("workforce_vpc_config");
        set => SetArgument("workforce_vpc_config", value);
    }

}
