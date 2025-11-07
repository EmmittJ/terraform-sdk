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
        this.DeclareOutput("client_id_list");
        this.DeclareOutput("thumbprint_list");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url");
        set => this.WithProperty("url", value);
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
