using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for topic in AwsSesv2ContactList.
/// Nesting mode: set
/// </summary>
public class AwsSesv2ContactListTopicBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "topic";

    /// <summary>
    /// The default_subscription_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSubscriptionStatus is required")]
    public required TerraformValue<string> DefaultSubscriptionStatus
    {
        get => new TerraformReference<string>(this, "default_subscription_status");
        set => SetArgument("default_subscription_status", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformValue<string> TopicName
    {
        get => new TerraformReference<string>(this, "topic_name");
        set => SetArgument("topic_name", value);
    }

}


/// <summary>
/// Represents a aws_sesv2_contact_list Terraform resource.
/// Manages a aws_sesv2_contact_list resource.
/// </summary>
public partial class AwsSesv2ContactList(string name) : TerraformResource("aws_sesv2_contact_list", name)
{
    /// <summary>
    /// The contact_list_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactListName is required")]
    public required TerraformValue<string> ContactListName
    {
        get => new TerraformReference<string>(this, "contact_list_name");
        set => SetArgument("contact_list_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformValue<string> CreatedTimestamp
    {
        get => new TerraformReference<string>(this, "created_timestamp");
    }

    /// <summary>
    /// The last_updated_timestamp attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTimestamp
    {
        get => new TerraformReference<string>(this, "last_updated_timestamp");
    }

    /// <summary>
    /// Topic block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsSesv2ContactListTopicBlock>? Topic
    {
        get => GetArgument<TerraformSet<AwsSesv2ContactListTopicBlock>>("topic");
        set => SetArgument("topic", value);
    }

}
