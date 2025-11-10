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
        SetOutput("asset_type");
        SetOutput("host_id");
        SetOutput("rack_elevation");
        SetOutput("rack_id");
        SetOutput("arn");
        SetOutput("asset_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssetId is required")]
    public required TerraformProperty<string> AssetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("asset_id");
        set => SetProperty("asset_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
