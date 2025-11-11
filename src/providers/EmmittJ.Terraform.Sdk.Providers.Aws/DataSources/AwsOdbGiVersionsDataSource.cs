using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_gi_versions.
/// </summary>
public partial class AwsOdbGiVersionsDataSource : TerraformDataSource
{
    public AwsOdbGiVersionsDataSource(string name) : base("aws_odb_gi_versions", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The system shape.
    /// </summary>
    [TerraformProperty("shape")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Shape { get; set; }

    /// <summary>
    /// Information about a specific version of Oracle Grid Infrastructure (GI) software that can be installed on a VM cluster.
    /// </summary>
    [TerraformProperty("gi_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> GiVersions { get; }

}
