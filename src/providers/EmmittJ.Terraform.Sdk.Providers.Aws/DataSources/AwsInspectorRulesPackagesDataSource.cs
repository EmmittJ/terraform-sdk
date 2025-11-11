using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_inspector_rules_packages.
/// </summary>
public partial class AwsInspectorRulesPackagesDataSource : TerraformDataSource
{
    public AwsInspectorRulesPackagesDataSource(string name) : base("aws_inspector_rules_packages", name)
    {
    }

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
    /// The arns attribute.
    /// </summary>
    [TerraformProperty("arns")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> Arns { get; }

}
