using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_volume_attachment resource.
/// </summary>
public class AwsVolumeAttachment : TerraformResource
{
    public AwsVolumeAttachment(string name) : base("aws_volume_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The device_name attribute.
    /// </summary>
    public string? DeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_name")?.Value;
        set => this.WithProperty("device_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_detach attribute.
    /// </summary>
    public bool? ForceDetach
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_detach")?.Value;
        set => this.WithProperty("force_detach", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public bool? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy")?.Value;
        set => this.WithProperty("skip_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The stop_instance_before_detaching attribute.
    /// </summary>
    public bool? StopInstanceBeforeDetaching
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("stop_instance_before_detaching")?.Value;
        set => this.WithProperty("stop_instance_before_detaching", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public string? VolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_id")?.Value;
        set => this.WithProperty("volume_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
