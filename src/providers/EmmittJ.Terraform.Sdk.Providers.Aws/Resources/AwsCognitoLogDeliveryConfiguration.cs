using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock : ITerraformBlock
{
    /// <summary>
    /// The event_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventSource is required")]
    [TerraformPropertyName("event_source")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventSource { get; set; }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogLevel is required")]
    [TerraformPropertyName("log_level")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LogLevel { get; set; }

}

/// <summary>
/// Manages a aws_cognito_log_delivery_configuration resource.
/// </summary>
public class AwsCognitoLogDeliveryConfiguration : TerraformResource
{
    public AwsCognitoLogDeliveryConfiguration(string name) : base("aws_cognito_log_delivery_configuration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// Block for log_configurations.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("log_configurations")]
    public TerraformList<TerraformBlock<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock>>? LogConfigurations { get; set; } = new();

}
