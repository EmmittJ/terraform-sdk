using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_asset.
/// </summary>
public class AwsOutpostsAssetDataSource : TerraformDataSource
{
    public AwsOutpostsAssetDataSource(string name) : base("aws_outposts_asset", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("asset_type");
        this.DeclareOutput("host_id");
        this.DeclareOutput("rack_elevation");
        this.DeclareOutput("rack_id");
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
    /// The asset_id attribute.
    /// </summary>
    public string? AssetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("asset_id")?.Value;
        set => this.WithProperty("asset_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The asset_type attribute.
    /// </summary>
    public TerraformExpression AssetType => this["asset_type"];

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformExpression HostId => this["host_id"];

    /// <summary>
    /// The rack_elevation attribute.
    /// </summary>
    public TerraformExpression RackElevation => this["rack_elevation"];

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformExpression RackId => this["rack_id"];

}
