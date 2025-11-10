using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeSubscriberNotificationConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_securitylake_subscriber_notification resource.
/// </summary>
public class AwsSecuritylakeSubscriberNotification : TerraformResource
{
    public AwsSecuritylakeSubscriberNotification(string name) : base("aws_securitylake_subscriber_notification", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The subscriber_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubscriberId is required")]
    [TerraformPropertyName("subscriber_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubscriberId { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsSecuritylakeSubscriberNotificationConfigurationBlock>>? Configuration { get; set; } = new();

    /// <summary>
    /// The endpoint_id attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EndpointId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("subscriber_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SubscriberEndpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subscriber_endpoint");

}
