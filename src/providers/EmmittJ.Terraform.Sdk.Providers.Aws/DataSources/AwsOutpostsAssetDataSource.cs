using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_asset.
/// </summary>
public partial class AwsOutpostsAssetDataSource : TerraformDataSource
{
    public AwsOutpostsAssetDataSource(string name) : base("aws_outposts_asset", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssetId is required")]
    [TerraformProperty("asset_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AssetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The asset_type attribute.
    /// </summary>
    [TerraformProperty("asset_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AssetType { get; }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformProperty("host_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> HostId { get; }

    /// <summary>
    /// The rack_elevation attribute.
    /// </summary>
    [TerraformProperty("rack_elevation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> RackElevation { get; }

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    [TerraformProperty("rack_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RackId { get; }

}
