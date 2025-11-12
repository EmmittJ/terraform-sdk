using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessTrustProviderDeviceOptionsBlock() : TerraformBlock("device_options")
{
    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for native_application_oidc_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock() : TerraformBlock("native_application_oidc_options")
{
    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [TerraformProperty("authorization_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

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
    [TerraformProperty("issuer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The public_signing_key_endpoint attribute.
    /// </summary>
    [TerraformProperty("public_signing_key_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicSigningKeyEndpoint { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformProperty("token_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TokenEndpoint { get; set; }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [TerraformProperty("user_info_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserInfoEndpoint { get; set; }

}

/// <summary>
/// Block type for oidc_options in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessTrustProviderOidcOptionsBlock() : TerraformBlock("oidc_options")
{
    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    [TerraformProperty("authorization_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationEndpoint { get; set; }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformProperty("client_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClientId { get; set; }

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
    [TerraformProperty("issuer")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Issuer { get; set; }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [TerraformProperty("scope")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Scope { get; set; }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    [TerraformProperty("token_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TokenEndpoint { get; set; }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    [TerraformProperty("user_info_endpoint")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserInfoEndpoint { get; set; }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedaccessTrustProviderSseSpecificationBlock() : TerraformBlock("sse_specification")
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CustomerManagedKeyEnabled { get; set; }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    [TerraformProperty("kms_key_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyArn { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsVerifiedaccessTrustProviderTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_verifiedaccess_trust_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsVerifiedaccessTrustProvider : TerraformResource
{
    public AwsVerifiedaccessTrustProvider(string name) : base("aws_verifiedaccess_trust_provider", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    [TerraformProperty("device_trust_provider_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeviceTrustProviderType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_reference_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyReferenceName is required")]
    [TerraformProperty("policy_reference_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyReferenceName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustProviderType is required")]
    [TerraformProperty("trust_provider_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TrustProviderType { get; set; }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    [TerraformProperty("user_trust_provider_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserTrustProviderType { get; set; }

    /// <summary>
    /// Block for device_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceOptions block(s) allowed")]
    [TerraformProperty("device_options")]
    public TerraformList<AwsVerifiedaccessTrustProviderDeviceOptionsBlock> DeviceOptions { get; set; } = new();

    /// <summary>
    /// Block for native_application_oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NativeApplicationOidcOptions block(s) allowed")]
    [TerraformProperty("native_application_oidc_options")]
    public TerraformList<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock> NativeApplicationOidcOptions { get; set; } = new();

    /// <summary>
    /// Block for oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcOptions block(s) allowed")]
    [TerraformProperty("oidc_options")]
    public TerraformList<AwsVerifiedaccessTrustProviderOidcOptionsBlock> OidcOptions { get; set; } = new();

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    [TerraformProperty("sse_specification")]
    public TerraformList<AwsVerifiedaccessTrustProviderSseSpecificationBlock> SseSpecification { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsVerifiedaccessTrustProviderTimeoutsBlock Timeouts { get; set; } = new();

}
