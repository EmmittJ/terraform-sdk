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
    }

    /// <summary>
    /// The default_log_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DefaultLogLevel is required")]
    public required TerraformProperty<string> DefaultLogLevel
    {
        get => GetProperty<TerraformProperty<string>>("default_log_level");
        set => this.WithProperty("default_log_level", value);
    }

    /// <summary>
    /// The disable_all_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableAllLogs
    {
        get => GetProperty<TerraformProperty<bool>>("disable_all_logs");
        set => this.WithProperty("disable_all_logs", value);
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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

}
