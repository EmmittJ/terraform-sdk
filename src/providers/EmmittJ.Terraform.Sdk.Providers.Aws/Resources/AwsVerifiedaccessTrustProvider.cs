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
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The public_signing_key_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? PublicSigningKeyEndpoint
    {
        set => SetProperty("public_signing_key_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? TokenEndpoint
    {
        set => SetProperty("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? UserInfoEndpoint
    {
        set => SetProperty("user_info_endpoint", value);
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
        set => SetProperty("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformProperty<string>? Issuer
    {
        set => SetProperty("issuer", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformProperty<string>? Scope
    {
        set => SetProperty("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? TokenEndpoint
    {
        set => SetProperty("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? UserInfoEndpoint
    {
        set => SetProperty("user_info_endpoint", value);
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
        set => SetProperty("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        set => SetProperty("kms_key_arn", value);
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
/// Manages a aws_verifiedaccess_trust_provider resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessTrustProvider : TerraformResource
{
    public AwsVerifiedaccessTrustProvider(string name) : base("aws_verifiedaccess_trust_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("device_trust_provider_type");
        SetOutput("id");
        SetOutput("policy_reference_name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("trust_provider_type");
        SetOutput("user_trust_provider_type");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string> DeviceTrustProviderType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("device_trust_provider_type");
        set => SetProperty("device_trust_provider_type", value);
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
    /// The policy_reference_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyReferenceName is required")]
    public required TerraformProperty<string> PolicyReferenceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("policy_reference_name");
        set => SetProperty("policy_reference_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustProviderType is required")]
    public required TerraformProperty<string> TrustProviderType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("trust_provider_type");
        set => SetProperty("trust_provider_type", value);
    }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    public TerraformProperty<string> UserTrustProviderType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_trust_provider_type");
        set => SetProperty("user_trust_provider_type", value);
    }

    /// <summary>
    /// Block for device_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceOptions block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderDeviceOptionsBlock>? DeviceOptions
    {
        set => SetProperty("device_options", value);
    }

    /// <summary>
    /// Block for native_application_oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NativeApplicationOidcOptions block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock>? NativeApplicationOidcOptions
    {
        set => SetProperty("native_application_oidc_options", value);
    }

    /// <summary>
    /// Block for oidc_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcOptions block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderOidcOptionsBlock>? OidcOptions
    {
        set => SetProperty("oidc_options", value);
    }

    /// <summary>
    /// Block for sse_specification.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    public List<AwsVerifiedaccessTrustProviderSseSpecificationBlock>? SseSpecification
    {
        set => SetProperty("sse_specification", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVerifiedaccessTrustProviderTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
