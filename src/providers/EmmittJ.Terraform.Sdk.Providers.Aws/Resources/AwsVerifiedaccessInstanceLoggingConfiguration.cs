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
        set => SetProperty("include_trust_context", value);
    }

    /// <summary>
    /// The log_version attribute.
    /// </summary>
    public TerraformProperty<string>? LogVersion
    {
        set => SetProperty("log_version", value);
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
        SetOutput("id");
        SetOutput("region");
        SetOutput("verifiedaccess_instance_id");
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
    /// The verifiedaccess_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VerifiedaccessInstanceId is required")]
    public required TerraformProperty<string> VerifiedaccessInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("verifiedaccess_instance_id");
        set => SetProperty("verifiedaccess_instance_id", value);
    }

    /// <summary>
    /// Block for access_logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLogs is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessLogs block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLogs block(s) allowed")]
    public List<AwsVerifiedaccessInstanceLoggingConfigurationAccessLogsBlock>? AccessLogs
    {
        set => SetProperty("access_logs", value);
    }

}
