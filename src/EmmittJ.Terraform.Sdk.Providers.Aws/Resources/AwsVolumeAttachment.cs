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
    public TerraformLiteralProperty<string>? DeviceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_name");
        set => this.WithProperty("device_name", value);
    }

    /// <summary>
    /// The force_detach attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDetach
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_detach");
        set => this.WithProperty("force_detach", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The stop_instance_before_detaching attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? StopInstanceBeforeDetaching
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("stop_instance_before_detaching");
        set => this.WithProperty("stop_instance_before_detaching", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VolumeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("volume_id");
        set => this.WithProperty("volume_id", value);
    }

}
