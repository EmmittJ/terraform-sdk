using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_log_destination_policy resource.
/// </summary>
public class AwsCloudwatchLogDestinationPolicy : TerraformResource
{
    public AwsCloudwatchLogDestinationPolicy(string name) : base("aws_cloudwatch_log_destination_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_policy attribute.
    /// </summary>
    public string? AccessPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_policy")?.Value;
        set => this.WithProperty("access_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_name attribute.
    /// </summary>
    public string? DestinationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_name")?.Value;
        set => this.WithProperty("destination_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_update attribute.
    /// </summary>
    public bool? ForceUpdate
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_update")?.Value;
        set => this.WithProperty("force_update", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
