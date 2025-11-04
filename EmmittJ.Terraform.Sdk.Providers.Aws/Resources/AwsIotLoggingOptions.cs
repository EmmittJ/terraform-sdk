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
    public string? DefaultLogLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_log_level")?.Value;
        set => this.WithProperty("default_log_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disable_all_logs attribute.
    /// </summary>
    public bool? DisableAllLogs
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_all_logs")?.Value;
        set => this.WithProperty("disable_all_logs", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
