using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_email_channel resource.
/// </summary>
public class AwsPinpointEmailChannel : TerraformResource
{
    public AwsPinpointEmailChannel(string name) : base("aws_pinpoint_email_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("messages_per_second");
        SetOutput("application_id");
        SetOutput("configuration_set");
        SetOutput("enabled");
        SetOutput("from_address");
        SetOutput("id");
        SetOutput("identity");
        SetOutput("orchestration_sending_role_arn");
        SetOutput("region");
        SetOutput("role_arn");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    public TerraformProperty<string> ConfigurationSet
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_set");
        set => SetProperty("configuration_set", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The from_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromAddress is required")]
    public required TerraformProperty<string> FromAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("from_address");
        set => SetProperty("from_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Identity is required")]
    public required TerraformProperty<string> Identity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity");
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The orchestration_sending_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> OrchestrationSendingRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("orchestration_sending_role_arn");
        set => SetProperty("orchestration_sending_role_arn", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The messages_per_second attribute.
    /// </summary>
    public TerraformExpression MessagesPerSecond => this["messages_per_second"];

}
