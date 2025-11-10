using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_odb_networks.
/// </summary>
public class AwsOdbNetworksDataSource : TerraformDataSource
{
    public AwsOdbNetworksDataSource(string name) : base("aws_odb_networks", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("odb_networks");
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
    /// List of odb networks returns basic information about odb networks.
    /// </summary>
    public TerraformExpression OdbNetworks => this["odb_networks"];

}
