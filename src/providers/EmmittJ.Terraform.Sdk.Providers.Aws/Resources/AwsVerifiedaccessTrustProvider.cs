using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for device_options in AwsVerifiedaccessTrustProvider.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderDeviceOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "device_options";

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for native_application_oidc_options in AwsVerifiedaccessTrustProvider.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "native_application_oidc_options";

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationEndpoint
    {
        get => GetArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The public_signing_key_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PublicSigningKeyEndpoint
    {
        get => GetArgument<TerraformValue<string>>("public_signing_key_endpoint");
        set => SetArgument("public_signing_key_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? UserInfoEndpoint
    {
        get => GetArgument<TerraformValue<string>>("user_info_endpoint");
        set => SetArgument("user_info_endpoint", value);
    }

}


/// <summary>
/// Block type for oidc_options in AwsVerifiedaccessTrustProvider.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderOidcOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_options";

    /// <summary>
    /// The authorization_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? AuthorizationEndpoint
    {
        get => GetArgument<TerraformValue<string>>("authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => GetArgument<TerraformValue<string>>("issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => GetArgument<TerraformValue<string>>("token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? UserInfoEndpoint
    {
        get => GetArgument<TerraformValue<string>>("user_info_endpoint");
        set => SetArgument("user_info_endpoint", value);
    }

}


/// <summary>
/// Block type for sse_specification in AwsVerifiedaccessTrustProvider.
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessTrustProviderSseSpecificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sse_specification";

    /// <summary>
    /// The customer_managed_key_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CustomerManagedKeyEnabled
    {
        get => GetArgument<TerraformValue<bool>>("customer_managed_key_enabled");
        set => SetArgument("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsVerifiedaccessTrustProvider.
/// Nesting mode: single
/// </summary>
public class AwsVerifiedaccessTrustProviderTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_verifiedaccess_trust_provider Terraform resource.
/// Manages a aws_verifiedaccess_trust_provider resource.
/// </summary>
public partial class AwsVerifiedaccessTrustProvider(string name) : TerraformResource("aws_verifiedaccess_trust_provider", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTrustProviderType
    {
        get => GetArgument<TerraformValue<string>>("device_trust_provider_type");
        set => SetArgument("device_trust_provider_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The policy_reference_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyReferenceName is required")]
    public required TerraformValue<string> PolicyReferenceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("policy_reference_name");
        set => SetArgument("policy_reference_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustProviderType is required")]
    public required TerraformValue<string> TrustProviderType
    {
        get => GetRequiredArgument<TerraformValue<string>>("trust_provider_type");
        set => SetArgument("trust_provider_type", value);
    }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    public TerraformValue<string>? UserTrustProviderType
    {
        get => GetArgument<TerraformValue<string>>("user_trust_provider_type");
        set => SetArgument("user_trust_provider_type", value);
    }

    /// <summary>
    /// DeviceOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessTrustProviderDeviceOptionsBlock>? DeviceOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessTrustProviderDeviceOptionsBlock>>("device_options");
        set => SetArgument("device_options", value);
    }

    /// <summary>
    /// NativeApplicationOidcOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NativeApplicationOidcOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock>? NativeApplicationOidcOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessTrustProviderNativeApplicationOidcOptionsBlock>>("native_application_oidc_options");
        set => SetArgument("native_application_oidc_options", value);
    }

    /// <summary>
    /// OidcOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcOptions block(s) allowed")]
    public TerraformList<AwsVerifiedaccessTrustProviderOidcOptionsBlock>? OidcOptions
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessTrustProviderOidcOptionsBlock>>("oidc_options");
        set => SetArgument("oidc_options", value);
    }

    /// <summary>
    /// SseSpecification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SseSpecification block(s) allowed")]
    public TerraformList<AwsVerifiedaccessTrustProviderSseSpecificationBlock>? SseSpecification
    {
        get => GetArgument<TerraformList<AwsVerifiedaccessTrustProviderSseSpecificationBlock>>("sse_specification");
        set => SetArgument("sse_specification", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsVerifiedaccessTrustProviderTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsVerifiedaccessTrustProviderTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
