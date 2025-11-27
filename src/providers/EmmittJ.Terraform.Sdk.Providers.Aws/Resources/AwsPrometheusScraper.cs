using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination in AwsPrometheusScraper.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// Amp block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusScraperDestinationBlockAmpBlock>? Amp
    {
        get => GetArgument<TerraformList<AwsPrometheusScraperDestinationBlockAmpBlock>>("amp");
        set => SetArgument("amp", value);
    }

}

/// <summary>
/// Block type for amp in AwsPrometheusScraperDestinationBlock.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperDestinationBlockAmpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amp";

    /// <summary>
    /// The workspace_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceArn is required")]
    public required TerraformValue<string> WorkspaceArn
    {
        get => new TerraformReference<string>(this, "workspace_arn");
        set => SetArgument("workspace_arn", value);
    }

}


/// <summary>
/// Block type for role_configuration in AwsPrometheusScraper.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperRoleConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "role_configuration";

    /// <summary>
    /// The source_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceRoleArn
    {
        get => new TerraformReference<string>(this, "source_role_arn");
        set => SetArgument("source_role_arn", value);
    }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? TargetRoleArn
    {
        get => new TerraformReference<string>(this, "target_role_arn");
        set => SetArgument("target_role_arn", value);
    }

}


/// <summary>
/// Block type for source in AwsPrometheusScraper.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// Eks block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusScraperSourceBlockEksBlock>? Eks
    {
        get => GetArgument<TerraformList<AwsPrometheusScraperSourceBlockEksBlock>>("eks");
        set => SetArgument("eks", value);
    }

}

/// <summary>
/// Block type for eks in AwsPrometheusScraperSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsPrometheusScraperSourceBlockEksBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eks";

    /// <summary>
    /// The cluster_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterArn is required")]
    public required TerraformValue<string> ClusterArn
    {
        get => new TerraformReference<string>(this, "cluster_arn");
        set => SetArgument("cluster_arn", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsPrometheusScraper.
/// Nesting mode: single
/// </summary>
public class AwsPrometheusScraperTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_prometheus_scraper Terraform resource.
/// Manages a aws_prometheus_scraper resource.
/// </summary>
public partial class AwsPrometheusScraper(string name) : TerraformResource("aws_prometheus_scraper", name)
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string>? Alias
    {
        get => new TerraformReference<string>(this, "alias");
        set => SetArgument("alias", value);
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
    /// The scrape_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScrapeConfiguration is required")]
    public required TerraformValue<string> ScrapeConfiguration
    {
        get => new TerraformReference<string>(this, "scrape_configuration");
        set => SetArgument("scrape_configuration", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// Destination block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusScraperDestinationBlock>? Destination
    {
        get => GetArgument<TerraformList<AwsPrometheusScraperDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// RoleConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusScraperRoleConfigurationBlock>? RoleConfiguration
    {
        get => GetArgument<TerraformList<AwsPrometheusScraperRoleConfigurationBlock>>("role_configuration");
        set => SetArgument("role_configuration", value);
    }

    /// <summary>
    /// Source block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsPrometheusScraperSourceBlock>? Source
    {
        get => GetArgument<TerraformList<AwsPrometheusScraperSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsPrometheusScraperTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsPrometheusScraperTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
