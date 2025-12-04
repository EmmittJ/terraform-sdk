using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sesv2_dedicated_ip_pool Terraform data source.
/// Retrieves information about a aws_sesv2_dedicated_ip_pool.
/// </summary>
public partial class AwsSesv2DedicatedIpPoolDataSource(string name) : TerraformDataSource("aws_sesv2_dedicated_ip_pool", name)
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
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => GetArgument<TerraformValue<string>>("pool_name");
        set => SetArgument("pool_name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The dedicated_ips attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DedicatedIps
        => AsReference("dedicated_ips");

    /// <summary>
    /// The scaling_mode attribute.
    /// </summary>
    public TerraformValue<string> ScalingMode
        => AsReference("scaling_mode");

}
