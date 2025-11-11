using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_outposts_assets.
/// </summary>
public partial class AwsOutpostsAssetsDataSource : TerraformDataSource
{
    public AwsOutpostsAssetsDataSource(string name) : base("aws_outposts_assets", name)
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
    /// The host_id_filter attribute.
    /// </summary>
    [TerraformProperty("host_id_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? HostIdFilter { get; set; }

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
    /// The status_id_filter attribute.
    /// </summary>
    [TerraformProperty("status_id_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? StatusIdFilter { get; set; }

    /// <summary>
    /// The asset_ids attribute.
    /// </summary>
    [TerraformProperty("asset_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AssetIds { get; }

}
