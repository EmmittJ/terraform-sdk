using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_exadata_infrastructures.
/// </summary>
public partial class AwsOdbCloudExadataInfrastructuresDataSource : TerraformDataSource
{
    public AwsOdbCloudExadataInfrastructuresDataSource(string name) : base("aws_odb_cloud_exadata_infrastructures", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// List of Cloud Exadata Infrastructures. Returns basic information about the Cloud Exadata Infrastructures.
    /// </summary>
    [TerraformProperty("cloud_exadata_infrastructures")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CloudExadataInfrastructures { get; }

}
