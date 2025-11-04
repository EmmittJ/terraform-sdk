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
    public List<string>? IpamIds
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipam_ids")?.Value;
        set => this.WithProperty("ipam_ids", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The ipams attribute.
    /// </summary>
    public TerraformExpression Ipams => this["ipams"];

}
