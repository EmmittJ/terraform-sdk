using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in AwsSecuritylakeSubscriber.
/// Nesting mode: set
/// </summary>
public class AwsSecuritylakeSubscriberSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// AwsLogSourceResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeSubscriberSourceBlockAwsLogSourceResourceBlock>? AwsLogSourceResource
    {
        get => GetArgument<TerraformList<AwsSecuritylakeSubscriberSourceBlockAwsLogSourceResourceBlock>>("aws_log_source_resource");
        set => SetArgument("aws_log_source_resource", value);
    }

    /// <summary>
    /// CustomLogSourceResource block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeSubscriberSourceBlockCustomLogSourceResourceBlock>? CustomLogSourceResource
    {
        get => GetArgument<TerraformList<AwsSecuritylakeSubscriberSourceBlockCustomLogSourceResourceBlock>>("custom_log_source_resource");
        set => SetArgument("custom_log_source_resource", value);
    }

}

/// <summary>
/// Block type for aws_log_source_resource in AwsSecuritylakeSubscriberSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberSourceBlockAwsLogSourceResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_log_source_resource";

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformValue<string> SourceVersion
    {
        get => GetArgument<TerraformValue<string>>("source_version") ?? CreateReference("source_version");
        set => SetArgument("source_version", value);
    }

}

/// <summary>
/// Block type for custom_log_source_resource in AwsSecuritylakeSubscriberSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberSourceBlockCustomLogSourceResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_log_source_resource";

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Attributes
        => CreateReference("attributes");

    /// <summary>
    /// The provider attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProviderAttribute
        => CreateReference("provider");

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformValue<string> SourceVersion
    {
        get => GetArgument<TerraformValue<string>>("source_version") ?? CreateReference("source_version");
        set => SetArgument("source_version", value);
    }

}


/// <summary>
/// Block type for subscriber_identity in AwsSecuritylakeSubscriber.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberSubscriberIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subscriber_identity";

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformValue<string> ExternalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => GetRequiredArgument<TerraformValue<string>>("principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsSecuritylakeSubscriber.
/// Nesting mode: single
/// </summary>
public class AwsSecuritylakeSubscriberTimeoutsBlock : TerraformBlock
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
/// Represents a aws_securitylake_subscriber Terraform resource.
/// Manages a aws_securitylake_subscriber resource.
/// </summary>
public partial class AwsSecuritylakeSubscriber(string name) : TerraformResource("aws_securitylake_subscriber", name)
{
    /// <summary>
    /// The access_type attribute.
    /// </summary>
    public TerraformValue<string> AccessType
    {
        get => GetArgument<TerraformValue<string>>("access_type") ?? CreateReference("access_type");
        set => SetArgument("access_type", value);
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
    /// The subscriber_description attribute.
    /// </summary>
    public TerraformValue<string>? SubscriberDescription
    {
        get => GetArgument<TerraformValue<string>>("subscriber_description");
        set => SetArgument("subscriber_description", value);
    }

    /// <summary>
    /// The subscriber_name attribute.
    /// </summary>
    public TerraformValue<string>? SubscriberName
    {
        get => GetArgument<TerraformValue<string>>("subscriber_name");
        set => SetArgument("subscriber_name", value);
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
    /// The resource_share_arn attribute.
    /// </summary>
    public TerraformValue<string> ResourceShareArn
        => CreateReference("resource_share_arn");

    /// <summary>
    /// The resource_share_name attribute.
    /// </summary>
    public TerraformValue<string> ResourceShareName
        => CreateReference("resource_share_name");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    public TerraformValue<string> S3BucketArn
        => CreateReference("s3_bucket_arn");

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    public TerraformValue<string> SubscriberEndpoint
        => CreateReference("subscriber_endpoint");

    /// <summary>
    /// The subscriber_status attribute.
    /// </summary>
    public TerraformValue<string> SubscriberStatus
        => CreateReference("subscriber_status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => CreateReference("tags_all");

    /// <summary>
    /// Source block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSecuritylakeSubscriberSourceBlock>? Source
    {
        get => GetArgument<TerraformSet<AwsSecuritylakeSubscriberSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// SubscriberIdentity block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeSubscriberSubscriberIdentityBlock>? SubscriberIdentity
    {
        get => GetArgument<TerraformList<AwsSecuritylakeSubscriberSubscriberIdentityBlock>>("subscriber_identity");
        set => SetArgument("subscriber_identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsSecuritylakeSubscriberTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsSecuritylakeSubscriberTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
