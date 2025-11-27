using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsRoute53ResolverQueryLogConfigDataSource.
/// Nesting mode: set
/// </summary>
public class AwsRoute53ResolverQueryLogConfigDataSourceFilterBlock : TerraformBlock
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
/// Represents a aws_route53_resolver_query_log_config Terraform data source.
/// Retrieves information about a aws_route53_resolver_query_log_config.
/// </summary>
public partial class AwsRoute53ResolverQueryLogConfigDataSource(string name) : TerraformDataSource("aws_route53_resolver_query_log_config", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The resolver_query_log_config_id attribute.
    /// </summary>
    public TerraformValue<string>? ResolverQueryLogConfigId
    {
        get => new TerraformReference<string>(this, "resolver_query_log_config_id");
        set => SetArgument("resolver_query_log_config_id", value);
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
    /// The destination_arn attribute.
    /// </summary>
    public TerraformValue<string> DestinationArn
    {
        get => new TerraformReference<string>(this, "destination_arn");
    }

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
    {
        get => new TerraformReference<string>(this, "owner_id");
    }

    /// <summary>
    /// The share_status attribute.
    /// </summary>
    public TerraformValue<string> ShareStatus
    {
        get => new TerraformReference<string>(this, "share_status");
    }

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRoute53ResolverQueryLogConfigDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsRoute53ResolverQueryLogConfigDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}
