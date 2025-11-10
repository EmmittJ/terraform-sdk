using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderDeviceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for native_application_oidc_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("authorization_endpoint");
        set => WithProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

    /// <summary>
    /// The public_signing_key_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? PublicSigningKeyEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("public_signing_key_endpoint");
        set => WithProperty("public_signing_key_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? TokenEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("token_endpoint");
        set => WithProperty("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? UserInfoEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("user_info_endpoint");
        set => WithProperty("user_info_endpoint", value);
    }

}

/// <summary>
/// Block type for oidc_options in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderOidcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? AuthorizationEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("authorization_endpoint");
        set => WithProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetProperty<TerraformProperty<string>>("client_secret");
        set => WithProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        get => GetProperty<TerraformProperty<string>>("issuer");
        set => WithProperty("issuer", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        get => GetProperty<TerraformProperty<string>>("scope");
        set => WithProperty("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? TokenEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("token_endpoint");
        set => WithProperty("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? UserInfoEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("user_info_endpoint");
        set => WithProperty("user_info_endpoint", value);
    }

}

/// <summary>
/// Block type for sse_specification in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderSseSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CustomerManagedKeyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("customer_managed_key_enabled");
        set => WithProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => WithProperty("kms_key_arn", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessTrustProviderTimeoutsBlock : TerraformBlock
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
/// Manages a aws_verifiedaccess_trust_provider resource.
/// </summary>
public class AwsVerifiedaccessTrustProvider : TerraformResource
{
    public AwsVerifiedaccessTrustProvider(string name) : base("aws_verifiedaccess_trust_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceTrustProviderType
    {
        get => GetProperty<TerraformProperty<string>>("device_trust_provider_type");
        set => this.WithProperty("device_trust_provider_type", value);
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
    /// The policy_reference_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyReferenceName is required")]
    public required TerraformProperty<string> PolicyReferenceName
    {
        get => GetProperty<TerraformProperty<string>>("policy_reference_name");
        set => this.WithProperty("policy_reference_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustProviderType is required")]
    public required TerraformProperty<string> TrustProviderType
    {
        get => GetProperty<TerraformProperty<string>>("trust_provider_type");
        set => this.WithProperty("trust_provider_type", value);
    }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string>? UserTrustProviderType
    {
        get => GetProperty<TerraformProperty<string>>("user_trust_provider_type");
        set => this.WithProperty("user_trust_provider_type", value);
    }

    /// <summary>
    /// Block for device_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceOptions block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderDeviceOptionsBlock>? DeviceOptions
    {
        get => GetProperty<List<AwsVerifiedaccessTrustProviderDeviceOptionsBlock>>("device_options");
        set => this.WithProperty("device_options", value);
    }

    /// <summary>
    /// Block for native_application_oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NativeApplicationOidcOptions block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock>? NativeApplicationOidcOptions
    {
        get => GetProperty<List<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock>>("native_application_oidc_options");
        set => this.WithProperty("native_application_oidc_options", value);
    }

    /// <summary>
    /// Block for oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcOptions block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderOidcOptionsBlock>? OidcOptions
    {
        get => GetProperty<List<AwsVerifiedaccessTrustProviderOidcOptionsBlock>>("oidc_options");
        set => this.WithProperty("oidc_options", value);
    }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderSseSpecificationBlock>? SseSpecification
    {
        get => GetProperty<List<AwsVerifiedaccessTrustProviderSseSpecificationBlock>>("sse_specification");
        set => this.WithProperty("sse_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVerifiedaccessTrustProviderTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVerifiedaccessTrustProviderTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
