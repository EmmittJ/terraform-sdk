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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    public required TerraformValue<string> ServerId
    {
        get => GetArgument<TerraformValue<string>>("server_id");
        set => SetArgument("server_id", value);
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
        => AsReference("arn");

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformValue<string> Certificate
        => AsReference("certificate");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The endpoint_type attribute.
    /// </summary>
    public TerraformValue<string> EndpointType
        => AsReference("endpoint_type");

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    public TerraformValue<string> IdentityProviderType
        => AsReference("identity_provider_type");

    /// <summary>
    /// The invocation_role attribute.
    /// </summary>
    public TerraformValue<string> InvocationRole
        => AsReference("invocation_role");

    /// <summary>
    /// The logging_role attribute.
    /// </summary>
    public TerraformValue<string> LoggingRole
        => AsReference("logging_role");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformList<string> Protocols
        => AsReference("protocols");

    /// <summary>
    /// The security_policy_name attribute.
    /// </summary>
    public TerraformValue<string> SecurityPolicyName
        => AsReference("security_policy_name");

    /// <summary>
    /// The structured_log_destinations attribute.
    /// </summary>
    public TerraformList<string> StructuredLogDestinations
        => AsReference("structured_log_destinations");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

}
