using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_kms_custom_key_store resource.
/// </summary>
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
    public string? CloudHsmClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_hsm_cluster_id")?.Value;
        set => this.WithProperty("cloud_hsm_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    public string? CustomKeyStoreName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_name")?.Value;
        set => this.WithProperty("custom_key_store_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    public string? CustomKeyStoreType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_type")?.Value;
        set => this.WithProperty("custom_key_store_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The key_store_password attribute.
    /// </summary>
    public string? KeyStorePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_store_password")?.Value;
        set => this.WithProperty("key_store_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public string? TrustAnchorCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_anchor_certificate")?.Value;
        set => this.WithProperty("trust_anchor_certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    public string? XksProxyConnectivity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_connectivity")?.Value;
        set => this.WithProperty("xks_proxy_connectivity", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    public string? XksProxyUriEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_uri_endpoint")?.Value;
        set => this.WithProperty("xks_proxy_uri_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    public string? XksProxyUriPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_uri_path")?.Value;
        set => this.WithProperty("xks_proxy_uri_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    public string? XksProxyVpcEndpointServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_vpc_endpoint_service_name")?.Value;
        set => this.WithProperty("xks_proxy_vpc_endpoint_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
