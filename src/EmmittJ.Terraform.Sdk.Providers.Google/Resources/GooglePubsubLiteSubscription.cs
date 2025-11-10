using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for delivery_config in .
/// Nesting mode: list
/// </summary>
public class GooglePubsubLiteSubscriptionDeliveryConfigBlock : TerraformBlock
{
    /// <summary>
    /// When this subscription should send messages to subscribers relative to messages persistence in storage. Possible values: [&amp;quot;DELIVER_IMMEDIATELY&amp;quot;, &amp;quot;DELIVER_AFTER_STORED&amp;quot;, &amp;quot;DELIVERY_REQUIREMENT_UNSPECIFIED&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryRequirement is required")]
    public required TerraformProperty<string> DeliveryRequirement
    {
        get => GetProperty<TerraformProperty<string>>("delivery_requirement");
        set => WithProperty("delivery_requirement", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GooglePubsubLiteSubscriptionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_pubsub_lite_subscription resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GooglePubsubLiteSubscription : TerraformResource
{
    public GooglePubsubLiteSubscription(string name) : base("google_pubsub_lite_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// Name of the subscription.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The region of the pubsub lite topic.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// A reference to a Topic resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformProperty<string> Topic
    {
        get => GetProperty<TerraformProperty<string>>("topic");
        set => this.WithProperty("topic", value);
    }

    /// <summary>
    /// The zone of the pubsub lite topic.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for delivery_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryConfig block(s) allowed")]
    public List<GooglePubsubLiteSubscriptionDeliveryConfigBlock>? DeliveryConfig
    {
        get => GetProperty<List<GooglePubsubLiteSubscriptionDeliveryConfigBlock>>("delivery_config");
        set => this.WithProperty("delivery_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GooglePubsubLiteSubscriptionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GooglePubsubLiteSubscriptionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
