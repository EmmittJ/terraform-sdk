using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_assets.
/// </summary>
public class AwsOutpostsAssetsDataSource : TerraformDataSource
{
    public AwsOutpostsAssetsDataSource(string name) : base("aws_outposts_assets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("asset_ids");
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
    /// The host_id_filter attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? HostIdFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("host_id_filter");
        set => this.WithProperty("host_id_filter", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The status_id_filter attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? StatusIdFilter
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("status_id_filter");
        set => this.WithProperty("status_id_filter", value);
    }

    /// <summary>
    /// The asset_ids attribute.
    /// </summary>
    public TerraformExpression AssetIds => this["asset_ids"];

}
