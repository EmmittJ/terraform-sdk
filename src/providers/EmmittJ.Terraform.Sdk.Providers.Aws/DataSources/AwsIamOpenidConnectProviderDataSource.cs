using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_openid_connect_provider.
/// </summary>
public class AwsIamOpenidConnectProviderDataSource : TerraformDataSource
{
    public AwsIamOpenidConnectProviderDataSource(string name) : base("aws_iam_openid_connect_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("client_id_list");
        SetOutput("thumbprint_list");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("url");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string> Url
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url");
        set => SetProperty("url", value);
    }

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    public TerraformExpression ClientIdList => this["client_id_list"];

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    public TerraformExpression ThumbprintList => this["thumbprint_list"];

}
