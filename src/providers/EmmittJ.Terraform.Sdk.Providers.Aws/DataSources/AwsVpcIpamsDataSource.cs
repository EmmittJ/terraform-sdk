using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsVpcIpamsDataSource.
/// Nesting mode: set
/// </summary>
public class AwsVpcIpamsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_vpc_ipams Terraform data source.
/// Retrieves information about a aws_vpc_ipams.
/// </summary>
public partial class AwsVpcIpamsDataSource(string name) : TerraformDataSource("aws_vpc_ipams", name)
{
    /// <summary>
    /// The ipam_ids attribute.
    /// </summary>
    public TerraformList<string>? IpamIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "ipam_ids").ResolveNodes(ctx));
        set => SetArgument("ipam_ids", value);
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
    /// The ipams attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ipams
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ipams").ResolveNodes(ctx));
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsVpcIpamsDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsVpcIpamsDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
