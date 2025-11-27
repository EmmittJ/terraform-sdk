using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsAppsyncSourceApiAssociation.
/// Nesting mode: single
/// </summary>
public class AwsAppsyncSourceApiAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_appsync_source_api_association Terraform resource.
/// Manages a aws_appsync_source_api_association resource.
/// </summary>
public partial class AwsAppsyncSourceApiAssociation(string name) : TerraformResource("aws_appsync_source_api_association", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The merged_api_arn attribute.
    /// </summary>
    public TerraformValue<string> MergedApiArn
    {
        get => new TerraformReference<string>(this, "merged_api_arn");
        set => SetArgument("merged_api_arn", value);
    }

    /// <summary>
    /// The merged_api_id attribute.
    /// </summary>
    public TerraformValue<string> MergedApiId
    {
        get => new TerraformReference<string>(this, "merged_api_id");
        set => SetArgument("merged_api_id", value);
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
    /// The source_api_arn attribute.
    /// </summary>
    public TerraformValue<string> SourceApiArn
    {
        get => new TerraformReference<string>(this, "source_api_arn");
        set => SetArgument("source_api_arn", value);
    }

    /// <summary>
    /// The source_api_association_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SourceApiAssociationConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "source_api_association_config").ResolveNodes(ctx));
        set => SetArgument("source_api_association_config", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformValue<string> SourceApiId
    {
        get => new TerraformReference<string>(this, "source_api_id");
        set => SetArgument("source_api_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
    {
        get => new TerraformReference<string>(this, "association_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsAppsyncSourceApiAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsAppsyncSourceApiAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
