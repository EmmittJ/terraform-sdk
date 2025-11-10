using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for topic in .
/// Nesting mode: set
/// </summary>
public class AwsSesv2ContactListTopicBlock : TerraformBlock
{
    /// <summary>
    /// The default_subscription_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSubscriptionStatus is required")]
    public required TerraformProperty<string> DefaultSubscriptionStatus
    {
        get => GetRequiredProperty<TerraformProperty<string>>("default_subscription_status");
        set => WithProperty("default_subscription_status", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    public required TerraformProperty<string> TopicName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("topic_name");
        set => WithProperty("topic_name", value);
    }

}

/// <summary>
/// Manages a aws_sesv2_contact_list resource.
/// </summary>
public class AwsSesv2ContactList : TerraformResource
{
    public AwsSesv2ContactList(string name) : base("aws_sesv2_contact_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("created_timestamp");
        this.WithOutput("last_updated_timestamp");
    }

    /// <summary>
    /// The contact_list_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactListName is required")]
    public required TerraformProperty<string> ContactListName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("contact_list_name");
        set => this.WithProperty("contact_list_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for topic.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsSesv2ContactListTopicBlock>? Topic
    {
        get => GetProperty<HashSet<AwsSesv2ContactListTopicBlock>>("topic");
        set => this.WithProperty("topic", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    public TerraformExpression CreatedTimestamp => this["created_timestamp"];

    /// <summary>
    /// The last_updated_timestamp attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTimestamp => this["last_updated_timestamp"];

}
