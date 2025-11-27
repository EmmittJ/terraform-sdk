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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The fields attribute.
    /// </summary>
    public TerraformSet<string> Fields
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "fields").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    public TerraformValue<double> SamplingRate
    {
        get => new TerraformReference<double>(this, "sampling_rate");
    }

}
