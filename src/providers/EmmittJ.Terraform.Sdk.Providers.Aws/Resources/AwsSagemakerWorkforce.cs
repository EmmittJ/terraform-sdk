using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for cognito_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceCognitoConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// The user_pool attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPool is required")]
    [TerraformPropertyName("user_pool")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPool { get; set; }

}

/// <summary>
/// Block type for oidc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceOidcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The authentication_request_extra_params attribute.
    /// </summary>
    [TerraformPropertyName("authentication_request_extra_params")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? AuthenticationRequestExtraParams { get; set; }

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizationEndpoint is required")]
    [TerraformPropertyName("authorization_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClientSecret { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Issuer is required")]
    [TerraformPropertyName("issuer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Issuer { get; set; }

    /// <summary>
    /// The jwks_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JwksUri is required")]
    [TerraformPropertyName("jwks_uri")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> JwksUri { get; set; }

    /// <summary>
    /// The logout_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogoutEndpoint is required")]
    [TerraformPropertyName("logout_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogoutEndpoint { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Scope { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TokenEndpoint is required")]
    [TerraformPropertyName("token_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TokenEndpoint { get; set; }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserInfoEndpoint is required")]
    [TerraformPropertyName("user_info_endpoint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserInfoEndpoint { get; set; }

}

/// <summary>
/// Block type for source_ip_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceSourceIpConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The cidrs attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidrs is required")]
    [TerraformPropertyName("cidrs")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Cidrs { get; set; }

}

/// <summary>
/// Block type for workforce_vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkforceWorkforceVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnets attribute.
    /// </summary>
    [TerraformPropertyName("subnets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Subnets { get; set; }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcEndpointId => new TerraformReferenceProperty<TerraformProperty<string>>("", "vpc_endpoint_id");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? VpcId { get; set; }

}

/// <summary>
/// Manages a aws_sagemaker_workforce resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerWorkforce : TerraformResource
{
    public AwsSagemakerWorkforce(string name) : base("aws_sagemaker_workforce", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The workforce_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkforceName is required")]
    [TerraformPropertyName("workforce_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkforceName { get; set; }

    /// <summary>
    /// Block for cognito_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoConfig block(s) allowed")]
    [TerraformPropertyName("cognito_config")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkforceCognitoConfigBlock>>? CognitoConfig { get; set; } = new();

    /// <summary>
    /// Block for oidc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcConfig block(s) allowed")]
    [TerraformPropertyName("oidc_config")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkforceOidcConfigBlock>>? OidcConfig { get; set; } = new();

    /// <summary>
    /// Block for source_ip_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceIpConfig block(s) allowed")]
    [TerraformPropertyName("source_ip_config")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkforceSourceIpConfigBlock>>? SourceIpConfig { get; set; } = new();

    /// <summary>
    /// Block for workforce_vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkforceVpcConfig block(s) allowed")]
    [TerraformPropertyName("workforce_vpc_config")]
    public TerraformList<TerraformBlock<AwsSagemakerWorkforceWorkforceVpcConfigBlock>>? WorkforceVpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    [TerraformPropertyName("subdomain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Subdomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subdomain");

}
