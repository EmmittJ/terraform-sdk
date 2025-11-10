using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_logs in .
/// Nesting mode: list
/// </summary>
public class AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock : TerraformBlock
{
    /// <summary>
    /// The include_trust_context attribute.
    /// </summary>
    public TerraformProperty<bool>? IncludeTrustContext
    {
        get => GetProperty<TerraformProperty<bool>>("include_trust_context");
        set => WithProperty("include_trust_context", value);
    }

    /// <summary>
    /// The log_version attribute.
    /// </summary>
    public TerraformProperty<string>? LogVersion
    {
        get => GetProperty<TerraformProperty<string>>("log_version");
        set => WithProperty("log_version", value);
    }

}

/// <summary>
/// Manages a aws_verifiedaccess_instance_logging_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsVerifiedaccessInstanceLoggingConfiguration : TerraformResource
{
    public AwsVerifiedaccessInstanceLoggingConfiguration(string name) : base("aws_verifiedaccess_instance_logging_configuration", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformProperty<string> VerifiedaccessInstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => this.WithProperty("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public List<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock>? AccessLogs
    {
        get => GetProperty<List<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock>>("access_logs");
        set => this.WithProperty("access_logs", value);
    }

}
