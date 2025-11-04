using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_guardduty_publishing_destination resource.
/// </summary>
public class AwsGuarddutyPublishingDestination : TerraformResource
{
    public AwsGuarddutyPublishingDestination(string name) : base("aws_guardduty_publishing_destination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    public string? DestinationArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_arn")?.Value;
        set => this.WithProperty("destination_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    public string? DestinationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_type")?.Value;
        set => this.WithProperty("destination_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public string? DetectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("detector_id")?.Value;
        set => this.WithProperty("detector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The kms_key_arn attribute.
    /// </summary>
    public string? KmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_arn")?.Value;
        set => this.WithProperty("kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
