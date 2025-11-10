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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskName is required")]
    public required TerraformProperty<string> DiskName
    {
        get => GetProperty<TerraformProperty<string>>("disk_name");
        set => this.WithProperty("disk_name", value);
    }

    /// <summary>
    /// The disk_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskPath is required")]
    public required TerraformProperty<string> DiskPath
    {
        get => GetProperty<TerraformProperty<string>>("disk_path");
        set => this.WithProperty("disk_path", value);
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
    /// The instance_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceName is required")]
    public required TerraformProperty<string> InstanceName
    {
        get => GetProperty<TerraformProperty<string>>("instance_name");
        set => this.WithProperty("instance_name", value);
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
