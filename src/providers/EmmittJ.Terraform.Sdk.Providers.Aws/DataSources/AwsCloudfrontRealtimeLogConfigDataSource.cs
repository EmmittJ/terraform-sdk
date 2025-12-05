using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudfront_realtime_log_config Terraform data source.
/// Retrieves information about a aws_cloudfront_realtime_log_config.
/// </summary>
public partial class AwsCloudfrontRealtimeLogConfigDataSource(string name) : TerraformDataSource("aws_cloudfront_realtime_log_config", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The fields attribute.
    /// </summary>
    public TerraformSet<string> Fields
        => CreateReference("fields");

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    public TerraformValue<double> SamplingRate
        => CreateReference("sampling_rate");

}
