using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credential in AwsAppfabricAppAuthorization.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credential";

    /// <summary>
    /// ApiKeyCredential block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricAppAuthorizationCredentialBlockApiKeyCredentialBlock>? ApiKeyCredential
    {
        get => GetArgument<TerraformList<AwsAppfabricAppAuthorizationCredentialBlockApiKeyCredentialBlock>>("api_key_credential");
        set => SetArgument("api_key_credential", value);
    }

    /// <summary>
    /// Oauth2Credential block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricAppAuthorizationCredentialBlockOauth2CredentialBlock>? Oauth2Credential
    {
        get => GetArgument<TerraformList<AwsAppfabricAppAuthorizationCredentialBlockOauth2CredentialBlock>>("oauth2_credential");
        set => SetArgument("oauth2_credential", value);
    }

}

/// <summary>
/// Block type for api_key_credential in AwsAppfabricAppAuthorizationCredentialBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationCredentialBlockApiKeyCredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "api_key_credential";

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

}

/// <summary>
/// Block type for oauth2_credential in AwsAppfabricAppAuthorizationCredentialBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationCredentialBlockOauth2CredentialBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oauth2_credential";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
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

}


/// <summary>
/// Block type for tenant in AwsAppfabricAppAuthorization.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationTenantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tenant";

    /// <summary>
    /// The tenant_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantDisplayName is required")]
    public required TerraformValue<string> TenantDisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_display_name");
        set => SetArgument("tenant_display_name", value);
    }

    /// <summary>
    /// The tenant_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantIdentifier is required")]
    public required TerraformValue<string> TenantIdentifier
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_identifier");
        set => SetArgument("tenant_identifier", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAppfabricAppAuthorization.
/// Nesting mode: single
/// </summary>
public class AwsAppfabricAppAuthorizationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_appfabric_app_authorization Terraform resource.
/// Manages a aws_appfabric_app_authorization resource.
/// </summary>
public partial class AwsAppfabricAppAuthorization(string name) : TerraformResource("aws_appfabric_app_authorization", name)
{
    /// <summary>
    /// The app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "App is required")]
    public required TerraformValue<string> App
    {
        get => GetRequiredArgument<TerraformValue<string>>("app");
        set => SetArgument("app", value);
    }

    /// <summary>
    /// The app_bundle_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppBundleArn is required")]
    public required TerraformValue<string> AppBundleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_bundle_arn");
        set => SetArgument("app_bundle_arn", value);
    }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetRequiredArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auth_url attribute.
    /// </summary>
    public TerraformValue<string> AuthUrl
        => CreateReference("auth_url");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => CreateReference("created_at");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The persona attribute.
    /// </summary>
    public TerraformValue<string> Persona
        => CreateReference("persona");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => CreateReference("updated_at");

    /// <summary>
    /// Credential block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricAppAuthorizationCredentialBlock>? Credential
    {
        get => GetArgument<TerraformList<AwsAppfabricAppAuthorizationCredentialBlock>>("credential");
        set => SetArgument("credential", value);
    }

    /// <summary>
    /// Tenant block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricAppAuthorizationTenantBlock>? Tenant
    {
        get => GetArgument<TerraformList<AwsAppfabricAppAuthorizationTenantBlock>>("tenant");
        set => SetArgument("tenant", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAppfabricAppAuthorizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAppfabricAppAuthorizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
