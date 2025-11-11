using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_assets.
/// </summary>
public class AwsOutpostsAssetsDataSource : TerraformDataSource
{
    public AwsOutpostsAssetsDataSource(string name) : base("aws_outposts_assets", name)
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
    /// The host_id_filter attribute.
    /// </summary>
    [TerraformPropertyName("host_id_filter")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? HostIdFilter { get; set; }

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
    /// The status_id_filter attribute.
    /// </summary>
    [TerraformPropertyName("status_id_filter")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? StatusIdFilter { get; set; }

    /// <summary>
    /// The asset_ids attribute.
    /// </summary>
    [TerraformPropertyName("asset_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AssetIds => new TerraformReference(this, "asset_ids");

}
