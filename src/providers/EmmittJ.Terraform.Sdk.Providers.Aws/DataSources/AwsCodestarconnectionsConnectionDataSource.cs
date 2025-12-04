using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codestarconnections_connection Terraform data source.
/// Retrieves information about a aws_codestarconnections_connection.
/// </summary>
public partial class AwsCodestarconnectionsConnectionDataSource(string name) : TerraformDataSource("aws_codestarconnections_connection", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The connection_status attribute.
    /// </summary>
    public TerraformValue<string> ConnectionStatus
        => AsReference("connection_status");

    /// <summary>
    /// The host_arn attribute.
    /// </summary>
    public TerraformValue<string> HostArn
        => AsReference("host_arn");

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public TerraformValue<string> ProviderType
        => AsReference("provider_type");

}
