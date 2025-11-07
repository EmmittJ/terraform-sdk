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
    public TerraformLiteralProperty<string>? CloudHsmClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cloud_hsm_cluster_id");
        set => this.WithProperty("cloud_hsm_cluster_id", value);
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomKeyStoreName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_name");
        set => this.WithProperty("custom_key_store_name", value);
    }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomKeyStoreType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_key_store_type");
        set => this.WithProperty("custom_key_store_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_store_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyStorePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_store_password");
        set => this.WithProperty("key_store_password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TrustAnchorCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("trust_anchor_certificate");
        set => this.WithProperty("trust_anchor_certificate", value);
    }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XksProxyConnectivity
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_connectivity");
        set => this.WithProperty("xks_proxy_connectivity", value);
    }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XksProxyUriEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_uri_endpoint");
        set => this.WithProperty("xks_proxy_uri_endpoint", value);
    }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XksProxyUriPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_uri_path");
        set => this.WithProperty("xks_proxy_uri_path", value);
    }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? XksProxyVpcEndpointServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("xks_proxy_vpc_endpoint_service_name");
        set => this.WithProperty("xks_proxy_vpc_endpoint_service_name", value);
    }

}
