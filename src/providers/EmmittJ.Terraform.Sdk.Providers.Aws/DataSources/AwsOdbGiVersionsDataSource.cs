using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_gi_versions.
/// </summary>
public class AwsOdbGiVersionsDataSource : TerraformDataSource
{
    public AwsOdbGiVersionsDataSource(string name) : base("aws_odb_gi_versions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("gi_versions");
        SetOutput("region");
        SetOutput("shape");
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
    /// The system shape.
    /// </summary>
    public TerraformProperty<string> Shape
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shape");
        set => SetProperty("shape", value);
    }

    /// <summary>
    /// Information about a specific version of Oracle Grid Infrastructure (GI) software that can be installed on a VM cluster.
    /// </summary>
    public TerraformExpression GiVersions => this["gi_versions"];

}
