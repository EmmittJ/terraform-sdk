using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth_request in AwsAppfabricAppAuthorizationConnection.
/// Nesting mode: list
/// </summary>
public class AwsAppfabricAppAuthorizationConnectionAuthRequestBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_request";

    /// <summary>
    /// The code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Code is required")]
    public required TerraformValue<string> Code
    {
        get => GetRequiredArgument<TerraformValue<string>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The redirect_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUri is required")]
    public required TerraformValue<string> RedirectUri
    {
        get => GetRequiredArgument<TerraformValue<string>>("redirect_uri");
        set => SetArgument("redirect_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsAppfabricAppAuthorizationConnection.
/// Nesting mode: single
/// </summary>
public class AwsAppfabricAppAuthorizationConnectionTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_appfabric_app_authorization_connection Terraform resource.
/// Manages a aws_appfabric_app_authorization_connection resource.
/// </summary>
public partial class AwsAppfabricAppAuthorizationConnection(string name) : TerraformResource("aws_appfabric_app_authorization_connection", name)
{
    /// <summary>
    /// The app_authorization_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppAuthorizationArn is required")]
    public required TerraformValue<string> AppAuthorizationArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_authorization_arn");
        set => SetArgument("app_authorization_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The app attribute.
    /// </summary>
    public TerraformValue<string> App
        => CreateReference("app");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The tenant attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Tenant
        => CreateReference("tenant");

    /// <summary>
    /// AuthRequest block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppfabricAppAuthorizationConnectionAuthRequestBlock>? AuthRequest
    {
        get => GetArgument<TerraformList<AwsAppfabricAppAuthorizationConnectionAuthRequestBlock>>("auth_request");
        set => SetArgument("auth_request", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAppfabricAppAuthorizationConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAppfabricAppAuthorizationConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
