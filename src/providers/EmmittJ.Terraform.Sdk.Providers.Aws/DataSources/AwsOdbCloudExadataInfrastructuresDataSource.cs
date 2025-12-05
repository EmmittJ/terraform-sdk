using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_odb_cloud_exadata_infrastructures Terraform data source.
/// Retrieves information about a aws_odb_cloud_exadata_infrastructures.
/// </summary>
public partial class AwsOdbCloudExadataInfrastructuresDataSource(string name) : TerraformDataSource("aws_odb_cloud_exadata_infrastructures", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// List of Cloud Exadata Infrastructures. Returns basic information about the Cloud Exadata Infrastructures.
    /// </summary>
    public TerraformList<TerraformMap<object>> CloudExadataInfrastructures
        => CreateReference("cloud_exadata_infrastructures");

}
