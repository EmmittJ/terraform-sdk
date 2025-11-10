using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_cloud_exadata_infrastructures.
/// </summary>
public class AwsOdbCloudExadataInfrastructuresDataSource : TerraformDataSource
{
    public AwsOdbCloudExadataInfrastructuresDataSource(string name) : base("aws_odb_cloud_exadata_infrastructures", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cloud_exadata_infrastructures");
        SetOutput("region");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// List of Cloud Exadata Infrastructures. Returns basic information about the Cloud Exadata Infrastructures.
    /// </summary>
    public TerraformExpression CloudExadataInfrastructures => this["cloud_exadata_infrastructures"];

}
