using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_disk_attachment resource.
/// </summary>
public class AwsLightsailDiskAttachment : TerraformResource
{
    public AwsLightsailDiskAttachment(string name) : base("aws_lightsail_disk_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disk_name attribute.
    /// </summary>
    public string? DiskName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_name")?.Value;
        set => this.WithProperty("disk_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    public string? DiskPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_path")?.Value;
        set => this.WithProperty("disk_path", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_name attribute.
    /// </summary>
    public string? InstanceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_name")?.Value;
        set => this.WithProperty("instance_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
