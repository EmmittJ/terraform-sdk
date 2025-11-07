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
    public TerraformProperty<string>? DestinationArn
    {
        get => GetProperty<TerraformProperty<string>>("destination_arn");
        set => this.WithProperty("destination_arn", value);
    }

    /// <summary>
    /// The destination_type attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationType
    {
        get => GetProperty<TerraformProperty<string>>("destination_type");
        set => this.WithProperty("destination_type", value);
    }

    /// <summary>
    /// The detector_id attribute.
    /// </summary>
    public TerraformProperty<string>? DetectorId
    {
        get => GetProperty<TerraformProperty<string>>("detector_id");
        set => this.WithProperty("detector_id", value);
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
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_arn");
        set => this.WithProperty("kms_key_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
