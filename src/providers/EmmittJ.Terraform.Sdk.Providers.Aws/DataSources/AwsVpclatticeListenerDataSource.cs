using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_listener.
/// </summary>
public partial class AwsVpclatticeListenerDataSource : TerraformDataSource
{
    public AwsVpclatticeListenerDataSource(string name) : base("aws_vpclattice_listener", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The listener_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListenerIdentifier is required")]
    [TerraformProperty("listener_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ListenerIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceIdentifier is required")]
    [TerraformProperty("service_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceIdentifier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    [TerraformProperty("default_action")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DefaultAction { get; }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    [TerraformProperty("last_updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastUpdatedAt { get; }

    /// <summary>
    /// The listener_id attribute.
    /// </summary>
    [TerraformProperty("listener_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ListenerId { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Port { get; }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [TerraformProperty("protocol")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Protocol { get; }

    /// <summary>
    /// The service_arn attribute.
    /// </summary>
    [TerraformProperty("service_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceArn { get; }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [TerraformProperty("service_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceId { get; }

}
