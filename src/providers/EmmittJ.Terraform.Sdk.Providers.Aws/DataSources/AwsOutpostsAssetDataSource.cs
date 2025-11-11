using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_asset.
/// </summary>
public class AwsOutpostsAssetDataSource : TerraformDataSource
{
    public AwsOutpostsAssetDataSource(string name) : base("aws_outposts_asset", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The asset_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AssetId is required")]
    [TerraformPropertyName("asset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AssetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The asset_type attribute.
    /// </summary>
    [TerraformPropertyName("asset_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AssetType => new TerraformReference(this, "asset_type");

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    [TerraformPropertyName("host_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> HostId => new TerraformReference(this, "host_id");

    /// <summary>
    /// The rack_elevation attribute.
    /// </summary>
    [TerraformPropertyName("rack_elevation")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> RackElevation => new TerraformReference(this, "rack_elevation");

    /// <summary>
    /// The rack_id attribute.
    /// </summary>
    [TerraformPropertyName("rack_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RackId => new TerraformReference(this, "rack_id");

}
