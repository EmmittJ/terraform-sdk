using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_outposts_asset Terraform data source.
/// Retrieves information about a aws_outposts_asset.
/// </summary>
public partial class AwsOutpostsAssetDataSource(string name) : TerraformDataSource("aws_outposts_asset", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssetId is required")]
    public required TerraformValue<string> AssetId
    {
        get => new TerraformReference<string>(this, "asset_id");
        set => SetArgument("asset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The asset_type attribute.
    /// </summary>
    public TerraformValue<string> AssetType
    {
        get => new TerraformReference<string>(this, "asset_type");
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
    {
        get => new TerraformReference<string>(this, "host_id");
    }

    /// <summary>
    /// The rack_elevation attribute.
    /// </summary>
    public TerraformValue<double> RackElevation
    {
        get => new TerraformReference<double>(this, "rack_elevation");
    }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformValue<string> RackId
    {
        get => new TerraformReference<string>(this, "rack_id");
    }

}
