using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for log_configurations in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// The event_source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventSource is required")]
    public required TerraformProperty<string> EventSource
    {
        set => SetProperty("event_source", value);
    }

    /// <summary>
    /// The log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogLevel is required")]
    public required TerraformProperty<string> LogLevel
    {
        set => SetProperty("log_level", value);
    }

}

/// <summary>
/// Manages a aws_cognito_log_delivery_configuration resource.
/// </summary>
public class AwsCognitoLogDeliveryConfiguration : TerraformResource
{
    public AwsCognitoLogDeliveryConfiguration(string name) : base("aws_cognito_log_delivery_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("region");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

    /// <summary>
    /// Block for log_configurations.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCognitoLogDeliveryConfigurationLogConfigurationsBlock>? LogConfigurations
    {
        set => SetProperty("log_configurations", value);
    }

}
