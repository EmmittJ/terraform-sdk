using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_openid_connect_provider resource.
/// </summary>
public class AwsIamOpenidConnectProvider : TerraformResource
{
    public AwsIamOpenidConnectProvider(string name) : base("aws_iam_openid_connect_provider", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The client_id_list attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ClientIdList
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("client_id_list");
        set => this.WithProperty("client_id_list", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The thumbprint_list attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ThumbprintList
    {
        get => GetProperty<TerraformProperty<List<string>>>("thumbprint_list");
        set => this.WithProperty("thumbprint_list", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
