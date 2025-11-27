using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_server Terraform data source.
/// Retrieves information about a aws_transfer_server.
/// </summary>
public partial class AwsTransferServerDataSource(string name) : TerraformDataSource("aws_transfer_server", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => new TerraformReference<string>(this, "server_id");
        set => SetArgument("server_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointType
    {
        get => new TerraformReference<string>(this, "endpoint_type");
    }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityProviderType
    {
        get => new TerraformReference<string>(this, "identity_provider_type");
    }

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformValue<string> InvocationRole
    {
        get => new TerraformReference<string>(this, "invocation_role");
    }

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string> LoggingRole
    {
        get => new TerraformReference<string>(this, "logging_role");
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformList<string> Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicyName
    {
        get => new TerraformReference<string>(this, "security_policy_name");
    }

    /// <summary>
    /// The structured_log_destinations attribute.
    /// </summary>
    public TerraformList<string> StructuredLogDestinations
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "structured_log_destinations").ResolveNodes(ctx));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
    {
        get => new TerraformReference<string>(this, "url");
    }

}
