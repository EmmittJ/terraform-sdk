using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_location_tracker_association resource.
/// </summary>
public class AwsLocationTrackerAssociation : TerraformResource
{
    public AwsLocationTrackerAssociation(string name) : base("aws_location_tracker_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    public string? ConsumerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("consumer_arn")?.Value;
        set => this.WithProperty("consumer_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tracker_name attribute.
    /// </summary>
    public string? TrackerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tracker_name")?.Value;
        set => this.WithProperty("tracker_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
