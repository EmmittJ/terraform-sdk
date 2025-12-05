using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_route53_zones Terraform data source.
/// Retrieves information about a aws_route53_zones.
/// </summary>
public partial class AwsRoute53ZonesDataSource(string name) : TerraformDataSource("aws_route53_zones", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformList<string> Ids
        => CreateReference("ids");

}
