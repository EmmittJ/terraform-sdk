using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpc_ipams.
/// </summary>
public class AwsVpcIpamsDataSource : TerraformDataSource
{
    public AwsVpcIpamsDataSource(string name) : base("aws_vpc_ipams", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ipams");
    }

    /// <summary>
    /// The ipam_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? IpamIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipam_ids");
        set => this.WithProperty("ipam_ids", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The ipams attribute.
    /// </summary>
    public TerraformExpression Ipams => this["ipams"];

}
