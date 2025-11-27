using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsKmsCustomKeyStore.
/// Nesting mode: single
/// </summary>
public class AwsKmsCustomKeyStoreTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for xks_proxy_authentication_credential in AwsKmsCustomKeyStore.
/// Nesting mode: list
/// </summary>
public class AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "xks_proxy_authentication_credential";

    /// <summary>
    /// The access_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessKeyId is required")]
    public required TerraformValue<string> AccessKeyId
    {
        get => new TerraformReference<string>(this, "access_key_id");
        set => SetArgument("access_key_id", value);
    }

    /// <summary>
    /// The raw_secret_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RawSecretAccessKey is required")]
    public required TerraformValue<string> RawSecretAccessKey
    {
        get => new TerraformReference<string>(this, "raw_secret_access_key");
        set => SetArgument("raw_secret_access_key", value);
    }

}


/// <summary>
/// Represents a aws_kms_custom_key_store Terraform resource.
/// Manages a aws_kms_custom_key_store resource.
/// </summary>
public partial class AwsKmsCustomKeyStore(string name) : TerraformResource("aws_kms_custom_key_store", name)
{
    /// <summary>
    /// The cloud_hsm_cluster_id attribute.
    /// </summary>
    public TerraformValue<string>? CloudHsmClusterId
    {
        get => new TerraformReference<string>(this, "cloud_hsm_cluster_id");
        set => SetArgument("cloud_hsm_cluster_id", value);
    }

    /// <summary>
    /// The custom_key_store_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomKeyStoreName is required")]
    public required TerraformValue<string> CustomKeyStoreName
    {
        get => new TerraformReference<string>(this, "custom_key_store_name");
        set => SetArgument("custom_key_store_name", value);
    }

    /// <summary>
    /// The custom_key_store_type attribute.
    /// </summary>
    public TerraformValue<string> CustomKeyStoreType
    {
        get => new TerraformReference<string>(this, "custom_key_store_type");
        set => SetArgument("custom_key_store_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_store_password attribute.
    /// </summary>
    public TerraformValue<string>? KeyStorePassword
    {
        get => new TerraformReference<string>(this, "key_store_password");
        set => SetArgument("key_store_password", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The trust_anchor_certificate attribute.
    /// </summary>
    public TerraformValue<string>? TrustAnchorCertificate
    {
        get => new TerraformReference<string>(this, "trust_anchor_certificate");
        set => SetArgument("trust_anchor_certificate", value);
    }

    /// <summary>
    /// The xks_proxy_connectivity attribute.
    /// </summary>
    public TerraformValue<string>? XksProxyConnectivity
    {
        get => new TerraformReference<string>(this, "xks_proxy_connectivity");
        set => SetArgument("xks_proxy_connectivity", value);
    }

    /// <summary>
    /// The xks_proxy_uri_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? XksProxyUriEndpoint
    {
        get => new TerraformReference<string>(this, "xks_proxy_uri_endpoint");
        set => SetArgument("xks_proxy_uri_endpoint", value);
    }

    /// <summary>
    /// The xks_proxy_uri_path attribute.
    /// </summary>
    public TerraformValue<string>? XksProxyUriPath
    {
        get => new TerraformReference<string>(this, "xks_proxy_uri_path");
        set => SetArgument("xks_proxy_uri_path", value);
    }

    /// <summary>
    /// The xks_proxy_vpc_endpoint_service_name attribute.
    /// </summary>
    public TerraformValue<string>? XksProxyVpcEndpointServiceName
    {
        get => new TerraformReference<string>(this, "xks_proxy_vpc_endpoint_service_name");
        set => SetArgument("xks_proxy_vpc_endpoint_service_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKmsCustomKeyStoreTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKmsCustomKeyStoreTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// XksProxyAuthenticationCredential block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 XksProxyAuthenticationCredential block(s) allowed")]
    public TerraformList<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>? XksProxyAuthenticationCredential
    {
        get => GetArgument<TerraformList<AwsKmsCustomKeyStoreXksProxyAuthenticationCredentialBlock>>("xks_proxy_authentication_credential");
        set => SetArgument("xks_proxy_authentication_credential", value);
    }

}
