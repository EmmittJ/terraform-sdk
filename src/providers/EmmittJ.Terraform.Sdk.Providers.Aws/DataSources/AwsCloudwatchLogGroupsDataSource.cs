using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_groups Terraform data source.
/// Retrieves information about a aws_cloudwatch_log_groups.
/// </summary>
public partial class AwsCloudwatchLogGroupsDataSource(string name) : TerraformDataSource("aws_cloudwatch_log_groups", name)
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
    /// The log_group_name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? LogGroupNamePrefix
    {
        get => new TerraformReference<string>(this, "log_group_name_prefix");
        set => SetArgument("log_group_name_prefix", value);
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
    /// The arns attribute.
    /// </summary>
    public TerraformSet<string> Arns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "arns").ResolveNodes(ctx));
    }

    /// <summary>
    /// The log_group_names attribute.
    /// </summary>
    public TerraformSet<string> LogGroupNames
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "log_group_names").ResolveNodes(ctx));
    }

}
