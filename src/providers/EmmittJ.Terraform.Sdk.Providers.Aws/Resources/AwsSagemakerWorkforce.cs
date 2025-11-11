using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkforceCognitoConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The user_pool attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPool is required")]
    [TerraformProperty("user_pool")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserPool { get; set; }

}

/// <summary>
/// Block type for oidc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkforceOidcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    [TerraformProperty("authentication_request_extra_params")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    [TerraformProperty("authorization_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformProperty("client_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClientSecret { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformProperty("issuer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Issuer { get; set; }

    /// <summary>
    /// The jwks_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JwksUri is required")]
    [TerraformProperty("jwks_uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JwksUri { get; set; }

    /// <summary>
    /// The logout_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogoutEndpoint is required")]
    [TerraformProperty("logout_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LogoutEndpoint { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    [TerraformProperty("token_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TokenEndpoint { get; set; }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    [TerraformProperty("user_info_endpoint")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserInfoEndpoint { get; set; }

}

/// <summary>
/// Block type for source_ip_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkforceSourceIpConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidrs is required")]
    [TerraformProperty("cidrs")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Cidrs { get; set; }

}

/// <summary>
/// Block type for workforce_vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSagemakerWorkforceWorkforceVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformProperty("subnets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Subnets { get; set; }


    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? VpcId { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_workforce resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSagemakerWorkforce : TerraformResource
{
    public AwsSagemakerWorkforce(string name) : base("aws_sagemaker_workforce", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforceName is required")]
    [TerraformProperty("workforce_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkforceName { get; set; }

    /// <summary>
    /// Block for cognito_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoConfig block(s) allowed")]
    [TerraformProperty("cognito_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerWorkforceCognitoConfigBlock>>? CognitoConfig { get; set; }

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    [TerraformProperty("oidc_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerWorkforceOidcConfigBlock>>? OidcConfig { get; set; }

    /// <summary>
    /// Block for source_ip_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIpConfig block(s) allowed")]
    [TerraformProperty("source_ip_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerWorkforceSourceIpConfigBlock>>? SourceIpConfig { get; set; }

    /// <summary>
    /// Block for workforce_vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceVpcConfig block(s) allowed")]
    [TerraformProperty("workforce_vpc_config")]
    public partial TerraformList<TerraformBlock<AwsSagemakerWorkforceWorkforceVpcConfigBlock>>? WorkforceVpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    [TerraformProperty("subdomain")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Subdomain { get; }

}
