using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderDeviceOptionsBlock
{
    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for native_application_oidc_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock
{
    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("authorization_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientSecret { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The public_signing_key_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("public_signing_key_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicSigningKeyEndpoint { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("token_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TokenEndpoint { get; set; }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("user_info_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserInfoEndpoint { get; set; }

}

/// <summary>
/// Block type for oidc_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderOidcOptionsBlock
{
    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("authorization_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    [TerraformPropertyName("client_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientSecret { get; set; }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformPropertyName("issuer")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformPropertyName("scope")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("token_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TokenEndpoint { get; set; }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("user_info_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserInfoEndpoint { get; set; }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderSseSpecificationBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformPropertyName("customer_managed_key_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessTrustProviderTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_verifiedaccess_trust_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessTrustProvider : TerraformResource
{
    public AwsVerifiedaccessTrustProvider(string name) : base("aws_verifiedaccess_trust_provider", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    [TerraformPropertyName("device_trust_provider_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeviceTrustProviderType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The policy_reference_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyReferenceName is required")]
    [TerraformPropertyName("policy_reference_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> PolicyReferenceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustProviderType is required")]
    [TerraformPropertyName("trust_provider_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TrustProviderType { get; set; }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    [TerraformPropertyName("user_trust_provider_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserTrustProviderType { get; set; }

    /// <summary>
    /// Block for device_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceOptions block(s) allowed")]
    [TerraformPropertyName("device_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessTrustProviderDeviceOptionsBlock>>? DeviceOptions { get; set; }

    /// <summary>
    /// Block for native_application_oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NativeApplicationOidcOptions block(s) allowed")]
    [TerraformPropertyName("native_application_oidc_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock>>? NativeApplicationOidcOptions { get; set; }

    /// <summary>
    /// Block for oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcOptions block(s) allowed")]
    [TerraformPropertyName("oidc_options")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessTrustProviderOidcOptionsBlock>>? OidcOptions { get; set; }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    [TerraformPropertyName("sse_specification")]
    public TerraformList<TerraformBlock<AwsVerifiedaccessTrustProviderSseSpecificationBlock>>? SseSpecification { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsVerifiedaccessTrustProviderTimeoutsBlock>? Timeouts { get; set; }

}
