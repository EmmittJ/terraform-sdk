using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudfront_realtime_log_config.
/// </summary>
public class AwsCloudfrontRealtimeLogConfigDataSource : TerraformDataSource
{
    public AwsCloudfrontRealtimeLogConfigDataSource(string name) : base("aws_cloudfront_realtime_log_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("fields");
        SetOutput("sampling_rate");
        SetOutput("id");
        SetOutput("name");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The fields attribute.
    /// </summary>
    public TerraformExpression Fields => this["fields"];

    /// <summary>
    /// The sampling_rate attribute.
    /// </summary>
    public TerraformExpression SamplingRate => this["sampling_rate"];

}
