using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_openid_connect_provider Terraform data source.
/// Retrieves information about a aws_iam_openid_connect_provider.
/// </summary>
public partial class AwsIamOpenidConnectProviderDataSource(string name) : TerraformDataSource("aws_iam_openid_connect_provider", name)
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    public TerraformList<string> ClientIdList
        => AsReference("client_id_list");

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    public TerraformList<string> ThumbprintList
        => AsReference("thumbprint_list");

}
