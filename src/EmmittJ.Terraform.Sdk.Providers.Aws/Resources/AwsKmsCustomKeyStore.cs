using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsKmsCustomKeyStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for xks_proxy_authentication_credential in .
/// Nesting mode: list
/// </summary>
public class AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock : TerraformBlock
{
    /// <summary>
    /// The access_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    public required TerraformProperty<string> AccessKeyId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("access_key_id");
        set => WithProperty("access_key_id", value);
    }

    /// <summary>
    /// The raw_secret_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RawSecretAccessKey is required")]
    public required TerraformProperty<string> RawSecretAccessKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("raw_secret_access_key");
        set => WithProperty("raw_secret_access_key", value);
    }

}

/// <summary>
/// Manages a aws_kms_custom_key_store resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsKmsCustomKeyStore : TerraformResource
{
    public AwsKmsCustomKeyStore(string name) : base("aws_kms_custom_key_store", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? CloudHsmClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cloud_hsm_cluster_id");
        set => this.WithProperty("cloud_hsm_cluster_id", value);
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomKeyStoreName is required")]
    public required TerraformProperty<string> CustomKeyStoreName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("custom_key_store_name");
        set => this.WithProperty("custom_key_store_name", value);
    }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    public TerraformProperty<string>? CustomKeyStoreType
    {
        get => GetProperty<TerraformProperty<string>>("custom_key_store_type");
        set => this.WithProperty("custom_key_store_type", value);
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
    /// The key_store_password attribute.
    /// </summary>
    public TerraformProperty<string>? KeyStorePassword
    {
        get => GetProperty<TerraformProperty<string>>("key_store_password");
        set => this.WithProperty("key_store_password", value);
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
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public TerraformProperty<string>? TrustAnchorCertificate
    {
        get => GetProperty<TerraformProperty<string>>("trust_anchor_certificate");
        set => this.WithProperty("trust_anchor_certificate", value);
    }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    public TerraformProperty<string>? XksProxyConnectivity
    {
        get => GetProperty<TerraformProperty<string>>("xks_proxy_connectivity");
        set => this.WithProperty("xks_proxy_connectivity", value);
    }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? XksProxyUriEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("xks_proxy_uri_endpoint");
        set => this.WithProperty("xks_proxy_uri_endpoint", value);
    }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    public TerraformProperty<string>? XksProxyUriPath
    {
        get => GetProperty<TerraformProperty<string>>("xks_proxy_uri_path");
        set => this.WithProperty("xks_proxy_uri_path", value);
    }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? XksProxyVpcEndpointServiceName
    {
        get => GetProperty<TerraformProperty<string>>("xks_proxy_vpc_endpoint_service_name");
        set => this.WithProperty("xks_proxy_vpc_endpoint_service_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKmsCustomKeyStoreTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsKmsCustomKeyStoreTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for xks_proxy_authentication_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XksProxyAuthenticationCredential block(s) allowed")]
    public List<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>? XksProxyAuthenticationCredential
    {
        get => GetProperty<List<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>>("xks_proxy_authentication_credential");
        set => this.WithProperty("xks_proxy_authentication_credential", value);
    }

}
