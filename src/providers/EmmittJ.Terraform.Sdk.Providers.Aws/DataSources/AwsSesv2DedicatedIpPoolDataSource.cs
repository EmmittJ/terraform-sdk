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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The pool_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PoolName is required")]
    public required TerraformValue<string> PoolName
    {
        get => new TerraformReference<string>(this, "pool_name");
        set => SetArgument("pool_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The dedicated_ips attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DedicatedIps
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "dedicated_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// The scaling_mode attribute.
    /// </summary>
    public TerraformValue<string> ScalingMode
    {
        get => new TerraformReference<string>(this, "scaling_mode");
    }

}
