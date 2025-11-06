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
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public string? Url
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url")?.Value;
        set => this.WithProperty("url", value == null ? null : new TerraformLiteralProperty<string>(value));
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
