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
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssetId is required")]
    public required TerraformValue<string> AssetId
    {
        get => GetArgument<TerraformValue<string>>("asset_id");
        set => SetArgument("asset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The asset_type attribute.
    /// </summary>
    public TerraformValue<string> AssetType
        => AsReference("asset_type");

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformValue<string> HostId
        => AsReference("host_id");

    /// <summary>
    /// The rack_elevation attribute.
    /// </summary>
    public TerraformValue<double> RackElevation
        => AsReference("rack_elevation");

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    public TerraformValue<string> RackId
        => AsReference("rack_id");

}
