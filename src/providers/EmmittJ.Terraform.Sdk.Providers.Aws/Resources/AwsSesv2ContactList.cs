using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for topic in .
/// Nesting mode: set
/// </summary>
public partial class AwsSesv2ContactListTopicBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_subscription_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultSubscriptionStatus is required")]
    [TerraformProperty("default_subscription_status")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DefaultSubscriptionStatus { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TopicName is required")]
    [TerraformProperty("topic_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TopicName { get; set; }

}

/// <summary>
/// Manages a aws_sesv2_contact_list resource.
/// </summary>
public partial class AwsSesv2ContactList : TerraformResource
{
    public AwsSesv2ContactList(string name) : base("aws_sesv2_contact_list", name)
    {
    }

    /// <summary>
    /// The contact_list_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactListName is required")]
    [TerraformProperty("contact_list_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContactListName { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for topic.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("topic")]
    public TerraformSet<TerraformBlock<AwsSesv2ContactListTopicBlock>>? Topic { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_timestamp attribute.
    /// </summary>
    [TerraformProperty("created_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedTimestamp { get; }

    /// <summary>
    /// The last_updated_timestamp attribute.
    /// </summary>
    [TerraformProperty("last_updated_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedTimestamp { get; }

}
