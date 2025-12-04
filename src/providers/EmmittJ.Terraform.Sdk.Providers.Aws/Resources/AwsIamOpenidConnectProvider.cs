using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iam_openid_connect_provider Terraform resource.
/// Manages a aws_iam_openid_connect_provider resource.
/// </summary>
public partial class AwsIamOpenidConnectProvider(string name) : TerraformResource("aws_iam_openid_connect_provider", name)
{
    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientIdList is required")]
    public required TerraformSet<string> ClientIdList
    {
        get => GetRequiredArgument<TerraformSet<string>>("client_id_list");
        set => SetArgument("client_id_list", value);
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
    /// The thumbprint_list attribute.
    /// </summary>
    public TerraformList<string> ThumbprintList
    {
        get => GetArgument<TerraformList<string>>("thumbprint_list") ?? AsReference("thumbprint_list");
        set => SetArgument("thumbprint_list", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformValue<string> Url
    {
        get => GetRequiredArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
