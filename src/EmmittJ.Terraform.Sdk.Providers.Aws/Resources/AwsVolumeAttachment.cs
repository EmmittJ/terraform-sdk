using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsVolumeAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => this.WithProperty("device_name", value);
    }

    /// <summary>
    /// The force_detach attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDetach
    {
        get => GetProperty<TerraformProperty<bool>>("force_detach");
        set => this.WithProperty("force_detach", value);
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? SkipDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("skip_destroy");
        set => this.WithProperty("skip_destroy", value);
    }

    /// <summary>
    /// The stop_instance_before_detaching attribute.
    /// </summary>
    public TerraformProperty<bool>? StopInstanceBeforeDetaching
    {
        get => GetProperty<TerraformProperty<bool>>("stop_instance_before_detaching");
        set => this.WithProperty("stop_instance_before_detaching", value);
    }

    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformProperty<string> VolumeId
    {
        get => GetProperty<TerraformProperty<string>>("volume_id");
        set => this.WithProperty("volume_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsVolumeAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsVolumeAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
