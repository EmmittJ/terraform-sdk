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
        get => GetRequiredArgument<TerraformValue<string>>("workspace_arn");
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
        get => GetArgument<TerraformValue<string>>("source_role_arn");
        set => SetArgument("source_role_arn", value);
    }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? TargetRoleArn
    {
        get => GetArgument<TerraformValue<string>>("target_role_arn");
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
        get => GetRequiredArgument<TerraformValue<string>>("cluster_arn");
        set => SetArgument("cluster_arn", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? CreateReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetIds is required")]
    public required TerraformSet<string> SubnetIds
    {
        get => GetRequiredArgument<TerraformSet<string>>("subnet_ids");
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scrape_configuration attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScrapeConfiguration is required")]
    public required TerraformValue<string> ScrapeConfiguration
    {
        get => GetRequiredArgument<TerraformValue<string>>("scrape_configuration");
        set => SetArgument("scrape_configuration", value);
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
        => CreateReference("arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

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
