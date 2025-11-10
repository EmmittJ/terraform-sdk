using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_logging_options resource.
/// </summary>
public class AwsIotLoggingOptions : TerraformResource
{
    public AwsIotLoggingOptions(string name) : base("aws_iot_logging_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_log_level");
        SetOutput("disable_all_logs");
        SetOutput("id");
        SetOutput("region");
        SetOutput("role_arn");
    }

    /// <summary>
    /// The default_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogLevel is required")]
    public required TerraformProperty<string> DefaultLogLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_log_level");
        set => SetProperty("default_log_level", value);
    }

    /// <summary>
    /// The disable_all_logs attribute.
    /// </summary>
    public TerraformProperty<bool> DisableAllLogs
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_all_logs");
        set => SetProperty("disable_all_logs", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

}
