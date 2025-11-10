using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_exadata_infrastructures.
/// </summary>
public class AwsOdbCloudExadataInfrastructuresDataSource : TerraformDataSource
{
    public AwsOdbCloudExadataInfrastructuresDataSource(string name) : base("aws_odb_cloud_exadata_infrastructures", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// List of Cloud Exadata Infrastructures. Returns basic information about the Cloud Exadata Infrastructures.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructures")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CloudExadataInfrastructures => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cloud_exadata_infrastructures");

}
