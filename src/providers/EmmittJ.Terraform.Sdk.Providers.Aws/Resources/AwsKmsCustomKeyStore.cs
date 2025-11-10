using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKmsCustomKeyStoreTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for xks_proxy_authentication_credential in .
/// Nesting mode: list
/// </summary>
public class AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock : ITerraformBlock
{
    /// <summary>
    /// The access_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    [TerraformPropertyName("access_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccessKeyId { get; set; }

    /// <summary>
    /// The raw_secret_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RawSecretAccessKey is required")]
    [TerraformPropertyName("raw_secret_access_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RawSecretAccessKey { get; set; }

}

/// <summary>
/// Manages a aws_kms_custom_key_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKmsCustomKeyStore : TerraformResource
{
    public AwsKmsCustomKeyStore(string name) : base("aws_kms_custom_key_store", name)
    {
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_hsm_cluster_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CloudHsmClusterId { get; set; }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomKeyStoreName is required")]
    [TerraformPropertyName("custom_key_store_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomKeyStoreName { get; set; }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    [TerraformPropertyName("custom_key_store_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CustomKeyStoreType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_key_store_type");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The key_store_password attribute.
    /// </summary>
    [TerraformPropertyName("key_store_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyStorePassword { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    [TerraformPropertyName("trust_anchor_certificate")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrustAnchorCertificate { get; set; }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    [TerraformPropertyName("xks_proxy_connectivity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? XksProxyConnectivity { get; set; }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("xks_proxy_uri_endpoint")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? XksProxyUriEndpoint { get; set; }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    [TerraformPropertyName("xks_proxy_uri_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? XksProxyUriPath { get; set; }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    [TerraformPropertyName("xks_proxy_vpc_endpoint_service_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? XksProxyVpcEndpointServiceName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsKmsCustomKeyStoreTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for xks_proxy_authentication_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XksProxyAuthenticationCredential block(s) allowed")]
    [TerraformPropertyName("xks_proxy_authentication_credential")]
    public TerraformList<TerraformBlock<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>>? XksProxyAuthenticationCredential { get; set; } = new();

}
