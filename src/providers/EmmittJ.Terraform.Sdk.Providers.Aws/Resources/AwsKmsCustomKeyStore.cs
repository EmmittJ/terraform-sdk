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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("access_key_id", value);
    }

    /// <summary>
    /// The raw_secret_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RawSecretAccessKey is required")]
    public required TerraformProperty<string> RawSecretAccessKey
    {
        set => SetProperty("raw_secret_access_key", value);
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
        SetOutput("cloud_hsm_cluster_id");
        SetOutput("custom_key_store_name");
        SetOutput("custom_key_store_type");
        SetOutput("id");
        SetOutput("key_store_password");
        SetOutput("region");
        SetOutput("trust_anchor_certificate");
        SetOutput("xks_proxy_connectivity");
        SetOutput("xks_proxy_uri_endpoint");
        SetOutput("xks_proxy_uri_path");
        SetOutput("xks_proxy_vpc_endpoint_service_name");
    }

    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string> CloudHsmClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cloud_hsm_cluster_id");
        set => SetProperty("cloud_hsm_cluster_id", value);
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomKeyStoreName is required")]
    public required TerraformProperty<string> CustomKeyStoreName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_key_store_name");
        set => SetProperty("custom_key_store_name", value);
    }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    public TerraformProperty<string> CustomKeyStoreType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_key_store_type");
        set => SetProperty("custom_key_store_type", value);
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
    /// The key_store_password attribute.
    /// </summary>
    public TerraformProperty<string> KeyStorePassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_store_password");
        set => SetProperty("key_store_password", value);
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
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public TerraformProperty<string> TrustAnchorCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trust_anchor_certificate");
        set => SetProperty("trust_anchor_certificate", value);
    }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    public TerraformProperty<string> XksProxyConnectivity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xks_proxy_connectivity");
        set => SetProperty("xks_proxy_connectivity", value);
    }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> XksProxyUriEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xks_proxy_uri_endpoint");
        set => SetProperty("xks_proxy_uri_endpoint", value);
    }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    public TerraformProperty<string> XksProxyUriPath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xks_proxy_uri_path");
        set => SetProperty("xks_proxy_uri_path", value);
    }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformProperty<string> XksProxyVpcEndpointServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("xks_proxy_vpc_endpoint_service_name");
        set => SetProperty("xks_proxy_vpc_endpoint_service_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsKmsCustomKeyStoreTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for xks_proxy_authentication_credential.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XksProxyAuthenticationCredential block(s) allowed")]
    public List<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>? XksProxyAuthenticationCredential
    {
        set => SetProperty("xks_proxy_authentication_credential", value);
    }

}
