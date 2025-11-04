using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_resource_policy resource.
/// </summary>
public class AwsCloudwatchLogResourcePolicy : TerraformResource
{
    public AwsCloudwatchLogResourcePolicy(string name) : base("aws_cloudwatch_log_resource_policy", name)
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
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_name attribute.
    /// </summary>
    public string? PolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_name")?.Value;
        set => this.WithProperty("policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
