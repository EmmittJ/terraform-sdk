using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_public_ipv4_pool Terraform data source.
/// Retrieves information about a aws_ec2_public_ipv4_pool.
/// </summary>
public partial class AwsEc2PublicIpv4PoolDataSource(string name) : TerraformDataSource("aws_ec2_public_ipv4_pool", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolId is required")]
    public required TerraformValue<string> PoolId
    {
        get => GetArgument<TerraformValue<string>>("pool_id");
        set => SetArgument("pool_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformValue<string> NetworkBorderGroup
        => AsReference("network_border_group");

    /// <summary>
    /// The pool_address_ranges attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PoolAddressRanges
        => AsReference("pool_address_ranges");

    /// <summary>
    /// The total_address_count attribute.
    /// </summary>
    public TerraformValue<double> TotalAddressCount
        => AsReference("total_address_count");

    /// <summary>
    /// The total_available_address_count attribute.
    /// </summary>
    public TerraformValue<double> TotalAvailableAddressCount
        => AsReference("total_available_address_count");

}
