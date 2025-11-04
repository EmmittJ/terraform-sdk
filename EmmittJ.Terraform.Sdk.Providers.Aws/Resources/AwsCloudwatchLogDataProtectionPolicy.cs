using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_data_protection_policy resource.
/// </summary>
public class AwsCloudwatchLogDataProtectionPolicy : TerraformResource
{
    public AwsCloudwatchLogDataProtectionPolicy(string name) : base("aws_cloudwatch_log_data_protection_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The log_group_name attribute.
    /// </summary>
    public string? LogGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_group_name")?.Value;
        set => this.WithProperty("log_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
