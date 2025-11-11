using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_fis_experiment_templates.
/// </summary>
public partial class AwsFisExperimentTemplatesDataSource : TerraformDataSource
{
    public AwsFisExperimentTemplatesDataSource(string name) : base("aws_fis_experiment_templates", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    [TerraformProperty("ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Ids { get; }

}
