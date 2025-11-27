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
        get => new TerraformReference<string>(this, "tenant_id");
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
        get => new TerraformReference<string>(this, "authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The public_signing_key_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? PublicSigningKeyEndpoint
    {
        get => new TerraformReference<string>(this, "public_signing_key_endpoint");
        set => SetArgument("public_signing_key_endpoint", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => new TerraformReference<string>(this, "token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? UserInfoEndpoint
    {
        get => new TerraformReference<string>(this, "user_info_endpoint");
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
        get => new TerraformReference<string>(this, "authorization_endpoint");
        set => SetArgument("authorization_endpoint", value);
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformValue<string> ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string>? Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
        set => SetArgument("issuer", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The token_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? TokenEndpoint
    {
        get => new TerraformReference<string>(this, "token_endpoint");
        set => SetArgument("token_endpoint", value);
    }

    /// <summary>
    /// The user_info_endpoint attribute.
    /// </summary>
    public TerraformValue<string>? UserInfoEndpoint
    {
        get => new TerraformReference<string>(this, "user_info_endpoint");
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
        get => new TerraformReference<bool>(this, "customer_managed_key_enabled");
        set => SetArgument("customer_managed_key_enabled", value);
    }

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => new TerraformReference<string>(this, "kms_key_arn");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The device_trust_provider_type attribute.
    /// </summary>
    public TerraformValue<string>? DeviceTrustProviderType
    {
        get => new TerraformReference<string>(this, "device_trust_provider_type");
        set => SetArgument("device_trust_provider_type", value);
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
    /// The policy_reference_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyReferenceName is required")]
    public required TerraformValue<string> PolicyReferenceName
    {
        get => new TerraformReference<string>(this, "policy_reference_name");
        set => SetArgument("policy_reference_name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The trust_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustProviderType is required")]
    public required TerraformValue<string> TrustProviderType
    {
        get => new TerraformReference<string>(this, "trust_provider_type");
        set => SetArgument("trust_provider_type", value);
    }

    /// <summary>
    /// The user_trust_provider_type attribute.
    /// </summary>
    public TerraformValue<string>? UserTrustProviderType
    {
        get => new TerraformReference<string>(this, "user_trust_provider_type");
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
