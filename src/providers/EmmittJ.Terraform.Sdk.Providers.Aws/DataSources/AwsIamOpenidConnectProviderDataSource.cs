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
        this.WithOutput("client_id_list");
        this.WithOutput("thumbprint_list");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformProperty<string>? Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
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
