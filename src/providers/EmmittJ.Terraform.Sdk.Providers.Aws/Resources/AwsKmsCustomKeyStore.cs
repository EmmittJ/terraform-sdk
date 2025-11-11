using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsKmsCustomKeyStoreTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for xks_proxy_authentication_credential in .
/// Nesting mode: list
/// </summary>
public partial class AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock : TerraformBlockBase
{
    /// <summary>
    /// The access_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    [TerraformProperty("access_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AccessKeyId { get; set; }

    /// <summary>
    /// The raw_secret_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RawSecretAccessKey is required")]
    [TerraformProperty("raw_secret_access_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RawSecretAccessKey { get; set; }

}

/// <summary>
/// Manages a aws_kms_custom_key_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsKmsCustomKeyStore : TerraformResource
{
    public AwsKmsCustomKeyStore(string name) : base("aws_kms_custom_key_store", name)
    {
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    [TerraformProperty("cloud_hsm_cluster_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CloudHsmClusterId { get; set; }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomKeyStoreName is required")]
    [TerraformProperty("custom_key_store_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomKeyStoreName { get; set; }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    [TerraformProperty("custom_key_store_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> CustomKeyStoreType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The key_store_password attribute.
    /// </summary>
    [TerraformProperty("key_store_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KeyStorePassword { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    [TerraformProperty("trust_anchor_certificate")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TrustAnchorCertificate { get; set; }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    [TerraformProperty("xks_proxy_connectivity")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? XksProxyConnectivity { get; set; }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    [TerraformProperty("xks_proxy_uri_endpoint")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? XksProxyUriEndpoint { get; set; }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    [TerraformProperty("xks_proxy_uri_path")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? XksProxyUriPath { get; set; }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    [TerraformProperty("xks_proxy_vpc_endpoint_service_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? XksProxyVpcEndpointServiceName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsKmsCustomKeyStoreTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for xks_proxy_authentication_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XksProxyAuthenticationCredential block(s) allowed")]
    [TerraformProperty("xks_proxy_authentication_credential")]
    public TerraformList<TerraformBlock<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>>? XksProxyAuthenticationCredential { get; set; }

}
